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
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = vehicleButton.Height;
            sidePanel.Top = vehicleButton.Top;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
