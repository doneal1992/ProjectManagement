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
    public partial class editEmployees : Form
    {
        public editEmployees()
        {
            InitializeComponent();
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Form addEmployee = new employeeInfo();
            addEmployee.ShowDialog();
        }

        private void removeEmpBtn_Click(object sender, EventArgs e)
        {
            Form removeEmployee = new employeeInfo();
            removeEmployee.ShowDialog();
        }
    }
}
