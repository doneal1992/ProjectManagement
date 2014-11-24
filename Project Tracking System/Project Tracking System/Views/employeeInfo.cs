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
    public partial class employeeInfo : Form
    {
        DatabaseController myController = new DatabaseController();
        string projectID;
        public employeeInfo(string projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (projectID.Length > 0)
            {
                
                if (myController.addNewEmployee(Int32.Parse(projectID), firstNameTxtbox.Text, lastNameTxtbox.Text, positionTxtbox.Text))
                {
                    MessageBox.Show(this.firstNameTxtbox.Text + " " + this.lastNameTxtbox.Text + " has been saved");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("That Employee already exists on the current project");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a Manager ID before adding Employee, Requirements, Risks, or Hours");
            }
        }
    }
}
