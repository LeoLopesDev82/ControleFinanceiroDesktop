using ControleFinanceiroDesktop.Data;
using ControleFinanceiroDesktop.Models.Entities;
using ControleFinanceiroDesktop.Responses;
using OfficeOpenXml;
using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace ControleFinanceiroDesktop.Services.StatementServices
{
	public class StatementExcelImportService
	{
		private readonly AppDbContext _context;

        private readonly EntryIdServices _entryIdService;

        public StatementExcelImportService(AppDbContext context)
        {
            _context = context;
			_entryIdService = new EntryIdServices(context);
        }


        public SaveResult DoImport(string filePath, int id)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			var validateData = ValidateData(filePath);

			if (!validateData.Success) return validateData;

			return Save(filePath, id);
		}

		#region "subroutines"

		public SaveResult ValidateData(string filePath)
		{
			var errorBuilder = new StringBuilder();

			try
			{
				using var package = new ExcelPackage(new FileInfo(filePath));

				var worksheet = package.Workbook.Worksheets[0];
				int rowCount = worksheet.Dimension.Rows;

				for (int row = 2; row <= rowCount; row++)
				{
					string transactionDateStr = worksheet.Cells[row, 1].Text.Trim();
					string dueDateStr = worksheet.Cells[row, 2].Text.Trim();
					string description = worksheet.Cells[row, 3].Text.Trim();
					string amountStr = worksheet.Cells[row, 4].Text.Trim();

					if (!DateTime.TryParse(transactionDateStr, out _))
						errorBuilder.AppendLine($"Linha {row}, Coluna A: Data da Transação inválida.");

					if (!DateTime.TryParse(dueDateStr, out _))
						errorBuilder.AppendLine($"Linha {row}, Coluna B: Data de Vencimento inválida.");

					if (string.IsNullOrWhiteSpace(description))
						errorBuilder.AppendLine($"Linha {row}, Coluna C: Descrição não pode estar vazia.");
					else if (description.Length > 255)
						errorBuilder.AppendLine($"Linha {row}, Coluna C: Descrição excede 255 caracteres.");

					if (!decimal.TryParse(amountStr, NumberStyles.Number, new CultureInfo("pt-BR"), out _))
						errorBuilder.AppendLine($"Linha {row}, Coluna D: Valor inválido.");
				}

				if (errorBuilder.Length > 0)
				{
					return new SaveResult
					{
						Success = false,
						Message = "Erros encontrados na planilha:\n\n" + errorBuilder.ToString()
					};
				}

				return new SaveResult {	Success = true };
			}
			catch (Exception ex)
			{
				return new SaveResult
				{
					Success = false,
					Message = $"Erro ao validar a planilha: {ex.Message}"
				};
			}
		}

		public SaveResult Save(string filePath, int id)
		{
			try
			{
				using var package = new ExcelPackage(new FileInfo(filePath));
				var worksheet = package.Workbook.Worksheets[0];
				int rowCount = worksheet.Dimension.Rows;

				for (int row = 2; row <= rowCount; row++)
				{
					string transactionDateStr = worksheet.Cells[row, 1].Text.Trim();
					string dueDateStr = worksheet.Cells[row, 2].Text.Trim();
					string description = worksheet.Cells[row, 3].Text.Trim();
					string amountStr = worksheet.Cells[row, 4].Text.Trim();

					var statement = new Statement
					{
						TransactionDate = DateTime.TryParse(transactionDateStr, out DateTime transDate) ? transDate : null,
						DueDate = DateTime.TryParse(dueDateStr, out DateTime dueDate) ? dueDate : null,
						Description = description,
						Amount = decimal.TryParse(amountStr, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal amt) ? amt : null,
						EntryId = _entryIdService.GetEntryId(description),
						StatementTypeId = id
					};

					_context.Statement.Add(statement);
				}

				_context.SaveChanges();

				return new SaveResult
				{
					Success = true,
					Message = "Planilha importada com sucesso."
				};
			}
			catch (Exception ex)
			{
				return new SaveResult
				{
					Success = false,
					Message = $"Algo deu errado ao salvar os dados: {ex.Message}"
				};
			}
		}

		#endregion
	}
}
