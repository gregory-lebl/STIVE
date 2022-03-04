using StiveLourd.Pages;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Data.SqlClient;

namespace StiveLourd
{
    public partial class Main : Form
    {
        private static HttpClient client;
        private DataGridView dataGrid = new DataGridView();
        private BindingSource bindingSource = new BindingSource();

        private const string BASE_URL = "https://localhost:44395";

        private Form _currentForm;
        
        

        public Main()
        {
            InitializeComponent();
            dataGrid.Dock = DockStyle.Fill;
            this.Controls.Add(dataGrid);

            //Cacher Menu Gauche
                menu_left.Visible=true;
            //GetAllProducts();
            NavigateTo("CONNECT");
        }



        public void NavigateTo(string page, Object arg1 = null)
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
                    frm = new AddCommSuppliers(this);
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
                    frm= new DetailsProduct((Article)arg1);
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

        public void CallAPI(string call)
        {
            client = new HttpClient();
            
            switch (call)
            {
                case "GET_PRODUITS_ALL":
                    var result = GetAllProducts().GetAwaiter().GetResult();
                    try
                    {
                        // Set up the DataGridView.
                        dataGrid.Dock = DockStyle.Fill;

                        // Automatically generate the DataGridView columns.
                        dataGrid.AutoGenerateColumns = true;

                        // Set up the data source.
                        bindingSource.DataSource = result;
                        //dataGrid.DataSource = bindingSource;

                        // Automatically resize the visible rows.
                        dataGrid.AutoSizeRowsMode =
                            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                        // Set the DataGridView control's border.
                        dataGrid.BorderStyle = BorderStyle.Fixed3D;

                        // Put the cells in edit mode when user enters them.
                        dataGrid.EditMode = DataGridViewEditMode.EditOnEnter;

                        //
                        dataGrid.Rows.Add(result);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("To run this sample replace connection.ConnectionString" +
                            " with a valid connection string to a Northwind" +
                            " database accessible to your system.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        System.Threading.Thread.CurrentThread.Abort();
                    }
                    break;


                default: 
                return;
            }
        }
        //API CALLS
        public async Task<string> GetAllProducts()
        {
            var data = string.Empty;
            string endpoint = BASE_URL + "/api/article";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }
            return data;
        }

    }
}
