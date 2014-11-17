using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Tracking_System.Controller;

namespace Project_Tracking_System
{
    public partial class NewProject : Form
    {
        DatabaseController myController = new DatabaseController();
        public NewProject()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (projNameTextBox.Text.Length > 0 && projManagerIDTextbox.Text.Length > 0 && projDescriptionTxtBox.Text.Length > 0)
                {

                    if (myController.newProject(Int32.Parse(projManagerIDTextbox.Text), projNameTextBox.Text, projDescriptionTxtBox.Text) == true)
                    {
                        MessageBox.Show("Project Saved");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("A project with that name already exists");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You must enter at least Project Name, Manager ID, and Description");
                }
            }
            catch (FormatException idException)
            {
                MessageBox.Show("You must enter a number for Manager ID");
            }
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            Form addEmployee = new employeeInfo();
            addEmployee.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form addRequirements = new addRequirement();
            addRequirements.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form addRisks = new addRisk();
            addRisks.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form addHours = new addHours();
            addHours.ShowDialog();
        }

        
    }
}
