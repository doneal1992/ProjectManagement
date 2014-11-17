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
    public partial class addManager : Form
    {
        DatabaseController myController = new DatabaseController();
        public addManager()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (fNameTxtBox.Text.Length > 0 && lnamelbl.Text.Length > 0 && idLbl.Text.Length > 0)
            {
                int idNumber = Int32.Parse(idNumberTxtBox.Text);
                if (myController.addNewManager(fNameTxtBox.Text, lNameTextBox.Text, idNumber) == true)
                {
                    MessageBox.Show(fNameTxtBox.Text + " has been added");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(fNameTxtBox.Text + " already exists");
                }
            }
            else{
                MessageBox.Show("You must enter all information");
                    this.Close();
            }
                
        }
    }
}
