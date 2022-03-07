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
    public partial class AddSuppliers : Form
    {
        private Main _main;
        public AddSuppliers(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void AddSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stiveDBDataSet.Article'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.articleTableAdapter.Fill(this.stiveDBDataSet.Article);

        }
    }
}
