using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tracking_System
{
    public partial class projectEdit : Form
    {
        public projectEdit()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewEmpBtn_Click(object sender, EventArgs e)
        {
            Form editEmployee = new editEmployees();
            editEmployee.ShowDialog();
        }

        private void viewRiskBtn_Click(object sender, EventArgs e)
        {
            Form viewRisks = new viewRisksRequirements();
            viewRisks.ShowDialog();
        }

        private void viewReqBtn_Click(object sender, EventArgs e)
        {
            Form viewRisks = new viewRisksRequirements();
            viewRisks.ShowDialog();
        }

        private void viewEffortBtn_Click(object sender, EventArgs e)
        {
            Form viewEffortHours = new viewEffortHours();
            viewEffortHours.ShowDialog();
        }

       
    }
}
