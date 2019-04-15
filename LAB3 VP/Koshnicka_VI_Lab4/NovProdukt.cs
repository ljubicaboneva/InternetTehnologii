using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koshnicka_VI_Lab4
{
    public partial class Form2 : Form
    {
       public Product produkt { get; set; }
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            produkt = new Product();
            produkt.Name = txtName.Text;
            produkt.Kateogrija = txtCategory.Text;
            int.TryParse(txtPrice.Text,out int price);
            produkt.Cena = price;
            DialogResult = DialogResult.OK ;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
                DialogResult =DialogResult.Cancel;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                e.Cancel = true;

                validatorName.SetError(txtName, "Внесете име!");
            }
            else
            {
                validatorName.SetError(txtName, null);
            }
        }

        private void txtCategory_Validating(object sender, CancelEventArgs e)
        {
            if (txtCategory.Text.Trim().Length == 0)
            {
                e.Cancel = true;

                validatorCategory.SetError(txtCategory, "Внеси категорија");

            }
            else
            {
                validatorCategory.SetError(txtCategory, null);
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrice.Text.Trim().Length == 0)
            {
                e.Cancel = true;

                validatorPrice.SetError(txtPrice, "Внеси цена");
            }
            else if (!(int.TryParse(txtPrice.Text, out int c)))
            {
                e.Cancel = true;
                
                validatorPrice.SetError(txtPrice, "Грешка формат");
            }
            else
            {
                validatorPrice.SetError(txtPrice, null);
            }
        }
    }
}
