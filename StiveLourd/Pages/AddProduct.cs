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
    public partial class AddProduct : Form
    {
        private Main _main;
        static HttpClient client = new HttpClient();
        private string BaseUrl = "https://localhost:44395";


        public string nameNewProd;
        public string familyNewProd;
        public string volUniNewProd;
        public int yearNewProd;
        public string cepageNewProd;
        public string supplierNewProd;
        public int prixUniNewProd;
        public string descriptionNewProd;
        public int stockNewProd;
        public int stockMiniNewProd;
        public int approNewProd;
        new public bool TopLevel { get; set; }
        public AddProduct(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            textBoxDescription.Multiline= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Article article = new Article();

            if (!string.IsNullOrEmpty(textBoxDesignation.Text))
            {
                article.name = textBoxDesignation.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner le nom de l'article");
            }
            if (!string.IsNullOrEmpty(Convert.ToString(listBoxFamille.SelectedItem)))
            {
                article.familyId = Convert.ToString(listBoxFamille.SelectedItem);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner la famille de l'article");
            }
            if (!string.IsNullOrWhiteSpace(Convert.ToString(listBoxVolumeUnitaire.SelectedItem)))
            {
                article.capacityId = Convert.ToString(listBoxVolumeUnitaire.SelectedItem);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner le volume de l'article");
            }
            if (!string.IsNullOrWhiteSpace(Convert.ToString(listBoxAnnee.SelectedItem)))
            {
                article.anneeId = Convert.ToString(listBoxAnnee.SelectedItem);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner l'année de l'article");
            }
            if (!string.IsNullOrWhiteSpace(Convert.ToString(listBoxCépage.SelectedItem)))
            {
                article.cepageId = Convert.ToString(listBoxCépage.SelectedItem);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner le cépage l'article");
            }
            if (!string.IsNullOrWhiteSpace(Convert.ToString(listBoxNomFournisseur.SelectedItem)))
            {
                article.supplierId = Convert.ToString(listBoxNomFournisseur.SelectedItem);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner le fournisseur de l'article - S'il n'existe pas encore, veuillez le créer avant");
            }
            if (!string.IsNullOrWhiteSpace(textBoxPrix.Text))
            {
                article.unitPrice = Convert.ToDouble(textBoxPrix.Text);
            }
            else
            {
                MessageBox.Show("Veuillez renseigner la description de l'article");
            }
            if (!string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                article.description = textBoxDescription.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner la description de l'article");
            }
            if (!string.IsNullOrWhiteSpace(textBoxStock.Text))
            {
                article.stock = textBoxStock.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner le stock de l'article");
            }

            var result = article.PostNewProduct();
            if (result)
            {
                _main.NavigateTo("CUSTOMERS");
            }
            else
            {
                MessageBox.Show("Nous ne sommes pas parvenu à enregistrer le produit");
                _main.NavigateTo("CUSTOMERS");
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.Supplier'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.supplierTableAdapter.Fill(this.stiveDBDataSet.Supplier);
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.Family'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familyTableAdapter.Fill(this.stiveDBDataSet.Family);
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.Cepage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cepageTableAdapter.Fill(this.stiveDBDataSet.Cepage);
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.Capacity'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.capacityTableAdapter.Fill(this.stiveDBDataSet.Capacity);
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.Annee'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.anneeTableAdapter.Fill(this.stiveDBDataSet.Annee);

        }
    }
}
