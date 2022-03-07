using Newtonsoft.Json;
using RestSharp;
using StiveLourd.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StiveLourd.Pages
{
    public partial class AddCustomers : Form
    {
        private Main _main;
        private const string BASE_URL = "https://localhost:44395";
        public AddCustomers(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();

            Client client = new Client();

            if (!string.IsNullOrEmpty(lastnameText.Text))
            {
                client.lastName = lastnameText.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner le nom du client");
            }
            if (!string.IsNullOrEmpty(firstnameText.Text))
            {
                client.firstName = firstnameText.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner le prénom du client");
            }
            if (!string.IsNullOrWhiteSpace(AdressText.Text))
            {
                client.address = AdressText.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner l'adresse du client");
            }
            if (!string.IsNullOrWhiteSpace(phonenumberText.Text))
            {
                client.phoneNumber = phonenumberText.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner le numéro de téléphone du client");
            }
            if (!string.IsNullOrWhiteSpace(emailText.Text))
            {
                client.email = emailText.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner l'adresse mail du client");
            }
            if (!string.IsNullOrWhiteSpace(cpText.Text))
            {
                client.cp = cpText.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner le code postal du client");
            }
            if (!string.IsNullOrWhiteSpace(cityText.Text))
            {
                client.city = cityText.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner la ville du client");
            }

            var result = client.PostNewCustomer();
            if (result)
            {
                _main.NavigateTo("CUSTOMERS");
            }

        }
    }
}
