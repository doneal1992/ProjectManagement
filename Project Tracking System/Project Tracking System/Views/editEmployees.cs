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
    public partial class editEmployees : Form
    {
       private int projectID;
       private DatabaseController myController;
        public editEmployees(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.myController = new DatabaseController();
            this.richTextBox1.Text = this.richTextBox1.Text + myController.getProjectEmployeesByProjectID(this.projectID);
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Form addEmployee = new employeeInfo(this.projectID.ToString());
            addEmployee.ShowDialog();
        }

        private void removeEmpBtn_Click(object sender, EventArgs e)
        {
            Form removeEmployee = new employeeInfo("");
            removeEmployee.ShowDialog();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
