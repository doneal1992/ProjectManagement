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
    public partial class addRequirement : Form
    {
        String requirementID;
        DatabaseController myController;
        String typeOfRequirement;
        public addRequirement(String requirementID)
        {
            InitializeComponent();
            this.requirementID = requirementID;
            this.myController = new DatabaseController();
          
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
          
            if (funcReqBtn.Checked == true)
            {
                this.typeOfRequirement = "Functional";
            }
            else
            {
                this.typeOfRequirement = "Non-Functional";
            }
            if(myController.addNewRequirement(Int32.Parse(this.requirementID),this.typeOfRequirement,descriptionTxtbox.Text)==true)
            {
                MessageBox.Show("Requirements have been stored");
            
            this.Close();
        }
        
        else{
            MessageBox.Show("That Requirement Already Exists. Please Try Again.");
        }
    }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
