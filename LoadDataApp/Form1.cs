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
using LoadDataApp.LoadDataDatabaseDataSetTableAdapters;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;

namespace LoadDataApp
{
    public partial class Form1 : Form
    {
        // Sets the database connection 
        private OleDbConnection connection = new OleDbConnection();

        // This string is used various times throughout the program when the user enters invalid information
        public string message = "Invalid Entry In Highlighted Section(s)";

        // Index is used to count the items that the user has entered within the database
        int index;

        public Form1()
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
            // Closes the add data form and goes to the main menu
            MainMenu MainMenuForm = new MainMenu();
            this.Hide();
            MainMenuForm.ShowDialog();
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            // Opens the about form without closing the add data form
            About AboutForm = new About();
            AboutForm.ShowDialog();
        }

        private void mnuAddDeleteCaliber_Click(object sender, EventArgs e)
        {
            // Opens the caliber form and closes the add data form
            Caliber CaliberForm = new Caliber();
            this.Hide();
            CaliberForm.ShowDialog();
            this.Close();
        }

        private void mnuAddDeletePrimer_Click(object sender, EventArgs e)
        {
            // Opens the primer form and closes the add data form
            PrimerType PrimerForm = new PrimerType();
            this.Hide();
            PrimerForm.ShowDialog();
            this.Close();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Fills the Caliber combobox with information from the database
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
                    cbCaliber.Items.Add(reader["Caliber"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            // Fills the Primer Type combobox with information from the database
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Primers";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbPrimerType.Items.Add(reader["PrimerType"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            // The index is a number that is different for each saved load
            // I have it set to a label that is not visible in the form
            // This is used for identifying different loads if some information is the same between loads
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
                    label1.Text = reader["Unique"].ToString();
                }
                index = Convert.ToInt32(label1.Text);
                index++;
                label1.Text = index.ToString();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            // Disables groupboxes at the startup of this page
            // These will be enabled by selecting radiobuttons and checkboxes
            gbStoreBoughtAmmo.Enabled = false;
            gbBullet.Enabled = false;
            gbPowder.Enabled = false;
            gbPrimer.Enabled = false;
            gbRifleInformation.Enabled = false;
            gbOutput.Enabled = false;
            cbRifleInformation.Enabled = false;
        }

        private void cbPrice_CheckedChanged(object sender, EventArgs e)
        {
            // Enables group boxes related to price if it is checked
            // Disables group boxes related to price if it is not checked and sets the backcolor to the default value
            if (cbPrice.Checked == true)
            {
                gbStoreBoughtAmmo.Enabled = true;
                gbBullet.Enabled = true;
                gbPowder.Enabled = true;
                gbPrimer.Enabled = true;
            }
            else
            {
                gbStoreBoughtAmmo.Enabled = false;
                gbBullet.Enabled = false;
                gbPowder.Enabled = false;
                gbPrimer.Enabled = false;

                tbStoreBoughtQuantity.Text = "";
                tbStoreBoughtQuantity.BackColor = default;
                tbStoreBoughtPrice.Text = "";
                tbStoreBoughtPrice.BackColor = default;
                tbBulletQuantity.Text = "";
                tbBulletQuantity.BackColor = default;
                tbBulletPrice.Text = "";
                tbBulletPrice.BackColor = default;
                tbPowderQuantity.Text = "";
                tbPowderQuantity.BackColor = default;
                tbPowderPrice.Text = "";
                tbPowderPrice.BackColor = default;
                tbPrimerQuanity.Text = "";
                tbPrimerQuanity.BackColor = default;
                tbPrimerPrice.Text = "";
                tbPrimerPrice.BackColor = default;
            }
        }

        private void cbRifleInformation_CheckedChanged(object sender, EventArgs e)
        {
            // Enables rifle information group box if it is checked
            // Disables rifle information group box if it is not checked and sets the backcolor to the default value
            if (cbRifleInformation.Checked == true)
            {
                gbRifleInformation.Enabled = true;
            }
            else
            {
                gbRifleInformation.Enabled = false;
                tbRifle.Text = "";
                tbRifle.BackColor = default;
                tbScope.Text = "";
                tbScope.BackColor = default;
                tbTwistRate.Text = "";
                tbTwistRate.BackColor = default;
                tbBarrelLength.Text = "";
                tbBarrelLength.BackColor = default;
                tbCaseLength.Text = "";
                tbCaseLength.BackColor = default;
                tbOverallLength.Text = "";
                tbOverallLength.BackColor = default;
                tbZeroDistance.Text = "";
                tbZeroDistance.BackColor = default;
                tbVelocity.Text = "";
                tbVelocity.BackColor = default;
                tb200UpDown.Text = "";
                tb200UpDown.BackColor = default;
                tb200LeftRight.Text = "";
                tb200LeftRight.BackColor = default;
                tb300UpDown.Text = "";
                tb300UpDown.BackColor = default;
                tb300LeftRight.Text = "";
                tb300LeftRight.BackColor = default;
                tb600UpDown.Text = "";
                tb600UpDown.BackColor = default;
                tb600LeftRight.Text = "";
                tb600LeftRight.BackColor = default;
                tb1000UpDown.Text = "";
                tb1000UpDown.BackColor = default;
                tb1000LeftRight.Text = "";
                tb1000LeftRight.BackColor = default;
            }
        }

        private void rbRifle_CheckedChanged(object sender, EventArgs e)
        {
            // Enables check box for rifle information if it is checked
            // Disables rifle information check box if it is not checked
            if (rbRifle.Checked == true) { cbRifleInformation.Enabled = true; }
            else { cbRifleInformation.Enabled = false; }
        }

        private void rbHandgun_CheckedChanged(object sender, EventArgs e)
        {
            // Disables rifle information check box if handgun radio button is selected
            if (rbHandgun.Checked == true) { cbRifleInformation.Checked = false; }
        }

        private void btnAddLoad_Click(object sender, EventArgs e)
        {
            // bool expressions related to if the information passes to this method is valid
            bool confirmdata;
            bool confirmprices;
            bool confirmrifle;

            // Checks the basic information needed for each load that is added to the database
            confirmdata = CheckItems();
            if (confirmdata == true)
            {
                // If the user is using price and rifle info options
                if (cbRifleInformation.Checked == true && cbPrice.Checked == true)
                {
                    confirmrifle = CheckRifleInformation();
                    confirmprices = CheckPricesQuantity();
                    if (confirmrifle == true && confirmprices == true)
                    {
                        CalculatePrices();
                        SaveData();
                    }
                    else { MessageBox.Show(message); }
                }
                // If the user is using rifle info but not price
                else if (cbRifleInformation.Checked == true && cbPrice.Checked == false)
                {
                    confirmrifle = CheckRifleInformation();
                    if (confirmrifle == true)
                    {
                        SaveData();
                    }
                    else { MessageBox.Show(message); }
                }
                // If the user is using prices but not rifle info
                else if (cbRifleInformation.Checked == false && cbPrice.Checked == true)
                {
                    confirmprices = CheckPricesQuantity();
                    if (confirmprices == true)
                    {
                        CalculatePrices();
                        SaveData();
                    }
                    else { MessageBox.Show(message); }
                }
                // If the user is just saving the basic data needed for each load saved
                else { SaveData(); }
            }
            else { MessageBox.Show(message); }
        }

        public void CalculatePrices()
        {
            // Calculates information needed for the output
            // Sets the output text visible and set to a variable
            gbOutput.Enabled = true;
            int Qstore = Convert.ToInt32(tbStoreBoughtQuantity.Text);
            double Pstore = Convert.ToDouble(tbStoreBoughtPrice.Text);
            int Qbullet = Convert.ToInt32(tbBulletQuantity.Text);
            double Pbullet = Convert.ToDouble(tbBulletPrice.Text);
            int Qpowder = Convert.ToInt32(tbPowderQuantity.Text);
            double Ppowder = Convert.ToDouble(tbPowderPrice.Text);
            int Qprimer = Convert.ToInt32(tbPrimerQuanity.Text);
            double Pprimer = Convert.ToDouble(tbPrimerPrice.Text);
            double powdercharge = Convert.ToDouble(tbPowderWeight.Text);

            int grainsPerPound = 7000;
            double bullet = (Pbullet / Qbullet);
            double powder = (Ppowder / Qpowder);
            double primer = (Pprimer / Qprimer);
            double graincost = (powder / grainsPerPound);


            double loadunit = (bullet + (graincost * powdercharge) + primer);
            double load1000 = (loadunit * 1000);
            double storeunit = (Pstore / Qstore);
            double savedunit = (storeunit - loadunit);
            double saved1000 = (savedunit * 1000);

            lblLoadUnitCost.Visible = true;
            lblLoadUnitCost.Text = (loadunit.ToString("c"));
            lblLoad100Cost.Visible = true;
            lblLoad100Cost.Text = ((loadunit * 100).ToString("c"));
            lblLoad1000Cost.Visible = true;
            lblLoad1000Cost.Text = (load1000.ToString("c"));

            lblStoreUnitCost.Visible = true;
            lblStoreUnitCost.Text = (storeunit.ToString("c"));
            lblStore100Cost.Visible = true;
            lblStore100Cost.Text = ((storeunit * 100).ToString("c"));
            lblStore1000Cost.Visible = true;
            lblStore1000Cost.Text = ((storeunit * 1000).ToString("c"));

            lblSavedUnitMoney.Visible = true;
            lblSavedUnitMoney.Text = (savedunit.ToString("c"));
            lblSaved100Money.Visible = true;
            lblSaved100Money.Text = ((savedunit * 100).ToString("c"));
            lblSaved1000Money.Visible = true;
            lblSaved1000Money.Text = (saved1000.ToString("c"));
        }

        private void SaveData()
        {
            // Saves data to the database
            // There is 4 different ways that the data will be added depending on the options that the user selected
            if (cbPrice.Checked == true && cbRifleInformation.Checked == true)
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into Loads ([Unique],[Caliber],[Bullet Type],[Bullet Weight],[Powder Type],[Powder Weight],[Primer Type]," +
                        "[Cost For 1000],[Savings For 1000],[Rifle],[Scope],[Twist Rate],[Barrel Length],[Case Length],[Overall Length]," +
                        "[Zero Distance],[Velocity],[Elevation200],[Windage200],[Elevation300],[Windage300],[Elevation600],[Windage600]," +
                        "[Elevation1000],[Windage1000])values(" + index + ",'" + cbCaliber.Text +
                        "','" + tbBulletType.Text + "','" + tbBulletWeight.Text + "','" + tbPowderType.Text + "','" + tbPowderWeight.Text + "','"
                        + cbPrimerType.Text + "','" + lblLoad1000Cost.Text + "','" + lblSaved1000Money.Text + "','" + tbRifle.Text + "','"
                        + tbScope.Text + "','" + tbTwistRate.Text + "','" + tbBarrelLength.Text + "','" + tbCaseLength.Text + "','"
                        + tbOverallLength.Text + "','" + tbZeroDistance.Text + "','" + tbVelocity.Text + "','" + tb200UpDown.Text + "','"
                        + tb200LeftRight.Text + "','" + tb300UpDown.Text + "','" + tb300LeftRight.Text + "','" + tb600UpDown.Text + "','"
                        + tb600LeftRight.Text + "','" + tb1000UpDown.Text + "','" + tb1000LeftRight.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("errpr" + ex);
                }
            }
            else if (cbPrice.Checked == true && cbRifleInformation.Checked == false)
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into Loads ([Unique],[Caliber],[Bullet Type],[Bullet Weight],[Powder Type],[Powder Weight],[Primer Type]," +
                        "[Cost For 1000],[Savings For 1000])values(" + index + ",'" + cbCaliber.Text + "','" + tbBulletType.Text + "','" + tbBulletWeight.Text +
                        "','" + tbPowderType.Text + "','" + tbPowderWeight.Text + "','" + cbPrimerType.Text + "','" + lblLoad1000Cost.Text + "','"
                        + lblSaved1000Money.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            else if (cbPrice.Checked == false && cbRifleInformation.Checked == true)
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into Loads ([Unique],[Caliber],[Bullet Type],[Bullet Weight],[Powder Type],[Powder Weight],[Primer Type]," +
                        "[Rifle],[Scope],[Twist Rate],[Barrel Length],[Case Length],[Overall Length],[Zero Distance],[Velocity],[Elevation200],[Windage200],[Elevation300],[Windage300],[Elevation600],[Windage600]," +
                        "[Elevation1000],[Windage1000])values(" + index + ",'" + cbCaliber.Text + "','" + tbBulletType.Text + "','"
                        + tbBulletWeight.Text + "','" + tbPowderType.Text + "','" + tbPowderWeight.Text + "','" + cbPrimerType.Text + "','"
                        + tbRifle.Text + "','" + tbScope.Text + "','" + tbTwistRate.Text + "','" + tbBarrelLength.Text + "','"
                        + tbCaseLength.Text + "','" + tbOverallLength.Text + "','" + tbZeroDistance.Text + "','" + tbVelocity.Text + "','"
                        + tb200UpDown.Text + "','" + tb200LeftRight.Text + "','" + tb300UpDown.Text + "','" + tb300LeftRight.Text + "','"
                        + tb600UpDown.Text + "','" + tb600LeftRight.Text + "','" + tb1000UpDown.Text + "','" + tb1000LeftRight.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into Loads ([Unique],[Caliber],[Bullet Type],[Bullet Weight],[Powder Type],[Powder Weight],[Primer Type])" +
                        "values(" + index + ",'" + cbCaliber.Text + "','" + tbBulletType.Text + "','" + tbBulletWeight.Text + "','" + tbPowderType.Text +
                        "','" + tbPowderWeight.Text + "','" + cbPrimerType.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }

            // Shows the confirmation label
            // Shows a confirmation messagebox
            lblConfirmation.Visible = true;
            MessageBox.Show("Load Added to Database!");

            // Adds 1 to the index so the user can add multiple loads without reloading this form
            index++;

            // Clears all textboxes and output information
            ClearTextboxes();
        }

        public void ClearTextboxes()
        {
            // Sets all of the textboxes, comboboxes, labels to nothing so the user can input another load
            cbCaliber.SelectedIndex = -1;
            tbBulletType.Text = "";
            tbBulletWeight.Text = "";
            tbPowderType.Text = "";
            tbPowderWeight.Text = "";
            cbPrimerType.SelectedIndex = -1;

            tbStoreBoughtQuantity.Text = "";
            tbStoreBoughtPrice.Text = "";
            tbBulletQuantity.Text = "";
            tbBulletPrice.Text = "";
            tbPowderQuantity.Text = "";
            tbPowderPrice.Text = "";
            tbPrimerQuanity.Text = "";
            tbPrimerPrice.Text = "";

            gbOutput.Enabled = false;
            lblLoadUnitCost.Text = "";
            lblLoad100Cost.Text = "";
            lblLoad1000Cost.Text = "";
            lblStoreUnitCost.Text = "";
            lblStore100Cost.Text = "";
            lblStore1000Cost.Text = "";
            lblSavedUnitMoney.Text = "";
            lblSaved100Money.Text = "";
            lblSaved1000Money.Text = "";

            tbRifle.Text = "";
            tbScope.Text = "";
            tbTwistRate.Text = "";
            tbBarrelLength.Text = "";
            tbCaseLength.Text = "";
            tbOverallLength.Text = "";
            tbZeroDistance.Text = "";
            tbVelocity.Text = "";

            tb200UpDown.Text = "";
            tb200LeftRight.Text = "";
            tb300UpDown.Text = "";
            tb300LeftRight.Text = "";
            tb600UpDown.Text = "";
            tb600LeftRight.Text = "";
            tb1000UpDown.Text = "";
            tb1000LeftRight.Text = "";
        }

        private Boolean CheckRifleInformation()
        {
            // Checks rifle information
            // Feilds to not have to have information but if there is information inputted it needs to be correct
            string data;
            int itemsInputted = 0;
            int counter = 0;
            // RIFLE
            if (tbRifle.Text != "")
            {
                counter++;
                data = tbRifle.Text;
                if (StringCheck(data) == true)
                {
                    tbRifle.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tbRifle.BackColor = Color.LightPink;
                    tbRifle.Text = "";
                    itemsInputted--;
                }
            }
            else { tbRifle.BackColor = default; }

            // SCOPE
            if (tbScope.Text != "")
            {
                counter++;
                data = tbScope.Text;
                if (StringCheck(data) == true)
                {
                    tbScope.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tbScope.BackColor = Color.LightPink;
                    tbScope.Text = "";
                    itemsInputted--;
                }
            }
            else { tbScope.BackColor = default; }

            // TWIST RATE
            if (tbTwistRate.Text != "")
            {
                counter++;
                data = tbTwistRate.Text;
                if (StringCheck(data) == true)
                {
                    tbTwistRate.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tbTwistRate.BackColor = Color.LightPink;
                    tbTwistRate.Text = "";
                    itemsInputted--;
                }
            }
            else { tbTwistRate.BackColor = default; }

            // BARREL LENGTH
            if (tbBarrelLength.Text != "")
            {
                counter++;
                data = tbBarrelLength.Text;
                if (DoubleNumberCheck(data) == true)
                {
                    tbBarrelLength.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tbBarrelLength.BackColor = Color.LightPink;
                    tbBarrelLength.Text = "";
                    itemsInputted--;
                }
            }
            else { tbBarrelLength.BackColor = default; }

            // CASE LENGTH
            if (tbCaseLength.Text != "")
            {
                counter++;
                data = tbCaseLength.Text;
                if (DoubleNumberCheck(data) == true)
                {
                    tbCaseLength.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tbCaseLength.BackColor = Color.LightPink;
                    tbCaseLength.Text = "";
                    itemsInputted--;
                }
            }
            else { tbCaseLength.BackColor = default; }

            // OVERALL LENGTH
            if (tbOverallLength.Text != "")
            {
                counter++;
                data = tbOverallLength.Text;
                if (DoubleNumberCheck(data) == true)
                {
                    tbOverallLength.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tbOverallLength.BackColor = Color.LightPink;
                    tbOverallLength.Text = "";
                    itemsInputted--;
                }
            }
            else { tbOverallLength.BackColor = default; }

            // ZERO DISTANCE 
            if (tbZeroDistance.Text != "")
            {
                counter++;
                data = tbZeroDistance.Text;
                if (DoubleNumberCheck(data) == true)
                {
                    tbZeroDistance.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tbZeroDistance.BackColor = Color.LightPink;
                    tbZeroDistance.Text = "";
                    itemsInputted--;
                }
            }
            else { tbZeroDistance.BackColor = default; }

            // VELOCITY
            if (tbVelocity.Text != "")
            {
                counter++;
                data = tbVelocity.Text;
                if (IntNumberCheck(data) == true)
                {
                    tbVelocity.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tbVelocity.BackColor = Color.LightPink;
                    tbVelocity.Text = "";
                    itemsInputted--;
                }
            }
            else { tbVelocity.BackColor = default; }

            // ADJUSTMENT 200
            if (tb200UpDown.Text != "")
            {
                counter++;
                data = tb200UpDown.Text;
                if (CheckPositiveNegative(data) == true)
                {
                    tb200UpDown.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tb200UpDown.BackColor = Color.LightPink;
                    tb200UpDown.Text = "";
                    itemsInputted--;
                }
            }
            else { tb200UpDown.BackColor = default; }
            if (tb200LeftRight.Text != "")
            {
                counter++;
                data = tb200LeftRight.Text;
                if (CheckPositiveNegative(data) == true)
                {
                    tb200LeftRight.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tb200LeftRight.BackColor = Color.LightPink;
                    tb200LeftRight.Text = "";
                    itemsInputted--;
                }
            }
            else { tb200LeftRight.BackColor = default; }

            // ADJUSTMENT 300
            if (tb300UpDown.Text != "")
            {
                counter++;
                data = tb300UpDown.Text;
                if (CheckPositiveNegative(data) == true)
                {
                    tb300UpDown.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tb300UpDown.BackColor = Color.LightPink;
                    tb300UpDown.Text = "";
                    itemsInputted--;
                }
            }
            else { tb300UpDown.BackColor = default; }
            if (tb300LeftRight.Text != "")
            {
                counter++;
                data = tb300LeftRight.Text;
                if (CheckPositiveNegative(data) == true)
                {
                    tb300LeftRight.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tb300LeftRight.BackColor = Color.LightPink;
                    tb300LeftRight.Text = "";
                    itemsInputted--;
                }
            }
            else { tb300LeftRight.BackColor = default; }

            // ADJUSTMENT 600
            if (tb600UpDown.Text != "")
            {
                counter++;
                data = tb600UpDown.Text;
                if (CheckPositiveNegative(data) == true)
                {
                    tb600UpDown.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tb600UpDown.BackColor = Color.LightPink;
                    tb600UpDown.Text = "";
                    itemsInputted--;
                }
            }
            else { tb600UpDown.BackColor = default; }
            if (tb600LeftRight.Text != "")
            {
                counter++;
                data = tb600LeftRight.Text;
                if (CheckPositiveNegative(data) == true)
                {
                    tb600LeftRight.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tb600LeftRight.BackColor = Color.LightPink;
                    tb600LeftRight.Text = "";
                    itemsInputted--;
                }
            }
            else { tb600LeftRight.BackColor = default; }

            // ADJUSTMENT 1000
            if (tb1000UpDown.Text != "")
            {
                counter++;
                data = tb1000UpDown.Text;
                if (CheckPositiveNegative(data) == true)
                {
                    tb1000UpDown.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tb1000UpDown.BackColor = Color.LightPink;
                    tb1000UpDown.Text = "";
                    itemsInputted--;
                }
            }
            else { tb1000UpDown.BackColor = default; }
            if (tb1000LeftRight.Text != "")
            {
                counter++;
                data = tb1000LeftRight.Text;
                if (CheckPositiveNegative(data) == true)
                {
                    tb1000LeftRight.BackColor = default;
                    itemsInputted++;
                }
                else
                {
                    tb1000LeftRight.BackColor = Color.LightPink;
                    tb1000LeftRight.Text = "";
                    itemsInputted--;
                }
            }
            else { tb1000LeftRight.BackColor = default; }

            // RETURNS TRUE/FALSE if the counter is equal to the items that were inputted
            // Not all items need to be inputted but if there is they need to be correct (Numbers have to be ints or doubles ect.)
            if (itemsInputted == counter) { return true; }
            else { return false; }
        }

        private Boolean CheckPricesQuantity()
        {
            // Checks the information that the user inputted for prices
            // All information needs to be inputted and correct if the user decides to use this option
            int counter = 0;
            string data;

            // STORE BOUGHT
            data = tbStoreBoughtQuantity.Text;
            if(IntNumberCheck(data) == true)
            {
                tbStoreBoughtQuantity.BackColor = default;
                counter++;
            }
            else
            {
                tbStoreBoughtQuantity.BackColor = Color.LightPink;
                tbStoreBoughtQuantity.Text = "";
            }

            data = tbStoreBoughtPrice.Text;
            if (DoubleNumberCheck(data) == true)
            {
                tbStoreBoughtPrice.BackColor = default;
                counter++;
            }
            else
            {
                tbStoreBoughtPrice.BackColor = Color.LightPink;
                tbStoreBoughtPrice.Text = "";
            }

            // BULLET COST
            data = tbBulletQuantity.Text;
            if (IntNumberCheck(data) == true)
            {
                tbBulletQuantity.BackColor = default;
                counter++;
            }
            else
            {
                tbBulletQuantity.BackColor = Color.LightPink;
                tbBulletQuantity.Text = "";
            }

            data = tbBulletPrice.Text;
            if (DoubleNumberCheck(data) == true)
            {
                tbBulletPrice.BackColor = default;
                counter++;
            }
            else
            {
                tbBulletPrice.BackColor = Color.LightPink;
                tbBulletPrice.Text = "";
            }

            // POWDER COST
            data = tbPowderQuantity.Text;
            if (IntNumberCheck(data) == true)
            {
                tbPowderQuantity.BackColor = default;
                counter++;
            }
            else
            {
                tbPowderQuantity.BackColor = Color.LightPink;
                tbPowderQuantity.Text = "";
            }

            data = tbPowderPrice.Text;
            if (DoubleNumberCheck(data) == true)
            {
                tbPowderPrice.BackColor = default;
                counter++;
            }
            else
            {
                tbPowderPrice.BackColor = Color.LightPink;
                tbPowderPrice.Text = "";
            }


            // PRIMER COST
            data = tbPrimerQuanity.Text;
            if (IntNumberCheck(data) == true)
            {
                tbPrimerQuanity.BackColor = default;
                counter++;
            }
            else
            {
                tbPrimerQuanity.BackColor = Color.LightPink;
                tbPrimerQuanity.Text = "";
            }

            data = tbPrimerPrice.Text;
            if (DoubleNumberCheck(data) == true)
            {
                tbPrimerPrice.BackColor = default;
                counter++;
            }
            else
            {
                tbPrimerPrice.BackColor = Color.LightPink;
                tbPrimerPrice.Text = "";
            }

            // RETURNS TRUE/FALSE
            if (counter == 8) { return true; }
            else { return false; }
        }

        private Boolean IntNumberCheck(string item)
        {
            // Checks if an item is a integer
            // Returns false if the item is not an int or not positive
            int number;
            try
            {
                number = Convert.ToInt32(item);
                if (number > 0) { return true; }
                else { return false; }
            }
            catch (Exception) { return false; }
        }

        private Boolean CheckItems()
        {
            // Checks the basic information needed for each load that is inputted into the database
            int counter = 0;
            string data;

            // CALIBER
            data = cbCaliber.Text;
            if (ConfirmCheckbox(data) == true)
            {
                cbCaliber.BackColor = default;
                counter++;
            }
            else { cbCaliber.BackColor = Color.LightPink; }

            // PRIMER TYPE
            data = cbPrimerType.Text;
            if (ConfirmCheckbox(data) == true)
            {
                cbPrimerType.BackColor = default;
                counter++;
            }
            else { cbPrimerType.BackColor = Color.LightPink; }

            // BULLET TYPE
            data = tbBulletType.Text;
            if (StringCheck(data) == true)
            {
                tbBulletType.BackColor = default;
                counter++;
            }
            else { tbBulletType.BackColor = Color.LightPink; }

            // POWDER TYPE
            data = tbPowderType.Text;
            if (StringCheck(data) == true)
            {
                tbPowderType.BackColor = default;
                counter++;
            }
            else { tbPowderType.BackColor = Color.LightPink; }

            // BULLET WEIGHT
            data = tbBulletWeight.Text;
            if(DoubleNumberCheck(data) == true)
            {
                tbBulletWeight.BackColor = default;
                counter++;
            }
            else
            {
                tbBulletWeight.BackColor = Color.LightPink;
                tbBulletWeight.Text = "";
            }

            // POWDER WEIGHT
            data = tbPowderWeight.Text;
            if (DoubleNumberCheck(data) == true)
            {
                tbPowderWeight.BackColor = default;
                counter++;
            }
            else
            {
                tbPowderWeight.BackColor = Color.LightPink;
                tbPowderWeight.Text = "";
            }

            // RETURNS TRUE/FALSE
            // Based on if the counter has been incrememted to the point where all values are true
            if (counter == 6) { return true; }
            else { return false; }
        }

        private Boolean DoubleNumberCheck(string item)
        {
            // Checks if the item is a double
            // Returns false if the item is not a double or not positive
            double number;
            try
            {
                number = Convert.ToDouble(item);
                if (number > 0) { return true; }
                else { return false; }
            }
            catch (Exception) { return false; }
        }

        private Boolean StringCheck(string item)
        {
            // Checks if the item is a string
            // Returns false if there is noting passes
            if (item != "") { return true; }
            else { return false; }
        }

        private Boolean ConfirmCheckbox(string item)
        {
            // Checks that there is an item selected within a checkbox
            // Returns false if there is not an item selected
            if (item != "") { return true; }
            else { return false; }
        }

        private Boolean CheckPositiveNegative(string item)
        {
            // Checks if the number is either positive or negative
            // Returns false if it is not a double
            double number;
            try { number = Convert.ToDouble(item); }
            catch (Exception) { return false; }
            return true;
        }

        private void cbCaliber_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will make the confirmation label not visible if the user starts to input another load after they inputted one
            if (cbCaliber.SelectedIndex != -1) { lblConfirmation.Visible = false; }
            
        }
    }
}
