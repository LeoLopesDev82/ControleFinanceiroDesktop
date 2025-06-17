using ControleFinanceiroDesktop.Data;
using ControleFinanceiroDesktop.Models.DTOs;

namespace ControleFinanceiroDesktop.Services.StatementServices
{
    public class StatementGetServices
    {
        private readonly AppDbContext _context;

        public StatementGetServices(AppDbContext context)
        {
            _context = context;
        }

        public StatementDto? GetDto(int id)
        {
            var statement = _context.Statement.FirstOrDefault(s => s.Id == id);

            if (statement == null) return null;

            return new StatementDto
            {
                Id = statement.Id,
                TransactionDate = statement.TransactionDate,
                DueDate = statement.DueDate,
                Amount = statement.Amount,
                Description = statement.Description,
                EntryId = statement.EntryId,
                StatementTypeId = statement.StatementTypeId
            };
        }
    }
}
