using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoyaltyPrime
{
    public partial class NewAccount : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = LOYALTY_PRIME; Integrated Security = True");

        public NewAccount()
        {
            InitializeComponent();
            DisplayAccounts();
        }


        //get the next available primary key
        private int getNextPRkey(String tableName)
        {
            SqlCommand cmd = new SqlCommand("SELECT nextAccountID FROM dbo.IDCounts", con);
            Int32 count = (Int32)cmd.ExecuteScalar();

            return ++count;
        }

        private void DisplayAccounts()
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
        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Users WHERE FirstName LIKE '" + filterTextBox.Text + "%'", con);

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

        //create a new account
        private void createNewAccount_Click(object sender, EventArgs e)
        {
                        try
            {
                con.Open();

                SqlCommand sqlCom = new SqlCommand(@"INSERT INTO dbo.Accounts 
                    VALUES('" + getNextPRkey("Users") + "'" +
                        ", '" + userIDTextBox.Text + "'" +
                        ", '" + acountNameComboxBox.Text + "'" +
                        ", '" + pointsTextBox.Text + "'" +
                        ", '" + 0 + "'" +
                        ", '" + acountStatusComboBox.Text + "')", con);


                sqlCom.ExecuteNonQuery();

                SqlCommand com = new SqlCommand(@"DECLARE @IncrementValue int
                    SET @IncrementValue = 1
                    UPDATE dbo.IDCounts SET nextAccountID = nextAccountID + @IncrementValue", con);


                com.ExecuteNonQuery();

                con.Close();

            }
            catch (SqlException ex)
            {
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

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userIDTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            firstNameTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            lastNameTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

    }
}
