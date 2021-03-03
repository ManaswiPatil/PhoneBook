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
using System.Configuration;

namespace PhoneBook
{
    public partial class PhoneBookForm : Form
    {
        public static string dbConnection = ConfigurationManager.ConnectionStrings["PhonebookDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(dbConnection);

        string id;  string firstName; string lastName; string phoneNumber; string address; string email;

        public PhoneBookForm()
        {
            InitializeComponent();
        }

        private void exitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newContact_Click(object sender, EventArgs e)
        {
            NewContact newContact = new NewContact(sqlconn);
            newContact.Show();
        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            EditContact editContact = new EditContact(id, firstName, lastName,phoneNumber, address, email, sqlconn);
            editContact.Show();
        }

        private void allContactsButton_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            string sqlquery = "select * from Contacts";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            allContactsDataGridView.DataSource = dt;
            allContactsDataGridView.AllowUserToAddRows = false;
            allContactsDataGridView.Columns["Id"].Visible = false;
            allContactsDataGridView.Columns["FirstName"].HeaderText = "First Name";
            allContactsDataGridView.Columns["LastName"].HeaderText = "Last Name";
            allContactsDataGridView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            allContactsDataGridView.Columns["Address"].HeaderText = "Address";
            allContactsDataGridView.Columns["Email"].HeaderText = "Email ID";

            sqlconn.Close();
        }

        private void allContactsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = allContactsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            firstName = allContactsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            lastName = allContactsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            phoneNumber = allContactsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            address = allContactsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            email = allContactsDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void deleteContactButton_Click(object sender, EventArgs e)
        {
            if(allContactsDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Contact List is Empty. Load the list and select the contact to delete.");
            }
            else
            {
                sqlconn.Open();

                string sqlquery = "Delete from Contacts where PhoneNumber = '" + allContactsDataGridView.SelectedRows[0].Cells[3].Value.ToString() + "'";

                SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Contact deleted Successfully. Please refresh the contact list.");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            sqlconn.Open();
            string sqlquery = "select * from Contacts where (lower(FirstName) like lower('%"+searchTextBox.Text+"%')) or (LastName like '%"+searchTextBox.Text+"%') or (PhoneNumber like '%"+searchTextBox.Text+"%')";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            allContactsDataGridView.DataSource = dt;
            allContactsDataGridView.AllowUserToAddRows = false;
            allContactsDataGridView.Columns["Id"].Visible = false;
            allContactsDataGridView.Columns["FirstName"].HeaderText = "First Name";
            allContactsDataGridView.Columns["LastName"].HeaderText = "Last Name";
            allContactsDataGridView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            allContactsDataGridView.Columns["Address"].HeaderText = "Address";
            allContactsDataGridView.Columns["Email"].HeaderText = "Email ID";

            sqlconn.Close();
        }
    }
}
