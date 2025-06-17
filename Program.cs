using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ControleFinanceiroDesktop.Data;
using ControleFinanceiroDesktop.Controllers;
using ControleFinanceiroDesktop.Services.CategoryServices;
using ControleFinanceiroDesktop.Services.Header;
using ControleFinanceiroDesktop.Services.StatementTypeServices;
using ControleFinanceiroDesktop.Services.StatementServices;

namespace ControleFinanceiroDesktop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseFirebird(@"User=SYSDBA;Password=masterkey;Database=C:\Users\LeonardoL\Documents\BackupBancoDados\DATABASE.FDB;DataSource=localhost;Port=3050;Dialect=3;Charset=ISO8859_1;"));

            services.AddTransient<MainFormController>();
            services.AddTransient<MainFormServices>();
            services.AddTransient<StatementTypeSaveServices>();
            services.AddTransient<StatementTypeDeleteServices>();
            services.AddTransient<CategorySaveServices>();
            services.AddTransient<CategoryListServices>();
            services.AddTransient<CategoryGetServices>();
            services.AddTransient<CategoryDeleteServices>();
            services.AddTransient<StatementGetServices>();
            services.AddTransient<SatatementSaveServices>();
            services.AddTransient<StatementDeleteServices>();
			services.AddTransient<StatementExcelImportService>();
            services.AddTransient<CategoryReidentificationServices>();
            services.AddTransient<MainForm>();

            using var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }
    }
}
