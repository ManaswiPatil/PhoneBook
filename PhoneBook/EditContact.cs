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
    public partial class EditContact : Form
    {
        SqlConnection sqlconn;
        private string _id; private string _firstName; private string _lastName; private string _phoneNumber; private string _address; private string _email;

        public EditContact()
        {
            InitializeComponent();
        }

        public EditContact(SqlConnection sqlconn)
    : this()
        {
            this.sqlconn = sqlconn;
        }

        public EditContact(string id, string firstName, string lastName, string phoneNumber, string address, string email, SqlConnection sqlconn)
    : this(sqlconn)
        {
            this._id = id;
            this._firstName = firstName;
            this._lastName = lastName;
            this._phoneNumber = phoneNumber;
            this._address = address;
            this._email = email;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditContact_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = _firstName;
            lastNameTextBox.Text = _lastName;
            phoneNumberTextBox.Text = _phoneNumber;
            addressTextBox.Text = _address;
            emailTextBox.Text = _email;
        }

        private void updateContactButton_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            string sqlquery = "Update Contacts set FirstName = '"+firstNameTextBox.Text+"', LastName = '"+lastNameTextBox.Text+"', PhoneNumber = '"+phoneNumberTextBox.Text+"', Address = '"+addressTextBox.Text+"', Email = '"+emailTextBox.Text+"' where (Id = "+ int.Parse(_id)+")";

            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlconn);

            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();

            MessageBox.Show("Contact updated Successfully. Please refresh the contact list.");
        }
    }
}
