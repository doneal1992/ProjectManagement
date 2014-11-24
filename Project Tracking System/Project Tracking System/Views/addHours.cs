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
    public partial class addHours : Form
    {
        DatabaseController myController = new DatabaseController();
        string projectID;
        public addHours(string projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int projectID = Int32.Parse(this.projectID);
                int designHours = Int32.Parse(designHoursTxtbox.Text);
                int codeHours = Int32.Parse(codingHoursTxtBox.Text);
                int testingHours = Int32.Parse(testingHoursTxtbox.Text);
                int requirementsAnalysisHours = Int32.Parse(requirementsAnalysisTxtbox.Text);
                int projectManagementHours = Int32.Parse(projManagementHoursTxtbox.Text);
                if (myController.addNewHours(projectID, designHours, codeHours, requirementsAnalysisHours, testingHours, projectManagementHours) == true)
                {
                    MessageBox.Show("Effort hours have been stored");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Effort Hours for this project already exists, please go to edit the project to change them");
                    this.Close();
                }
            }
            catch (Exception notNumberEntry)
            {
                MessageBox.Show("You can only enter numbers(mins) into the text box, Please Try Again");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
