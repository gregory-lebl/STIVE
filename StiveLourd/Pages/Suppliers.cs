using System;
using StiveLourd.Data;
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
    public partial class Suppliers : Form
    {
        private Main _main;
        public Suppliers(Main main)
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
        private void btn_clients_Click(object sender, EventArgs e)
        {
            Database.Path = null;
            _main.NavigateTo("CUSTOMERS");
        }





        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void navContainer_Paint(object sender, PaintEventArgs e)
        {
        }
        private void menu_left_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Database.Path = null;
            _main.NavigateTo("DETAILS_SUPPLIERS");
        }
    }
}
