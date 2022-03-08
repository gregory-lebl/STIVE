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

namespace StiveLourd.Pages
{
    public partial class AddUser : Form
    {
        private Main _main;
        public AddUser(Main main)
        {
            _main = main;
            InitializeComponent();
        }
        //Add new user
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            string lastname = lastnameText.Text;
            string firstname = firstnameText.Text;
            string email = emailText.Text;
            string password = passwordText.Text;
            string phonenumber = phonenumberText.Text;
            string address = adressText.Text;
            string cp = cpText.Text;
            string city = cityText.Text;

            String connectionString =
                        "Server=(localdb)\\MSSQLLocalDB;Database=StiveDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection con = new SqlConnection(connectionString);
            Guid id = Guid.NewGuid();
            string query = "INSERT INTO Employee (Id,LastName, Firstname,Email,Password,PhoneNumber,Address,Cp,City) VALUES ('" + id + "','" + lastname + "','" + firstname + "','" + email + "','" + password + "','" + phonenumber + "','" + address + "','" + cp + "','" + city + "')";
            SqlCommand command = new SqlCommand(query,con);
            try
            {
                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Congratulation,a new user has been saved");
                _main.NavigateTo("USERS");

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
