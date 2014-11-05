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
    public partial class NewProject : Form
    {
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
            MessageBox.Show("Project Saved");
            this.Close();
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
