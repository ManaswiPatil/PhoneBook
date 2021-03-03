using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhoneBook
{
    public partial class NewContact : Form
    {
        SqlConnection sqlconn;
        public NewContact()
        {
            InitializeComponent();
        }

        public NewContact(SqlConnection sqlConn)
            :this()
        {
            this.sqlconn = sqlConn;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            string sqlquery = "Insert into Contacts (FirstName, LastName, PhoneNumber, Address, Email)" +
                "values ('"+ firstNameTextBox.Text+"','"+ lastNameTextBox.Text+"','"+ phoneNumberTextBox.Text+"','"+ addressTextBox.Text+"','"+ emailTextBox.Text+"')";

            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);

            sqlcmd.ExecuteNonQuery();
            
            sqlconn.Close();

            foreach(Control c in Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = String.Empty;
            }

            MessageBox.Show("Contact added Successfully. Please refresh the contact list.");
        }
    }
}
