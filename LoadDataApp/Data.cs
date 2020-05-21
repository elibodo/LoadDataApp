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
using System.Runtime.InteropServices;

namespace LoadDataApp
{
    public partial class Data : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Data()
        {
            // Sets the connection string
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eli\Desktop\Programming Capstone\LoadDataApp\LoadDataApp\LoadDataDatabase.accdb;Persist Security Info=False;";
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // Closes the entire application
            Close();
        }

        private void mnuMainMenu_Click(object sender, EventArgs e)
        {
            // Closes the viewing data form and opens the main menu
            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            // Opens the about form without closing the view data form
            About AboutForm = new About();
            AboutForm.ShowDialog();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            // Connects to the database and fills the combobox with items from the database
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Loads";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // The combobox will have the items as: Load Number: Caliber: Bullet Weight: Powder Type
                    // This will help the user identify the load that they want to look at or delete
                    cbCalibers.Items.Add(reader["Unique"].ToString() + ": " + reader["Caliber"].ToString() + ": " + reader["Bullet Weight"].ToString() + "gr: " + reader["Powder Type"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }

            // Disables the delete button
            // Delete button will enable when the user selects an item from the combobox
            btnDelete.Enabled = false;
        }

        private void cbCalibers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // From the text that is in the combobox it is split up to use just the unique number for each load to populate the labels
            char split = ':';
            string [] caliber = cbCalibers.Text.Split(split);
            label1.Text = caliber[0];

            // Connect to database to view information
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Loads where Unique=" + label1.Text + "";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LoadData(reader);
                }
                
                connection.Close();

                // Calls a method to make all of the labels visible
                MakeDataVisible();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }

            // If an item is selected in the combobox the delete button is enabled
            if (cbCalibers.SelectedIndex != -1) { btnDelete.Enabled = true; }
        }

        public void MakeDataVisible()
        {
            // Makes items visible 
            lblHeader2.Visible = true;
            lblHeader2Information.Visible = true;
            Caliber.Visible = true;
            BulletType.Visible = true;
            BulletWeight.Visible = true;
            PowderType.Visible = true;
            PowderWeight.Visible = true;
            PrimerType.Visible = true;
            CostOf1000.Visible = true;
            SavingsPer1000.Visible = true;
            Rifle.Visible = true;
            Scope.Visible = true;
            BarrelLength.Visible = true;
            TwistRate.Visible = true;
            Velocity.Visible = true;
            CaseLength.Visible = true;
            OverallLength.Visible = true;
            ZeroDistance.Visible = true;
            Elevation200.Visible = true;
            Windage200.Visible = true;
            Elevation300.Visible = true;
            Windage300.Visible = true;
            Elevation600.Visible = true;
            Windage600.Visible = true;
            Elevation1000.Visible = true;
            Windage1000.Visible = true;
        }

        public void MadeDataInvisible()
        {
            // Makes items not visible
            lblHeader2.Visible = false;
            lblHeader2Information.Visible = false;
            Caliber.Visible = false;
            BulletType.Visible = false;
            BulletWeight.Visible = false;
            PowderType.Visible = false;
            PowderWeight.Visible = false;
            PrimerType.Visible = false;
            CostOf1000.Visible = false;
            SavingsPer1000.Visible = false;
            Rifle.Visible = false;
            Scope.Visible = false;
            BarrelLength.Visible = false;
            TwistRate.Visible = false;
            Velocity.Visible = false;
            CaseLength.Visible = false;
            OverallLength.Visible = false;
            ZeroDistance.Visible = false;
            Elevation200.Visible = false;
            Windage200.Visible = false;
            Elevation300.Visible = false;
            Windage300.Visible = false;
            Elevation600.Visible = false;
            Windage600.Visible = false;
            Elevation1000.Visible = false;
            Windage1000.Visible = false;
        }

        public void LoadData(OleDbDataReader reader)
        {
            // Populates the labels from the database
            Caliber.Text = reader["Caliber"].ToString();
            lblHeader2Information.Visible = true;
            lblHeader2Information.Text = Caliber.Text;
            BulletType.Text = reader["Bullet Type"].ToString();
            BulletWeight.Text = reader["Bullet Weight"].ToString();
            PowderType.Text = reader["Powder Type"].ToString();
            PowderWeight.Text = reader["Powder Weight"].ToString();
            PrimerType.Text = reader["Primer Type"].ToString();

            // If the user did not input anything for the optional data the label reads "No Data"
            CostOf1000.Text = reader["Cost For 1000"].ToString();
            if (CostOf1000.Text == "") { CostOf1000.Text = "No Data"; }
            SavingsPer1000.Text = reader["Savings For 1000"].ToString();
            if (SavingsPer1000.Text == "") { SavingsPer1000.Text = "No Data"; }
            Rifle.Text = reader["Rifle"].ToString();
            if (Rifle.Text == "") { Rifle.Text = "No Data"; }
            Scope.Text = reader["Scope"].ToString();
            if (Scope.Text == "") { Scope.Text = "No Data"; }
            BarrelLength.Text = reader["Barrel Length"].ToString();
            if (BarrelLength.Text == "") { BarrelLength.Text = "No Data"; }
            TwistRate.Text = reader["Twist Rate"].ToString();
            if (TwistRate.Text == "") { TwistRate.Text = "No Data"; }
            Velocity.Text = reader["Velocity"].ToString();
            if (Velocity.Text == "") { Velocity.Text = "No Data"; }
            CaseLength.Text = reader["Case Length"].ToString();
            if (CaseLength.Text == "") { CaseLength.Text = "No Data"; }
            OverallLength.Text = reader["Overall Length"].ToString();
            if (OverallLength.Text == "") { OverallLength.Text = "No Data"; }
            ZeroDistance.Text = reader["Zero Distance"].ToString();
            if (ZeroDistance.Text == "") { ZeroDistance.Text = "No Data"; }

            // Gets the information from the database and calls a method to change the string
            string E200 = reader["Elevation200"].ToString();
            if (E200 != "") { Elevation200.Text = Elevation(E200); }
            else { Elevation200.Text = "No Data"; }
            string W200 = reader["Windage200"].ToString();
            if (W200 != "") { Windage200.Text = Windage(W200); }
            else { Windage200.Text = "No Data"; }

            string E300 = reader["Elevation300"].ToString();
            if (E300 != "") { Elevation300.Text = Elevation(E300); }
            else { Elevation300.Text = "No Data"; }
            string W300 = reader["Windage300"].ToString();
            if (W300 != "") { Windage300.Text = Windage(W300); }
            else { Windage300.Text = "No Data"; }

            string E600 = reader["Elevation600"].ToString();
            if (E600 != "") { Elevation600.Text = Elevation(E600); }
            else { Elevation600.Text = "No Data"; }
            string W600 = reader["Windage600"].ToString();
            if (W600 != "") { Windage600.Text = Windage(W600); }
            else { Windage600.Text = "No Data"; }

            string E1000 = reader["Elevation1000"].ToString();
            if (E1000 != "") { Elevation1000.Text = Elevation(E1000); }
            else { Elevation1000.Text = "No Data"; }
            string W1000 = reader["Windage1000"].ToString();
            if (W1000 != "") { Windage1000.Text = Windage(W1000); }
            else { Windage1000.Text = "No Data"; }
        }

        public string Elevation(string elevation)
        {
            // Up/Down gets added to the string depending if the user entered a positive or negative value
            double adjustment = Convert.ToDouble(elevation);
            string Up = "Up: ";
            string Down = "Down: ";
            if (adjustment > 0)
            {
                elevation = Up + elevation;
                return elevation;
            }
            else if(adjustment < 0)
            {
                elevation = Down + elevation;
                return elevation;
            }
            else { return elevation = "No Adjustment"; }
        }

        public string Windage(string windage)
        {
            // Right/Left gets added to the string depending if the user entered a positive or negative value
            double adjustment = Convert.ToDouble(windage);
            string Right = "Right: ";
            string Left = "Left: ";
            if (adjustment > 0)
            {
                windage = Right + windage;
                return windage;
            }
            else if (adjustment < 0)
            {
                windage = Left + windage;
                return windage;
            }
            else { return windage = "No Adjustment"; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Deletes the load that the user selected from the combobox based on the unique number assigned for each load
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Loads where Unique=" + label1.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();

                RefreshTable();
                connection.Close();
                btnDelete.Enabled = false;
                MadeDataInvisible();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        public void RefreshTable()
        {
            // Reloads the table with the new values after one was deleted
            cbCalibers.Items.Clear();
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Loads";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbCalibers.Items.Add(reader["Unique"].ToString() + ": " + reader["Caliber"].ToString() + ": " + reader["Bullet Weight"].ToString() + "gr: " + reader["Powder Type"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }
    }
}
