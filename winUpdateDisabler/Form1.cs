using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winUpdateDisabler
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void showUpdateState()
        {
            if (Convert.ToInt32(RegistryHelper.ReadValue(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate")) == 1)
            {
                lUpdateState.Text = "Оновлення Windows призупинено";
                lUpdateState.BackColor = Color.Pink;
            }
            else
            {
                lUpdateState.Text = "Оновлення Windows активне";
                lUpdateState.BackColor = Color.LightGreen;
            }
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            showUpdateState();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            RegistryHelper.WriteValue(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate", 0);
            showUpdateState();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            RegistryHelper.WriteValue(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate", 1);
            showUpdateState();
        }

    }
}
