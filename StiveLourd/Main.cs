using StiveLourd.Pages;
using StiveLourd.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StiveLourd
{
    public partial class Main : Form
    {
        private Form _currentForm;

        public Main()
        {
            InitializeComponent();
            //TODO : enlever le menu left
            menu_left.Visible=true;
            NavigateTo("CONNECT");

            
        }

        public void NavigateTo(string page)
        {
            // On crée la nouvelle page
            Form frm;
            switch (page)
            {
                case "HOME":
                    // Afficher le menu left
                    menu_left.Visible=true;
                    // BTN Active
                    btn_active_accueil.Visible=true;
                    //BTN INACTIVE
                        btn_active_produits.Visible=false;
                        btn_active_fournisseurs.Visible=false;
                        btn_active_commandes.Visible=false;
                        btn_active_clients.Visible=false;
                    frm = new Home(this);
                    break;
                case "CONNECT":
                    // Enlever le menu left
                        menu_left.Visible=false;
                    frm = new Connect(this);
                    break;
                case "PRODUCTS":
                    // BTN Active
                        btn_active_produits.Visible=true;
                    //BTN INACTIVE
                        btn_active_accueil.Visible=false;
                        btn_active_fournisseurs.Visible=false;
                        btn_active_commandes.Visible=false;
                        btn_active_clients.Visible=false;
                    frm = new Products(this);
                    break;
                case "SUPPLIERS":
                    // BTN Active
                        btn_active_fournisseurs.Visible=true;
                    //BTN INACTIVE
                        btn_active_accueil.Visible=false;
                        btn_active_produits.Visible=false;
                        btn_active_commandes.Visible=false;
                        btn_active_clients.Visible=false;
                    frm = new Suppliers(this);
                    break;
                case "COMMANDS":
                    // BTN Active
                        btn_active_commandes.Visible=true;
                    //BTN INACTIVE
                        btn_active_accueil.Visible=false;
                        btn_active_produits.Visible=false;
                        btn_active_fournisseurs.Visible=false;
                        btn_active_clients.Visible=false;
                    frm = new Commands(this);
                    break;
                case "CUSTOMERS":
                    // BTN Active
                     btn_active_clients.Visible=true;
                    //BTN INACTIVE
                        btn_active_accueil.Visible=false;
                        btn_active_produits.Visible=false;
                        btn_active_fournisseurs.Visible=false;
                        btn_active_commandes.Visible=false;
                    frm = new Customers(this);
                    break;
                case "ADD_PRODUCT":
                    // BTN Active
                        btn_active_produits.Visible=true;
                    //BTN INACTIVE
                        btn_active_accueil.Visible=false;
                        btn_active_fournisseurs.Visible=false;
                        btn_active_commandes.Visible=false;
                        btn_active_clients.Visible=false;
                    frm= new AddProduct();

                    break;
                case "ADD_SUPPLIERS":
                    // BTN Active
                        btn_active_fournisseurs.Visible=true;
                    //BTN INACTIVE
                        btn_active_accueil.Visible=false;
                        btn_active_produits.Visible=false;
                        btn_active_commandes.Visible=false;
                        btn_active_clients.Visible=false;
                    frm = new AddSuppliers(this);
                    break;
                case "ADD_COMM_SUPPLIERS":
                    // BTN Active
                        btn_active_fournisseurs.Visible=true;
                    //BTN INACTIVE
                        btn_active_accueil.Visible=false;
                        btn_active_produits.Visible=false;
                        btn_active_commandes.Visible=false;
                        btn_active_clients.Visible=false;
                    frm = new AddSuppliers(this);
                    break;
                case "ADD_CUSTOMERS":
                    // BTN Active
                        btn_active_clients.Visible=true;
                    //BTN INACTIVE
                        btn_active_accueil.Visible=false;
                        btn_active_produits.Visible=false;
                        btn_active_fournisseurs.Visible=false;
                        btn_active_commandes.Visible=false;
                    frm = new AddCustomers(this);
                    break;
                case "DETAILS_PRODUCT":
                    // BTN Active
                        btn_active_produits.Visible=true;
                    //BTN INACTIVE
                        btn_active_accueil.Visible=false;
                        btn_active_fournisseurs.Visible=false;
                        btn_active_commandes.Visible=false;
                        btn_active_clients.Visible=false;
                    frm= new DetailsProduct();
                    break;
                case "DETAILS_SUPPLIERS":
                    // BTN Active
                    btn_active_fournisseurs.Visible=true;
                    //BTN INACTIVE
                    btn_active_accueil.Visible=false;
                    btn_active_produits.Visible=false;
                    btn_active_commandes.Visible=false;
                    btn_active_clients.Visible=false;
                    frm = new AddSuppliers(this);
                    break;
                default:
                    return;
            }

            // On ferme la page courante
            if (_currentForm != null)
            {
                _currentForm.Close();
            }

            // On configure la nouvelle page
            _currentForm = frm;
            _currentForm.FormBorderStyle = FormBorderStyle.None;
            _currentForm.TopLevel = false;
            _currentForm.Dock = DockStyle.Fill;

            // On affiche la nouvelle page
            navContainer.Controls.Clear();
            navContainer.Controls.Add(_currentForm);
            _currentForm.Show();
        }

        private void btn_accueil_Click(object sender, EventArgs e)
        {
            Database.Path = null;
            NavigateTo("HOME");
        }

        private void btn_produits_Click(object sender, EventArgs e)
        {
            NavigateTo("PRODUCTS");
        }

        private void btn_fournisseurs_Click(object sender, EventArgs e)
        {
            NavigateTo("SUPPLIERS");
        }

        private void btn_commandes_Click(object sender, EventArgs e)
        {
            NavigateTo("COMMANDS");
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            NavigateTo("CUSTOMERS");
        }
    }
}
