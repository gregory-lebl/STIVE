using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Http;
using System.Globalization;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StiveLourd.Pages
{
    public partial class Products : Form
    {
        private Main _main;
        private const string BASE_URL = "https://localhost:44395";
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataSet ProductsDataSet = new DataSet();
        private BindingSource bindingTest = new BindingSource();

        Article[] articles;
        public Products(Main main)
        {
            InitializeComponent();
            _main = main;
            articleDataGridView.AutoGenerateColumns = false;
            Task<string> data = GetAllProducts();

            data.ContinueWith(delegate { BindData(data.Result); });
        }

        void BindData2(string data)
        {
            //Parser les données en objet ?


            // Placer ces données dans le tableau

            // Automatically generate the DataGridView columns.
            articleDataGridView.AutoGenerateColumns = false;
            //SqlConnection
            /*String connectionString =
                        "Server=(localdb)\\MSSQLLocalDB;Database=StiveDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection con = new SqlConnection(connectionString);

            DataSet dataSet = new DataSet();
            //Show in Datagridview
            SqlCommand queryAnnee = new SqlCommand("SELECT Number FROM Annee INNER JOIN Article ON Annee.AnneeId = Article.AnneeId", con);
            SqlCommand queryCepage = new SqlCommand("SELECT Origin, Cepage.Name FROM Cepage INNER JOIN Article ON Cepage.CepageId = Article.CepageId", con);
            SqlDataAdapter article = new SqlDataAdapter(queryCepage);*/
            //article.TableMappings.Add("Nom", "Name");
            //article.TableMappings.Add("Origine", "Origin");
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Année", typeof(int));
            //dt.Columns.Add("Cépage", typeof(string));
            //annee.Fill(dt);
            //article.Fill(dt);
            //dt.Rows.Add(cepage);

            DataTable table = new DataTable();
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Origine", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                table.Rows.Add("Book A", "10.01.2018");//Remplir le datagridview
            }


            //table.Rows.Add("Book B", "10.01.2018");
            //table.Rows.Add("Book C", "10.01.2018");
            //table.Rows.Add("Book D", "10.01.2018");
            //table.Rows.Add("Book E", "10.01.2018");
            //table.Rows.Add("Book F", "10.01.2018");
            //table.Rows.Add("Book G", "10.01.2018");
            //table.Rows.Add("Book H", "10.01.2018");

            articleDataGridView.DataSource = table;


            //dataSet.Tables.Add("Nom");
            //dataSet.Tables.Add("Origine");

            //article.SelectCommand = queryCepage;
            //article.Fill(dataSet.Tables["Nom"]);
            //article.SelectCommand = queryAnnee;
            //article.Fill(dataSet.Tables["Origine"]);

            //articleDataGridView.DataSource = dt;

        }
        /*private void getDataArticle()
        {
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri("https://localhost:44395/");
            HttpResponseMessage response = clint.GetAsync("ArticleList").Result;

            var emp = response.Content.ReadAsAsync<IEnumerable<Article>>().Result;
        }*/

        /*private void getAnnee()
        {
            var annee = new Annee();
            annee = Annee.GetAll();
        }*/

        //USELESS
        private void button1_Click(object sender, EventArgs e) { _main.NavigateTo("DETAILS_PRODUCT"); }
        //END USELESS

        private void navContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TitrePage_Click(object sender, EventArgs e)
        {

        }

        //NAvigate to add product page
        private void button2_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("ADD_PRODUCT");
        }

        private void Products_Load(object sender, EventArgs e)
        {
        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.articleTableAdapter.FillBy(this.stiveDBDataSet.Article);
                this.anneeTableAdapter.Fill(this.stiveDBDataSet.Annee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAnneeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.anneeTableAdapter.FillByAnnee(this.stiveDBDataSet.Annee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAnneeToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.anneeTableAdapter.FillByAnnee(this.stiveDBDataSet.Annee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void songsDataGridView_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                /*if (this.dataGridView.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }*/
            }
        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCepage_Click(object sender, EventArgs e)
        {

        }

        public async void BindData(string data)
        {

            articles = JsonConvert.DeserializeObject<Article[]>(data);



            DataTable table = new DataTable();
            table.Columns.Add("Référence", typeof(string));
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Famille", typeof(string));
            table.Columns.Add("Cépage", typeof(string));
            table.Columns.Add("Année", typeof(int));

            table.Columns.Add("Volume Unitaire", typeof(string));

            foreach (var article in articles)
            {
                table.Rows.Add(article.Ref, article.name, article.family, article.cepage, article.annee == null ? 2012 : article.annee, article.capacity);
            }
            articleDataGridView.Invoke((MethodInvoker)delegate
            {

                articleDataGridView.AutoGenerateColumns = true;
                articleDataGridView.DataSource = null;
                articleDataGridView.DataSource = table;
            });
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

        private void articleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                if(articles != null)
                {
                    if(articles.Length > e.RowIndex)
                    {
                        _main.NavigateTo("DETAILS_PRODUCT", articles[e.RowIndex]);
                    }
                }
                //MessageBox.Show(articleDataGridView.CurrentCell.Value.ToString());
                
            }
        }
    }
}
