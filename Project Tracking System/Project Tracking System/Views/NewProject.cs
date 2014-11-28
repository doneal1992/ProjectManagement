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

                    if (myController.newProject(Int32.Parse(projManagerIDTextbox.Text), projNameTextBox.Text, projDescriptionTxtBox.Text,projManagerFNameTextbox.Text,projManagerLNameTextbox.Text) == true)
                    {
                        MessageBox.Show("Project Saved");
                        projNameTextBox.ReadOnly = true;
                        projManagerFNameTextbox.ReadOnly = true;
                        projManagerLNameTextbox.ReadOnly = true;
                        projDescriptionTxtBox.ReadOnly = true;
                        projManagerIDTextbox.ReadOnly = true;
                        addEmpBtn.Visible = true;
                        addRequirementsBtn.Visible = true;
                        addHoursBtn.Visible = true;
                        addRisksBtn.Visible = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("A project with that Name and ID already exists or the Manager Id does not match the First Name and Last Name provided");
                        
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
            if (projManagerIDTextbox.Text.Length > 0)
            {
                Form addEmployee = new employeeInfo(projManagerIDTextbox.Text);
                addEmployee.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must enter the Project and Manager Information first");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (projManagerIDTextbox.Text.Length > 0)
            {
                Form addRequirements = new addRequirement(projManagerIDTextbox.Text);
                addRequirements.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must enter the Project and Manager Information first");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (projManagerIDTextbox.Text.Length > 0)
            {
                Form addRisks = new addRisk(projManagerIDTextbox.Text);
                addRisks.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must enter the Project and Manager Information first");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (projManagerIDTextbox.Text.Length > 0)
            {
                Form addHours = new addHours(projManagerIDTextbox.Text);
                addHours.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must enter the Project and Manager Information first");
            }
        }

        
    }
}
