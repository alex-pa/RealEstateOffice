using System;
using System.Windows.Forms;

namespace TheRealEstateOffice
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
            try
            {
                Application.Run(new Form1());
            }
            catch
            {
                MessageBox.Show("Создайте пустой текстовый документ 'places'\nс расширением txt в этой директории. Это необходимо\nдля коректного функционирования данной программы!");
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
