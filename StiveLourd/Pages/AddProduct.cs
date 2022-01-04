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
    }
}
