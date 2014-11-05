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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            Form newProject = new NewProject();
            newProject.ShowDialog();
        }

        private void editProjectBtn_Click(object sender, EventArgs e)
        {
            Form editProject = new editProject();
            editProject.ShowDialog();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newProject = new NewProject();
            newProject.ShowDialog();
        }

        private void editProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editProject = new editProject();
            editProject.ShowDialog();
        }
    }
}
