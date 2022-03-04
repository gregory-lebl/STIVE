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
        public AddProduct()
        {
            InitializeComponent();

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            textBoxDescription.Multiline= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameNewProd=textBoxDesignation.ToString();
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
