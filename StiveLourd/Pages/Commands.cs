using System;
using System.Windows.Forms;

namespace StiveLourd.Pages
{
    public partial class Commands : Form
    {
        private Main _main;
        public Commands(Main main)
        {
            InitializeComponent();
            _main = main;
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
    }
}
