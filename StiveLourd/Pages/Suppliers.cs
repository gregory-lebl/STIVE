using System;
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
    }
}
