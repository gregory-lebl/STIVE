using System;
using StiveLourd.Pages;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StiveLourd.Pages
{
    public partial class Home : Form
    {
        private Main _main;

        public Home(Main main)
        {
            InitializeComponent();
            _main = main;
        }
        private void btn_accueil_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("HOME");
        }
        private void btn_produits_Click_1(object sender, EventArgs e)
        {
            _main.NavigateTo("PRODUCTS");
        }
        private void btn_fournisseurs_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("SUPPLIERS");
        }
        private void btn_clients_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("CUSTOMERS");
        }
        private void btn_commandes_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("COMMANDS");
        }
        private void btn_add_produit_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("ADD_PRODUCT");
            
        }

        private void btn_add_fournisseur_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("ADD_SUPPLIERS");
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("ADD_CUSTOMERS");
        }

        private void btn_new_comm_fournisseur_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("ADD_COMM_SUPPLIERS");
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("USERS");
        }
    }
}
