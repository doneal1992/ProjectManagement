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
    public partial class FinalizeProject : Form
    {
       
        private DatabaseController myController;
        public FinalizeProject()
        {
            InitializeComponent();
            this.myController = new DatabaseController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.myController.getProjectNameByProjetID(Int32.Parse(this.projectManagerIDTextBox.Text)).Length > 0)
                {
                    string projectName = this.myController.getProjectNameByProjetID(Int32.Parse(this.projectManagerIDTextBox.Text));
                    DialogResult newResult = MessageBox.Show("Finalize " + projectName + "?, If yes, the project and its components will be removed, and no longer editable", "Finalize Project", MessageBoxButtons.YesNo);
                    if (newResult == DialogResult.Yes)
                    {
                        this.myController.finalizeProjectAndRemoveComponents(Int32.Parse(this.projectManagerIDTextBox.Text));
                        this.Close();                    
                    }
                }

                else
                {
                    MessageBox.Show("A project with that ID does not exist");
                }
            }
            catch (Exception number)
            {
                MessageBox.Show("You can only enter numbers");
            }
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
