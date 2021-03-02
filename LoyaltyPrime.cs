using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LoyaltyPrime
{
    public partial class LoyaltyPrime : Form
    {

        //Create a new connection with the local db called "LOYALTY_PRIME"
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = LOYALTY_PRIME; Integrated Security = True");

        public LoyaltyPrime()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayUsers();
            DisplayAccounts();
        }

        private void newUser_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.FormClosed += new FormClosedEventHandler(newUser_FormClosed);

            newUser.ShowDialog();

        }

        //Display any data that might have already been in the database
        private void DisplayUsers()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Users", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                for (int i = 0; i < item.ItemArray.Length; i++)
                {
                   dataGridView1.Rows[n].Cells[i].Value = item[i].ToString();
                }

            }
        }
        //Update the view for when a new user gets added via the second form
        void newUser_FormClosed(object sender, FormClosedEventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Users", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                for (int i = 0; i < item.ItemArray.Length; i++)
                {
                    dataGridView1.Rows[n].Cells[i].Value = item[i].ToString();
                }
            }
        }

        //create a new account for an existing User
        private void newAccount_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.FormClosed += new FormClosedEventHandler(newAccount_FormClosed);

            newAccount.ShowDialog();
        }

        //load the information stored in the database for viewing
        private void DisplayAccounts()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Accounts", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();


                for (int i = 0; i < item.ItemArray.Length; i++)
                {
                    dataGridView2.Rows[n].Cells[i].Value = item[i].ToString();
                }
            }
        }

        //refresh the data after a new entry has been made
        void newAccount_FormClosed(object sender, FormClosedEventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Accounts", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();

                for (int i = 0; i < item.ItemArray.Length; i++)
                {
                    dataGridView2.Rows[n].Cells[i].Value = item[i].ToString();
                }
            }
        }

        //delete an existing user
        private void deleteUser_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                SqlCommand sqlCom = new SqlCommand("DELETE FROM dbo.Users WHERE UserID =  + '" + userIDTextBox.Text + "'", con);

                sqlCom.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show("User with one or more accounts can't be deleted!");

                StringBuilder errorMessages = new StringBuilder();

                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

            clearTextBox();

            DisplayUsers();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userIDTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            firstNameTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            lastNameTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            addressTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AccountIDTextBox.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            userIDTextAccount.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            accountNameTextBox.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            availablePointsTextBox.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            pointsUsedTextBox.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            accountStatusTextBox.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
        }


        //clear textboxes as needeed.
        private void clearTextBox()
        {
            //clear user text boxes
            userIDTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            addressTextBox.Clear();

            //clear account text boxes
            userIDTextAccount.Clear();
            AccountIDTextBox.Clear();
            accountNameTextBox.Clear();
            accountStatusTextBox.Clear();
            pointsUsedTextBox.Clear();
            availablePointsTextBox.Clear();

        }

        //delete existing account
        private void deleteAccount_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand sqlCom = new SqlCommand("DELETE FROM dbo.Accounts WHERE AccountID =  + '" + AccountIDTextBox.Text + "'", con);

            sqlCom.ExecuteNonQuery();

            con.Close();

            clearTextBox();

            DisplayAccounts();
        }

        //add points to the selected account
        private void addPoints_Click(object sender, EventArgs e)
        {

            if (checkAccountStatus())
            {
                con.Open();

                SqlCommand sqlCom = new SqlCommand("UPDATE dbo.Accounts SET PointsAvailable = '" + (Int32.Parse(availablePointsTextBox.Text) + 100) + "'" + " WHERE AccountID =  + '" + AccountIDTextBox.Text + "'", con);

                sqlCom.ExecuteNonQuery();

                con.Close();

                clearTextBox();

                DisplayAccounts();
            }
            else
            {
                MessageBox.Show("The user account is INACTIVE and as such no points can be added. \nPlease activate the account in order to add points.");
            }

        }
        //check for the acounts active status
        private bool checkAccountStatus()
        {
            if (accountStatusTextBox.Text.Equals("ACTIVE"))
            {
                return true;
            }
            else
                return false;
        }

        //actiave or deactivate existign accounts
        private void ToggleStatus_Click(object sender, EventArgs e)
        {
            con.Open();

            if (checkAccountStatus())
            {
                SqlCommand sqlCom = new SqlCommand("UPDATE dbo.Accounts SET AccStatus = 'INACTIVE'" + " WHERE AccountID =  + '" + AccountIDTextBox.Text + "'", con);
                sqlCom.ExecuteNonQuery();
            }
            else
            {
                SqlCommand sqlCom = new SqlCommand("UPDATE dbo.Accounts SET AccStatus = 'ACTIVE'" + " WHERE AccountID =  + '" + AccountIDTextBox.Text + "'", con);
                sqlCom.ExecuteNonQuery();
            }

            con.Close();

            clearTextBox();

            DisplayAccounts();
        }

        //redeem points from a selected account.
        private void usePoints_Click(object sender, EventArgs e)
        {
            if (checkAccountStatus() && (Int32.Parse(availablePointsTextBox.Text) >= 100))
            {
                con.Open();

                SqlCommand sqlCom = new SqlCommand("UPDATE dbo.Accounts SET PointsAvailable = '" + (Int32.Parse(availablePointsTextBox.Text) - 125) + "'" + " WHERE AccountID =  + '" + AccountIDTextBox.Text + "'", con);

                sqlCom.ExecuteNonQuery();

                con.Close();

                clearTextBox();

                DisplayAccounts();
            }
            else
            {
                if (!checkAccountStatus())
                {
                    MessageBox.Show("The user account is INACTIVE and as such no points can be removed. \nPlease activate the account in order to add points.");
                }
                else
                {
                    MessageBox.Show("The user has insufficient points for redemption.");
                }

            }
        }
    }
}
