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
    public partial class addRisk : Form
    {
        private string riskID;
        private DatabaseController myController;
        public addRisk(string riskID)
        {
            InitializeComponent();
            this.riskID = riskID;
            myController = new DatabaseController();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (statusTxtbox.Text.Length > 0 && descriptionTxtbox.Text.Length > 0)
            {
                int intRiskID = Int32.Parse(this.riskID);
                if (myController.addNewRisk(intRiskID,descriptionTxtbox.Text,statusTxtbox.Text) == true)
                {
                    MessageBox.Show("Risk was added to project");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Risk already exists");
                }
            }
            else
            {
                MessageBox.Show("You must enter all information");
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
