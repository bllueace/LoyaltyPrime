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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
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
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
            }
        }


        private void newAccount_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.FormClosed += new FormClosedEventHandler(newAccount_FormClosed);

            newAccount.ShowDialog();
        }

        private void DisplayAccounts()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Accounts", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item[5].ToString();
            }
        }

        void newAccount_FormClosed(object sender, FormClosedEventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Accounts", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item[5].ToString();
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand sqlCom = new SqlCommand("DELETE FROM Users WHERE UserID =  + '" + userIDTextBox.Text  +"'" , con);

            sqlCom.ExecuteNonQuery();

            con.Close();

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

        //clear textboxes as needeed.
        private void clearTextBox()
        {
            userIDTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            addressTextBox.Clear();
        }

        /*        private int getNrAccounts(int userID)
                {
                    con.Open();

                    SqlCommand sqlCom = new SqlCommand("SELECT NrAccounts FROM dbo.Users WHERE UserID = " + userID, con);

                    int nrAccounts = (int)sqlCom.ExecuteNonQuery();

                    con.Close();

                    return nrAccounts;
                }*/
    }
}
