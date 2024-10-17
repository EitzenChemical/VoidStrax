namespace VoidStraxEmployee
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск формы для сотрудников
            Application.Run(new EmployeeLoginForm());
        }
    }
}