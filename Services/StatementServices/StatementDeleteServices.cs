using ControleFinanceiroDesktop.Data;
using ControleFinanceiroDesktop.Responses;

namespace ControleFinanceiroDesktop.Services.StatementServices
{
	public class StatementDeleteServices
	{
		private readonly AppDbContext _context;

		public StatementDeleteServices(AppDbContext context)
		{
			_context = context;
		}

		public SaveResult Delete(int id)
		{
			try
			{
				var statement = _context.Statement.Find(id);

				if (statement == null) return new SaveResult { Success = false, Message = "Registro não encontrado." };

				_context.Statement.Remove(statement);
				_context.SaveChanges();

				return new SaveResult {	Success = true,	Message = "Registro excluído com sucesso." };
			}
			catch (Exception)
			{
				return new SaveResult {	Success = false, Message = "Ocorreu um erro inesperado e não foi possível concluir a exclusão."	};
			}
		}
	}
}
