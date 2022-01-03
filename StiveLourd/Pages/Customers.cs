using System;
using StiveLourd.Data;
using System.Windows.Forms;

namespace StiveLourd.Pages
{
    public partial class Customers : Form
    {
        private Main _main;
        public Customers(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        

        private void btn_accueil_Click(object sender, EventArgs e)
        {
            Database.Path = null;
            _main.NavigateTo("HOME");
        }

        private void btn_produits_Click(object sender, EventArgs e)
        {
            Database.Path = null;
            _main.NavigateTo("PRODUCTS");
        }

        private void btn_fournisseurs_Click(object sender, EventArgs e)
        {
            Database.Path = null;
            _main.NavigateTo("SUPPLIERS");
        }
        private void btn_commandes_Click(object sender, EventArgs e)
        {
            Database.Path = null;
            _main.NavigateTo("COMMANDS");
        }
    }
}
