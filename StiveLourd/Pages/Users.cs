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
    public partial class Users : Form
    {
        private Main _main;
        private Panel navContainer;
        private DataGridView usersDataGridView;
        private Label TitrePage;
        private ListBox listVille;
        private StiveDBDataSet stiveDBDataSet;
        private BindingSource employeeBindingSource;
        private System.ComponentModel.IContainer components;
        private StiveDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private Label label1;
        private Button btnAddUser;
        private DataGridViewButtonColumn Supprimer;
        private Button btnRecherche;

        //Client[] clients;
        public Users(Main main)
        {
            InitializeComponent();
            _main = main;
            usersDataGridView.AutoGenerateColumns=true;
            BindData();
            //Task<string> data = GetAllCustomers();

            //data.ContinueWith(delegate { BindData(data.Result); });
        }
        public void BindData()
        {
            //Parser les données en objet ?


            // Placer ces données dans le tableau

            // Automatically generate the DataGridView columns.

            //SqlConnection
            String connectionString =
                        "Server=(localdb)\\MSSQLLocalDB;Database=StiveDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection con = new SqlConnection(connectionString);

            DataSet dataSet = new DataSet();
            //Show in Datagridview
            SqlCommand query = new SqlCommand("SELECT LastName, Firstname, Email, PhoneNumber, City FROM Employee ", con);
            SqlDataAdapter article = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            article.Fill(dt);

            usersDataGridView.DataSource = dt;

        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.navContainer = new System.Windows.Forms.Panel();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listVille = new System.Windows.Forms.ListBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stiveDBDataSet = new StiveLourd.StiveDBDataSet();
            this.TitrePage = new System.Windows.Forms.Label();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeTableAdapter = new StiveLourd.StiveDBDataSetTableAdapters.EmployeeTableAdapter();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.navContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // navContainer
            // 
            this.navContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.navContainer.Controls.Add(this.btnAddUser);
            this.navContainer.Controls.Add(this.btnRecherche);
            this.navContainer.Controls.Add(this.label1);
            this.navContainer.Controls.Add(this.listVille);
            this.navContainer.Controls.Add(this.TitrePage);
            this.navContainer.Controls.Add(this.usersDataGridView);
            this.navContainer.Location = new System.Drawing.Point(0, 0);
            this.navContainer.Name = "navContainer";
            this.navContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navContainer.Size = new System.Drawing.Size(955, 715);
            this.navContainer.TabIndex = 7;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(50, 162);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(178, 36);
            this.btnRecherche.TabIndex = 43;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Recherche par ville";
            // 
            // listVille
            // 
            this.listVille.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "City", true));
            this.listVille.DataSource = this.employeeBindingSource;
            this.listVille.DisplayMember = "City";
            this.listVille.FormattingEnabled = true;
            this.listVille.ItemHeight = 16;
            this.listVille.Location = new System.Drawing.Point(50, 136);
            this.listVille.Name = "listVille";
            this.listVille.Size = new System.Drawing.Size(178, 20);
            this.listVille.TabIndex = 41;
            this.listVille.ValueMember = "City";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.stiveDBDataSet;
            // 
            // stiveDBDataSet
            // 
            this.stiveDBDataSet.DataSetName = "StiveDBDataSet";
            this.stiveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TitrePage
            // 
            this.TitrePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.TitrePage.Location = new System.Drawing.Point(356, 30);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(242, 45);
            this.TitrePage.TabIndex = 40;
            this.TitrePage.Text = "UTILISATEURS";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supprimer});
            this.usersDataGridView.Location = new System.Drawing.Point(20, 338);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(908, 311);
            this.usersDataGridView.TabIndex = 39;
            this.usersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickUser);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(390, 162);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(178, 36);
            this.btnAddUser.TabIndex = 44;
            this.btnAddUser.Text = "Ajouter un utilisateur";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.MinimumWidth = 6;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.Width = 125;
            // 
            // Users
            // 
            this.ClientSize = new System.Drawing.Size(955, 715);
            this.Controls.Add(this.navContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Users_Load);
            this.navContainer.ResumeLayout(false);
            this.navContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.Employee'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeeTableAdapter.Fill(this.stiveDBDataSet.Employee);

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            usersDataGridView.DataSource = null;
            usersDataGridView.Columns.Clear();
            String ville = Convert.ToString(listVille.SelectedValue);
            //SqlConnection
            String connectionString =
                        "Server=(localdb)\\MSSQLLocalDB;Database=StiveDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection con = new SqlConnection(connectionString);

            DataSet dataSet = new DataSet();
            //Show in Datagridview
            SqlCommand query = new SqlCommand("SELECT LastName, Firstname, Email, PhoneNumber, City FROM Employee WHERE City ='"+ville+"'", con);
            SqlDataAdapter user = new SqlDataAdapter(query);
            DataTable table = new DataTable();
            user.Fill(table);

            usersDataGridView.DataSource = table;
        }

        private void cellClickUser(object sender, DataGridViewCellEventArgs e)
        {
            //SqlConnection
            String connectionString =
                        "Server=(localdb)\\MSSQLLocalDB;Database=StiveDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = usersDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to delete user with email: {0}?", row.Cells["Email"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Email = @Email", con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Email", row.Cells["Email"].Value);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    BindData();
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _main.NavigateTo("ADD_USER");
        }
    }
}
