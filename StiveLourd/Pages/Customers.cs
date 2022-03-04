using System;
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
            /*this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stiveDBDataSet);*/

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
            _main.NavigateTo("ADD_CUSTOMER");
        }
    }
}
