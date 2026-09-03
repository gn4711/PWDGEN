using System.Runtime.InteropServices;

namespace PWDGEN
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check whether started from a console
            if (AttachConsole(ATTACH_PARENT_PROCESS))
            {
                // Started from a console - generate and print a password (default: 100 bits)
                string password = PasswordGenerator.Generate(100);
                Console.WriteLine(password);
                FreeConsole();
                return;
            }

            // Normal start - show the window
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}