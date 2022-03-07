using Newtonsoft.Json;
using StiveLourd.Data.Model;
using System;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StiveLourd.Pages
{
    public partial class Customers : Form
    {
        private Main _main;
        private const string BASE_URL = "https://localhost:44395";

        Client[] clients;
        public Customers(Main main)
        {
            InitializeComponent();
            _main = main;
            clientDataGridView.AutoGenerateColumns=true;
            Task<string> data = GetAllCustomers();

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

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stiveDBDataSet);*/

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet1.Customers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.customersTableAdapter.Fill(this.stiveDBDataSet1.Customers);
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.Customers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.customersTableAdapter.Fill(this.stiveDBDataSet.Customers);

        }

        private void navContainer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("ADD_CUSTOMERS");
        }

        public async Task<string> GetAllCustomers()
        {
            var data = string.Empty;
            string endpoint = BASE_URL + "/api/customer";
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
            clients = JsonConvert.DeserializeObject<Client[]>(data);
            DataTable table = new DataTable();
            table.Columns.Add("Nom de Famille", typeof(string));
            table.Columns.Add("Prénom", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Adresse", typeof(string));
            table.Columns.Add("Cp", typeof(string));
            table.Columns.Add("Ville", typeof(string));
            table.Columns.Add("N° de téléphone", typeof(int));


            foreach (var client in clients)
            {
                table.Rows.Add(client.lastName, client.firstName, client.email, client.address, client.cp, client.city, client.phoneNumber);
            }
            clientDataGridView.Invoke((MethodInvoker)delegate
            {

                clientDataGridView.AutoGenerateColumns = true;
                clientDataGridView.DataSource = null;
                clientDataGridView.DataSource = table;
            });
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (clients != null)
                {
                    if (clients.Length > e.RowIndex)
                    {
                        _main.NavigateTo("DETAILS_CUSTOMER", clients[e.RowIndex]);
                    }
                }
                //MessageBox.Show(articleDataGridView.CurrentCell.Value.ToString());

            }
        }
    }

}
