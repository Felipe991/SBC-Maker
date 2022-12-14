using SBC_Maker.Interfaz_grafica;
using static SBC_Maker.Logica.FormListener;

namespace SBC_Maker.Logica
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            instanceNewForm(new MenuPrincipal());
            Application.Run();
        }
    }
}