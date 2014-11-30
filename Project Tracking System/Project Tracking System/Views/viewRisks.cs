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

namespace Project_Tracking_System.Views
{
    public partial class viewRisks : Form
    {
        private DatabaseController myController;
        private int projectID;
        public viewRisks(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.myController = new DatabaseController();
            this.richTextBox1.Text = this.richTextBox1.Text + this.myController.getProjectRisksByProjectID(this.projectID);
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRiskBtn_Click(object sender, EventArgs e)
        {
            Form addNewRisk = new addRisk(projectID.ToString());
            addNewRisk.ShowDialog();
        }

       
    }
}
