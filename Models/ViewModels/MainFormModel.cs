using ControleFinanceiroDesktop.Models.Domain;
using ControleFinanceiroDesktop.Models.DTOs;

namespace ControleFinanceiroDesktop.Models.ViewModels
{
    public class MainFormModel
    {
        public List<ButtonInfoModel> ButtonsInfo { get; set; }
        public List<StatementGridDto> statementDtos { get; set; }
        public SummaryDto SummaryDto { get; set; }
        public List<CategorySummaryDto> CreditSummaries { get; set; }
        public List<CategorySummaryDto> DebitSummaries { get; set; }
    }
}
