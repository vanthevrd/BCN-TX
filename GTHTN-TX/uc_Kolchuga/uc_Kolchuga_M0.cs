using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTHTN_TX.uc_Kolchuga
{
    public partial class uc_Kolchuga_M0 : UserControl
    {
        uc_Kolchuga.uc_Kolchuga_M1 uc_Kolchuga_M1 = new uc_Kolchuga.uc_Kolchuga_M1() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 1500, Height = 750 };
        string Target_Kolchuga = null;
        public uc_Kolchuga_M0()
        {
            InitializeComponent();
        }
        // Select Target
        ///Select MP1-Kolchuga///
        private void button_MP1_Click(object sender, EventArgs e)
        {
            Target_Kolchuga = "RD_Kolchuga_MP1";
        }
        ///Select MP2-Kolchuga///
        private void button_MP2_Click(object sender, EventArgs e)
        {
            Target_Kolchuga = "RD_Kolchuga_MP2";
        }
        ///Select MP5-Kolchuga///
        private void button_MP5_Click(object sender, EventArgs e)
        {
            Target_Kolchuga = "RD_Kolchuga_MP5";
        }
        ///Select MP6-Kolchuga///
        private void button_MP6_Click(object sender, EventArgs e)
        {
            Target_Kolchuga = "RD_Kolchuga_MP6";
        }
        ///Select MP8-Kolchuga///
        private void button_MP8_Click(object sender, EventArgs e)
        {
            Target_Kolchuga = "RD_Kolchuga_MP8";
        }
        ///Select MP10-Kolchuga///
        private void button_MP10_Click(object sender, EventArgs e)
        {
            Target_Kolchuga = "RD_Kolchuga_MP10";
        }
        ///Get Target after select
        private void button_Next_Click(object sender, EventArgs e)
        {
            if(button_Next.Text == "TIẾP TỤC")
            {
                Case_Target(Target_Kolchuga);
                Console.WriteLine(tLP_uc_Kolchuga_M0.Width);
                Console.WriteLine(tLP_uc_Kolchuga_M0.Height);
                Console.WriteLine("////");
                button_Next.Text = "QUAY LẠI";
            }
            else
            {
                panel_uc_Kolchuga_M0.Controls.Clear();
                panel_uc_Kolchuga_M0.Controls.Add(tLP_uc_Kolchuga_M0);
                button_Next.Text = "TIẾP TỤC";
            }    

        }
        //// Case Target to Continue
        void Case_Target(string Target)
        {
            if(Target == "RD_Kolchuga_MP1")
            {
                panel_uc_Kolchuga_M0.Controls.Clear();
                uc_Kolchuga_M1 = new uc_Kolchuga.uc_Kolchuga_M1() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 1500, Height = 750 };
                panel_uc_Kolchuga_M0.Controls.Add(uc_Kolchuga_M1);
            }
            //else if (Target == "RD_Kolchuga_MP2")
            //{
            //    panel_uc_Kolchuga_M0.Controls.Clear();
            //    uc_Kolchuga_M2 = new uc_Kolchuga.uc_Kolchuga_M2() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 1500, Height = 750 };
            //    panel_uc_Kolchuga_M0.Controls.Add(uc_Kolchuga_M2);
            //}
            //else if (Target == "RD_Kolchuga_MP5")
            //{
            //    panel_uc_Kolchuga_M0.Controls.Clear();
            //    uc_Kolchuga_M3 = new uc_Kolchuga.uc_Kolchuga_M3() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 1500, Height = 750 };
            //    panel_uc_Kolchuga_M0.Controls.Add(uc_Kolchuga_M3);
            //}
            //else if (Target == "RD_Kolchuga_MP6")
            //{
            //    panel_uc_Kolchuga_M0.Controls.Clear();
            //    uc_Kolchuga_M4 = new uc_Kolchuga.uc_Kolchuga_M4() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 1500, Height = 750 };
            //    panel_uc_Kolchuga_M0.Controls.Add(uc_Kolchuga_M4);
            //}
            //else if (Target == "RD_Kolchuga_MP8")
            //{
            //    panel_uc_Kolchuga_M0.Controls.Clear();
            //    uc_Kolchuga_M5 = new uc_Kolchuga.uc_Kolchuga_M5() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 1500, Height = 750 };
            //    panel_uc_Kolchuga_M0.Controls.Add(uc_Kolchuga_M5);
            //}
            //else if (Target == "RD_Kolchuga_MP10")
            //{
            //    panel_uc_Kolchuga_M0.Controls.Clear();
            //    uc_Kolchuga_M6 = new uc_Kolchuga.uc_Kolchuga_M6() { Location = new Point(0, 0), Dock = DockStyle.Fill, Width = 1500, Height = 750 };
            //    panel_uc_Kolchuga_M0.Controls.Add(uc_Kolchuga_M6);
            //}
        }

        
    }
}
