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
    public partial class NewUser : Form
    {

        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = LOYALTY_PRIME; Integrated Security = True");

        public NewUser()
        {
            InitializeComponent();
        }

        private void createNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand sqlCom = new SqlCommand(@"INSERT INTO Users 
                    VALUES('" + getNextPRkey("Users") + "'" +
                        ", '" + firstNameTextBox.Text + "'" +
                        ", '" + lastNameTextBox.Text + "'" +
                        ", '" + addressTextBox.Text + "')", con);


                sqlCom.ExecuteNonQuery();

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

        //get the next available primary key
        private int getNextPRkey(String tableName)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users", con);
            Int32 count = (Int32)cmd.ExecuteScalar();

            return ++count;
        }

        //close the form on cancel
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
