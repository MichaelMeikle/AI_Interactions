using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOJ_Interactions
{
    public partial class Home : UserControl
    {
        BoloGenerator boloGenerator;
        public Home()
        {
            boloGenerator = new BoloGenerator();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void boloTimer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100);

            //Clears old items randomly
            if (boloList.Items.Count > 0 && (num <= 25 || boloList.Items.Count >= 10))
                boloList.Items.RemoveAt(random.Next(boloList.Items.Count));

            if(num <= 65)
            {
                BoloVehicle newVehicle = boloGenerator.generateVehicle();
                foreach (BoloVehicle vehicle in boloList.Items)
                {
                    if (newVehicle.Equals(vehicle))
                        return;
                }
                boloList.Items.Add(boloGenerator.generateVehicle());
            }

        }
    }
}
