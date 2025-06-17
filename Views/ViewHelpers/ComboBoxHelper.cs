using ControleFinanceiroDesktop.Models.DTOs;

namespace ControleFinanceiroDesktop.Views.ViewHelpers
{
    public class ComboBoxHelper
    {
        public static int? GetId(List<ListItemDto> list, string description)
        {
            if (string.IsNullOrWhiteSpace(description) || list == null) return null;

            var item = list.FirstOrDefault(x => x.Description == description);

            return item?.Id;
        }

        public static string GetDescription(List<ListItemDto> list, int id)
        {
            if (list == null) return string.Empty;

            var item = list.FirstOrDefault(x => x.Id == id);

            return item?.Description ?? string.Empty;
        }
    }
}
