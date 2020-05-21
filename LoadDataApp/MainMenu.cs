using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadDataApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the application
            Close();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            // Opens the form to add data
            Form1 AddData = new Form1();
            this.Hide();
            AddData.ShowDialog();
            this.Close();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            // Opens the form to view data
            Data ViewData = new Data();
            this.Hide();
            ViewData.ShowDialog();
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Opens the about form
            About AboutForm = new About();
            AboutForm.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // CLoses the application
            Close();
        }
    }
}
