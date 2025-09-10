using Bira.Naveen;

namespace Bira
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
             Application.Run(new Naveen.Login());
            //Application.Run(new Naveen.Signup());
            // Application.Run(new Naveen.ProjectForm());
            //Application.Run(new MemberDashboard());
            //Application.Run(new TeamleadDashboard());
            //Application.Run(new EditTeam(1));

        }
    }
}
