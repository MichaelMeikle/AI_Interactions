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
    public partial class PersonSearch : UserControl
    {
        PersonGenerator personGen;

        public PersonSearch()
        {
            InitializeComponent();
            personGen = new PersonGenerator();
        }

        private void PersonSearch_Load(object sender, EventArgs e)
        {
            firstNameInput.Text = "John";
            lastNameInput.Text = "Doe";
            dobInput.Text = "11/27/1996";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            resetFlags();
            bool incompleteSearch = false;
            if (firstNameInput.Text.CompareTo("") == 0)
            {
                incompleteSearch = true;
            }
            else if (lastNameInput.Text.CompareTo("") == 0)
            {
                incompleteSearch = true;
            }
            else if (dobInput.Text.CompareTo("") == 0)
            {
                incompleteSearch = true;
            }


            string fullName = firstNameInput.Text + " " + lastNameInput.Text;
            nameLabel.Text = fullName;
            dobLabel.Text = dobInput.Text;

            if (genderInput.Text.CompareTo("") == 0)
                genderLabel.Text = "N/A";
            else
                genderLabel.Text = genderInput.Text;

            if (raceInput.Text.CompareTo("") == 0)
                raceLabel.Text = "N/A";
            else
                raceLabel.Text = raceInput.Text;

            //Clear input
            firstNameInput.Clear();
            lastNameInput.Clear();
            dobInput.Clear();
            genderInput.Clear();
            raceInput.Clear();

            //If search fields not satisfied, all labels set to N/A
            if (incompleteSearch)
            {
                nameLabel.Text = "N/A";
                dobLabel.Text = "N/A";
                genderLabel.Text = "N/A";
                raceLabel.Text = "N/A";
                return;
            }
            Person person = personGen.generatePersonObj(fullName, dobLabel.Text);
            if(person.WarrantStatus.CompareTo("None") != 0)
            {
                warrantOutput.ForeColor = Color.FromName("Red");
            }
            if(person.LicenseStatus.CompareTo("Valid") != 0)
            {
                licenseOutput.ForeColor = Color.FromName("Red");
            }
            warrantOutput.Text = person.WarrantStatus;
            licenseOutput.Text = person.LicenseStatus;
            citationCountOutput.Text = person.CitationCount.ToString();
            occupationOutput.Text = person.Occupation;
            addressOutput.Text = person.Address;
        }
        //Clears all text fields and current information return labels
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameInput.Clear();
            lastNameInput.Clear();
            dobInput.Clear();
            genderInput.Clear();
            raceInput.Clear();

            nameLabel.Text = "N/A";
            dobLabel.Text = "N/A";
            genderLabel.Text = "N/A";
            raceLabel.Text = "N/A";

            warrantOutput.Text = "N/A";
            licenseOutput.Text = "N/A";
            citationCountOutput.Text = "N/A";
            occupationOutput.Text = "N/A";
            addressOutput.Text = "N/A";
        }
        private void resetFlags()
        {
            warrantOutput.Text = "N/A";
            licenseOutput.Text = "N/A";
            citationCountOutput.Text = "N/A";
            occupationOutput.Text = "N/A";
            addressOutput.Text = "N/A";
            licenseOutput.ForeColor = Color.FromName("Black");
            warrantOutput.ForeColor = Color.FromName("Black");
        }
    }
}
