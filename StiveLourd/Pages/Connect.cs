using System;
using StiveLourd.Data;
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
            Database.Path = null;
            _main.NavigateTo("HOME");
        }
    }
}
