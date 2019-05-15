using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOJ_Interactions
{
    public partial class Main : Form
    {
        PersonSearch uc;
        VehicleSearch vs;
        Home hs;
        bool connectionComplete;

        public Main()
        {
            InitializeComponent();
            connectionComplete = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hs = new Home();
            hs.Dock = DockStyle.Right;
            this.Controls.Add(hs);
            connectionStatusLabel.Text = "Establishing Connection...";
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = homeButton.Height;
            sidePanel.Top = homeButton.Top;

            //Ensure that other controls closed
            if (this.Controls.Contains(vs))
            {
                this.Controls.Remove(vs);
            }
            else if (this.Controls.Contains(uc))
            {
                this.Controls.Remove(uc);
            }

            if (!this.Controls.Contains(hs))
            {
                this.Controls.Add(hs);
            }
        }

        private void personButton_Click(object sender, EventArgs e)
        {
            if (!connectionComplete)
                return;
            sidePanel.Height = personButton.Height;
            sidePanel.Top = personButton.Top;

            //Ensure that other controls closed
            if(this.Controls.Contains(vs))
            {
                this.Controls.Remove(vs);
            }
            else if (this.Controls.Contains(hs))
            {
                this.Controls.Remove(hs);
            }

            //New control handle
            if (uc == null)
            {
                //Brings person search item over
                uc = new PersonSearch();
                uc.Dock = DockStyle.Right;
                this.Controls.Add(uc);
            }
            else if (!this.Controls.Contains(uc))
            {
                this.Controls.Add(uc);
            }
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            if (!connectionComplete)
                return;
            sidePanel.Height = vehicleButton.Height;
            sidePanel.Top = vehicleButton.Top;

            //Ensure that other controls closed
            if (this.Controls.Contains(uc))
            {
                this.Controls.Remove(uc);
            }
            else if (this.Controls.Contains(hs))
            {
                this.Controls.Remove(hs);
            }

            //New control handle
            if (vs == null)
            {
                //Brings person search item over
                vs = new VehicleSearch();
                vs.Dock = DockStyle.Right;
                this.Controls.Add(vs);
            }
            else if (!this.Controls.Contains(vs))
            {
                this.Controls.Add(vs);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connectionTime_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                connectionStatusLabel.Text = "Status: Connected";
                connectionStatusLabel.ForeColor = Color.FromName("Green");
                connectionTime.Enabled = false;
                connectionComplete = true;
            }
            else
                progressBar1.PerformStep();
        }
    }
}
