using System;
using System.Windows.Forms;

namespace StiveLourd.Pages
{
    public partial class Connect : Form
    {
        private Main _main;
        public Connect(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        

        private void btn_connexion_Click_1(object sender, EventArgs e)
        {
            _main.NavigateTo("HOME");
        }

        private void navContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
