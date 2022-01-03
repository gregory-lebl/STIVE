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
    public partial class AddProduct : Form
    {
         new public bool TopLevel { get; set; }
        public AddProduct()
        {
            InitializeComponent();

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            textBoxDescription.Multiline= true;
        }
    }
}
