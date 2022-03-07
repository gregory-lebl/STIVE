using Newtonsoft.Json;
using StiveLourd.Data.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StiveLourd.Pages
{
    public partial class Commands : Form
    {
        private Main _main;
        private const string BASE_URL = "https://localhost:44395";

        Order[] orders;
        public Commands(Main main)
        {
            InitializeComponent();
            _main = main;
            Task<string> data = GetAllOrders();

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
        private void menu_left_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void navContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void purchaseOrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseOrderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stiveDBDataSet);

        }

        private void Commands_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet._ArticleRow'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.articleRowTableAdapter.Fill(this.stiveDBDataSet._ArticleRow);
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.ClientOrder'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientOrderTableAdapter.Fill(this.stiveDBDataSet.ClientOrder);
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.PurchaseOrder'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.purchaseOrderTableAdapter.Fill(this.stiveDBDataSet.PurchaseOrder);

        }
        public async Task<string> GetAllOrders()
        {
            var data = string.Empty;
            string endpoint = BASE_URL + "/api/clientOrder";
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
            orders = JsonConvert.DeserializeObject<Order[]>(data);
            DataTable table = new DataTable();
            table.Columns.Add("Référence", typeof(string));
            table.Columns.Add("Prix Hors taxes", typeof(string));
            table.Columns.Add("Prix TTC", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Référence client", typeof(string));
            table.Columns.Add("Status", typeof(string));

            foreach (var order in orders)
            {
                table.Rows.Add(order.reference,order.htprice,order.ttcprice,order.date, order.customerReference,order.status);
            }
            purchaseOrderDataGridView.Invoke((MethodInvoker)delegate
            {

                purchaseOrderDataGridView.AutoGenerateColumns = true;
                purchaseOrderDataGridView.DataSource = null;
                purchaseOrderDataGridView.DataSource = table;
            });
        }
    }
}
