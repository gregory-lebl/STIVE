using Newtonsoft.Json;
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
    public partial class Suppliers : Form
    {
        private Main _main;
        private const string BASE_URL = "https://localhost:44395";

        Fournisseur[] fournisseurs;
        public Suppliers(Main main)
        {
            InitializeComponent();
            _main = main;
            Task<string> data = GetAllSuppliers();
            supplierDataGridView.AutoGenerateColumns=true;

            data.ContinueWith(delegate { BindData(data.Result); });
        }

        private void btn_accueil_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("HOME");
        }
        private void btn_produits_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("PRODUCTS");
        }
        private void btn_fournisseurs_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("SUPPLIERS");
        }
        private void btn_commandes_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("COMMANDS");
        }
        private void btn_clients_Click(object sender, EventArgs e)
        {
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
            _main.NavigateTo("DETAILS_SUPPLIERS");
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stiveDBDataSet);

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.Supplier'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.supplierTableAdapter.Fill(this.stiveDBDataSet.Supplier);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.supplierTableAdapter.FillBy(this.stiveDBDataSet.Supplier, cpToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _main.NavigateTo("ADD_SUPPLIERS");
        }

        private void supplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _main.NavigateTo("DETAILS_SUPPLIER");
        }

        public async Task<string> GetAllSuppliers()
        {
            var data = string.Empty;
            string endpoint = BASE_URL + "/api/supplier";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }
            return data;
        }
        public async void BindData(string data)
        {
            fournisseurs = JsonConvert.DeserializeObject<Fournisseur[]>(data);
            DataTable table = new DataTable();
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Adresse", typeof(string));
            table.Columns.Add("Cp", typeof(string));
            table.Columns.Add("Ville", typeof(string));
            table.Columns.Add("N° de téléphone", typeof(string));
            table.Columns.Add("N° de SIRET", typeof(string));


            foreach (var fournisseur in fournisseurs)
            {
                table.Rows.Add(fournisseur.Name, fournisseur.Address, fournisseur.Cp, fournisseur.City, fournisseur.PhoneNumber, fournisseur.Siret);
            }
            supplierDataGridView.Invoke((MethodInvoker)delegate
            {

                supplierDataGridView.AutoGenerateColumns = true;
                supplierDataGridView.DataSource = null;
                supplierDataGridView.DataSource = table;
            });
        }
    }
}
