using processorUpdater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winUpdateDisabler
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (AdminChecker.IsUserAdministrator())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new fMain());
            }
            else
            {
                MessageBox.Show(
                    "Для зміни стану оновлень потрібно мати права адміністратора!\nБудь ласка, перезапустіть застосунок з правами адміністратора",
                    "winUpdateDisabler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }
    }
}
