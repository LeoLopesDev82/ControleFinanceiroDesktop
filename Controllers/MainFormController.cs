using ControleFinanceiroDesktop.Models.DTOs;
using ControleFinanceiroDesktop.Models.ViewModels;
using ControleFinanceiroDesktop.Responses;
using ControleFinanceiroDesktop.Services.CategoryServices;
using ControleFinanceiroDesktop.Services.Header;
using ControleFinanceiroDesktop.Services.StatementServices;
using ControleFinanceiroDesktop.Services.StatementTypeServices;

namespace ControleFinanceiroDesktop.Controllers
{
    public class MainFormController
    {
        private readonly MainFormServices _mainFormServices;
        private readonly StatementTypeSaveServices _statementTypeSaveServices;
        private readonly StatementTypeDeleteServices _statementTypeDeleteServices;
        private readonly CategorySaveServices _categorySaveServices;
        private readonly CategoryListServices _categoryListServices;
        private readonly CategoryGetServices _categoryGetServices;
        private readonly CategoryDeleteServices _categoryDeleteServices;
        private readonly StatementGetServices _statementGetServices;
        private readonly SatatementSaveServices _stationSaveServices;
        private readonly StatementDeleteServices _statementDeleteServices;
        private readonly StatementExcelImportService _statementExcelImportService;
        private readonly CategoryReidentificationServices _categoryReidentificationServices;

		public MainFormController(
            MainFormServices headerServices,
            StatementTypeSaveServices saveServices,
            StatementTypeDeleteServices deleteServices,
            CategorySaveServices categorySaveServices,
            CategoryListServices categoryListServices,
            CategoryGetServices categoryGetServices,
            CategoryDeleteServices categoryDeleteServices,
            StatementGetServices statementGetServices,
            SatatementSaveServices stationSaveServices,
			StatementDeleteServices statementDeleteServices,
            StatementExcelImportService statementExcelImportService,
            CategoryReidentificationServices categoryReidentificationServices)
        {
            _mainFormServices = headerServices;
            _statementTypeSaveServices = saveServices;
            _statementTypeDeleteServices = deleteServices;
            _categorySaveServices = categorySaveServices;
            _categoryListServices = categoryListServices;
            _categoryGetServices = categoryGetServices;
            _categoryDeleteServices = categoryDeleteServices;
            _statementGetServices = statementGetServices;
            _stationSaveServices = stationSaveServices;
            _statementDeleteServices = statementDeleteServices;
            _statementExcelImportService = statementExcelImportService;
            _categoryReidentificationServices = categoryReidentificationServices;
		}

        public MainFormModel GetMainFormModel(DateTime startDate, DateTime endDate, int id)
        {
            MainFormModel model = new MainFormModel();

            model.ButtonsInfo = _mainFormServices.GetButtonInfoList();
            model.statementDtos = _mainFormServices.GetStatementGridList(startDate, endDate, id);
            model.SummaryDto = _mainFormServices.GetSummaryDto(startDate, endDate, id);
            model.CreditSummaries = _mainFormServices.GetCreditSummaries(startDate, endDate, id);
            model.DebitSummaries = _mainFormServices.GetDebitSummaries(startDate, endDate, id);

			return model;
        }

        public SaveResult SaveStatementType(string description, int id)
        {
            return _statementTypeSaveServices.SaveStatementType(description, id);
        }

        public SaveResult DeleteStatementType(int id)
        {
            return _statementTypeDeleteServices.DeleteStatementType(id);
        }

        public SaveResult SaveCategoryDetails(int? id, string? description, string? selectedRadio, string? identifiers)
        {
            return _categorySaveServices.Save(id, description, selectedRadio, identifiers);
        }

        public List<ListItemDto> GetCategoryList() 
        { 
            return _categoryListServices.GetList();
        }

        public CategoryDto? GetCategory(int id) 
        { 
            return _categoryGetServices.GetDto(id);
        }

        public SaveResult DeleteCategory(int id)
        {
            return _categoryDeleteServices.Delete(id);           
        }

        public StatementDto? GetStatement(int id)
        {
            return _statementGetServices.GetDto(id);
        }

        public SaveResult SaveStatement(StatementDto dto)
        {
            return _stationSaveServices.Save(dto);
        }

		public SaveResult DeleteStatement(int id)
		{
			return _statementDeleteServices.Delete(id);
		}

		public SaveResult ImportExcel(string filePath, int id)
		{
            return _statementExcelImportService.DoImport(filePath, id);
		}

        public bool Reidentify(DateTime startDate, DateTime endDate) 
        { 
            return _categoryReidentificationServices.Reidentify(startDate, endDate);
        }
    }
}
