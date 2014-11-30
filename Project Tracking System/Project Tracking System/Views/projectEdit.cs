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
using Project_Tracking_System.Views;

namespace Project_Tracking_System
{
    public partial class projectEdit : Form
    {
        DatabaseController myController;
        int projectID;
        public projectEdit(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.myController = new DatabaseController();
            this.projectNameLbl.Text = myController.getProjectNameByProjetID(projectID);
            this.managerIDLBL.Text = this.projectID.ToString();
            if (this.projectNameLbl.Text.Length == 0)
            {
                MessageBox.Show("Project not found with that ID, please try again");
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewEmpBtn_Click(object sender, EventArgs e)
        {
            Form editEmployee = new editEmployees(this.projectID);
            editEmployee.ShowDialog();
        }

        private void viewRiskBtn_Click(object sender, EventArgs e)
        {
            Form viewRisks = new viewRisks(this.projectID);
            viewRisks.ShowDialog();
        }

        private void viewReqBtn_Click(object sender, EventArgs e)
        {
            Form viewRequirement = new viewRequirements(projectID);
            viewRequirement.ShowDialog();
        }

        private void viewEffortBtn_Click(object sender, EventArgs e)
        {
            Form viewEffortHours = new viewEffortHours(this.projectID);
            viewEffortHours.ShowDialog();
        }

       
    }
}
