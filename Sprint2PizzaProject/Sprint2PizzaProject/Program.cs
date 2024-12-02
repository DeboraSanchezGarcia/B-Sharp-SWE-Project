using System.Security.Cryptography.X509Certificates;

namespace Sprint2PizzaProject
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
            Application.Run(new MainMenuForm());
        }
        /// <summary>
        /// Used to say if an account is currently logged in or not
        /// </summary>
        private static bool loggedIn = false;
        /// <summary>
        /// Getter and setter for loggedIn
        /// </summary>
        public static bool LoggedIn
        {
            get { return loggedIn; }
            set { loggedIn = value; }
        }
    }
}