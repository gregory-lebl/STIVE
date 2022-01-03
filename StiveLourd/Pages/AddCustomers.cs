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
    public partial class AddCustomers : Form
    {
        private Main _main;
        public AddCustomers(Main main)
        {
            InitializeComponent();
            _main = main;
        }
    }
}
