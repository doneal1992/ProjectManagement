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
    public partial class editProject : Form
    {
        private DatabaseController myController;

        public editProject()
        {
            InitializeComponent();
            this.myController = new DatabaseController();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.managerIDTxtbox.Text.Length > 0)
                {
                    if (this.myController.getProjectNameByProjetID(Int32.Parse(this.managerIDTxtbox.Text)).Length > 0)
                    {
                        int managerID = Int32.Parse(this.managerIDTxtbox.Text);
                        Form projectEdit = new projectEdit(managerID);
                        projectEdit.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("A project with that ID does not exist");
                    }
                }
                else
                {
                    MessageBox.Show("You must enter a Manager ID before proceeding");
                }
            }
            catch (Exception number)
            {
                MessageBox.Show("You can only enter numbers");
            }
            
        }

      
    }
}
