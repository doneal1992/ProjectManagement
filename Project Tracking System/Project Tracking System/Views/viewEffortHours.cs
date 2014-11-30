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
    public partial class viewEffortHours : Form
    {
        private int projectID;
        private DatabaseController myController;
        private string[] effortHoursArray;
        public viewEffortHours(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.myController = new DatabaseController();
            this.effortHoursArray = this.myController.getEfforHoursByProjectID(this.projectID);
            this.designHoursTxtbox.Text = effortHoursArray[0];
            this.codingHoursTxtBox.Text = effortHoursArray[1];
            this.requirementsAnalysisTxtbox.Text = effortHoursArray[2];
            this.testingHoursTxtbox.Text = effortHoursArray[3];
            this.projManagementHoursTxtbox.Text = effortHoursArray[4];
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (designHoursTxtbox.Text.Length > 0 && codingHoursTxtBox.Text.Length > 0 && requirementsAnalysisTxtbox.Text.Length > 0 && testingHoursTxtbox.Text.Length > 0 && projManagementHoursTxtbox.Text.Length > 0)
                {
                    this.myController.updateEfforHoursByProjectId(this.projectID, Int32.Parse(this.designHoursTxtbox.Text), Int32.Parse(this.codingHoursTxtBox.Text), Int32.Parse(requirementsAnalysisTxtbox.Text), Int32.Parse(testingHoursTxtbox.Text), Int32.Parse(projManagementHoursTxtbox.Text));

                }
                else
                {
                    MessageBox.Show("You must enter all information, it cannot be left blank");
                }
            }
            catch (Exception numberException)
            {
                MessageBox.Show("You can only enter numbers");
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.designHoursTxtbox.ReadOnly = false;
            this.codingHoursTxtBox.ReadOnly = false;
            this.testingHoursTxtbox.ReadOnly = false;
            this.projManagementHoursTxtbox.ReadOnly = false;
            this.requirementsAnalysisTxtbox.ReadOnly = false;
           
        }
    }
}
