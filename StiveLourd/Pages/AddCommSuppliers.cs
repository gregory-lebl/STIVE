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
    public partial class AddCommSuppliers : Form
    {
        private Main _main;
        public AddCommSuppliers(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void FollowBy_Click(object sender, EventArgs e)
        {
            //TODO Récupérer et afficher nom du user connecté
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {
            //TODO Ajouter date du jour
            
        }

        private void formFournisseur_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
