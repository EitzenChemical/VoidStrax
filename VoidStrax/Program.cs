﻿using System;
using System.Windows.Forms;
using VoidStrax;

namespace InsuranceClientApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск формы входа
            Application.Run(new LoginForm());
        }
    }
}