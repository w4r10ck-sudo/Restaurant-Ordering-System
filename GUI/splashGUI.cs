using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System.GUI
{
    public partial class splashGUI : Form
    {
        public splashGUI()
        {
            InitializeComponent();
        }

        private void splashtimer_Tick(object sender, EventArgs e)
        {
            splashtimer.Stop();
            loginGUI loginui = new loginGUI();
            this.Hide();
            loginui.Show();
        }

        private void splashGUI_Shown(object sender, EventArgs e)
        {
            splashtimer.Start();
        }
    }
}
