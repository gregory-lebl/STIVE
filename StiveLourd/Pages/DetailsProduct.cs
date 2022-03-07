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
    public partial class DetailsProduct : Form
    {
        
        public DetailsProduct(Article article)
        {
            InitializeComponent();
            NomLabel.Text=article.name;
            referenceLabel.Text=article.Ref;
            FamilleLabel.Text=article.family;
            VolumeLabel.Text=article.capacity;
            PrixLabel.Text=Convert.ToString(article.unitPrice);
            DescriptionLabel.Text=article.description;
            FournisseurLabel.Text=article.supplier;

        }
    }
}
