using VoidStrax;

namespace VoidStraxClient
{
    internal static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ������ ����� �����
            Application.Run(new LoginForm());
        }
    }
}