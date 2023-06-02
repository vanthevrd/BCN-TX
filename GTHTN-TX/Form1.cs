using GTHTN_TX.uc_Kolchuga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTHTN_TX
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        // Select Rada
        private void button_Kolchuga_Click_1(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            ShareVar.uc_Kolchuga_M0 = new uc_Kolchuga.uc_Kolchuga_M0() { Location = new Point(0, 0), Dock = DockStyle.Fill };//, Width = 1500, Height = 750 };
            panel_Main.Controls.Add(ShareVar.uc_Kolchuga_M0);
        }
        private void button_36D6_Click(object sender, EventArgs e)
        {

        }

        private void button_1L133_Click_1(object sender, EventArgs e)
        {

        }

        private void button_96L6E_Click_1(object sender, EventArgs e)
        {

        }
    }
}
