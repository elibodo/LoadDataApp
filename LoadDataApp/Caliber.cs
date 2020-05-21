using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoadDataApp
{
    public partial class Caliber : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Caliber()
        {
            // Sets the connection string for the database
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eli\Desktop\Programming Capstone\LoadDataApp\LoadDataApp\LoadDataDatabase.accdb;Persist Security Info=False;";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the add/delete caliber type form and opens the Form1(Add form)
            Form1 AddForm = new Form1();
            this.Hide();
            AddForm.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Opens a connection and allows the user to add the item they typed in the textbox
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                if (cbCalibers.Items.Contains(cbCalibers.Text))
                {
                    MessageBox.Show("Item Already In Database");
                }
                else
                {
                    string query = "insert into Calibers([Caliber])values('" + tbAddCaliber.Text + "')";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    RefreshTable();
                    connection.Close();
                    tbAddCaliber.Clear();
                }
                connection.Close();
                tbAddCaliber.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Opens a connection and allows the user to select an item to be deleted from the database
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Calibers where Caliber='" + cbCalibers.Text + "' ;";
                command.CommandText = query;
                command.ExecuteNonQuery();

                RefreshTable();
                connection.Close();
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        public void RefreshTable()
        {
            // Clears and refreshes the combobox
            cbCalibers.Items.Clear();
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Calibers";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbCalibers.Items.Add(reader["Caliber"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void tbAddCaliber_TextChanged(object sender, EventArgs e)
        {
            // Enables and disables the add button depending if there is text in the textbox
            if (tbAddCaliber.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else { btnAdd.Enabled = false; }
        }

        private void Caliber_Load(object sender, EventArgs e)
        {
            // Disables the add and delete button at the start of this form
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;

            // Opens a connection and fills the combobox with the items from the database
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Calibers";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbCalibers.Items.Add(reader["Caliber"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void cbCalibers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enables the delete button if there is an item selected
            btnDelete.Enabled = true;
        }
    }
}
