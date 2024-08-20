using area_27_dashboard.Uteis;
using area_27_dashboard.Views;

namespace area_27_dashboard
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            new InicializaSystem();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}