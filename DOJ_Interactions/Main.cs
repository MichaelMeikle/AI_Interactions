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

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {

            sidePanel.Height = homeButton.Height;
            sidePanel.Top = homeButton.Top;
        }

        private void personButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = personButton.Height;
            sidePanel.Top = personButton.Top;

            //Ensure that other controls closed
            if(vs != null)
            {
                this.Controls.Remove(vs);
            }

            //New control handle
            if(uc == null)
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
            else
            {
                uc.BringToFront();
            }
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = vehicleButton.Height;
            sidePanel.Top = vehicleButton.Top;

            //Ensure that other controls closed
            if (uc != null)
            {
                this.Controls.Remove(uc);
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
            else
            {
                vs.BringToFront();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
