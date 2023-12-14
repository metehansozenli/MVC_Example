using System.Collections;

namespace MVCExperiment
{
    internal static class Program
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

            UsersView view = new UsersView();
            IList kullaniciModels = new ArrayList();
            KullaniciController controller = new KullaniciController(view, kullaniciModels);
            view.setController(controller);

            
            Application.Run(view);
        }
    }
}