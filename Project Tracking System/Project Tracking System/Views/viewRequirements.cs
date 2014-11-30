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
    public partial class viewRequirements : Form
    {
        private int projectID;
        private DatabaseController myController;

        public viewRequirements(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.myController = new DatabaseController();
            this.richTextBox1.Text = this.richTextBox1.Text + Environment.NewLine + this.myController.getProjectRequirementsByProjectID(this.projectID);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addRequirement newReq = new addRequirement(this.projectID.ToString());
            newReq.Show();
        }
    }
}
