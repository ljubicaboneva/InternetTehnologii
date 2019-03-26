using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narachka_Pica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }
        string big = " ";
        string dodatok1 = " ";
        string dodatok2 = " ";
        string dodatok3 = " ";

        string kolichina1 = " ";
        string kolichina2= " ";
        string kolichina3 = " ";

        string pijalok1 = " ";
        string pijalok2 = " ";
        string pijalok3 = " ";

        string desertche = " ";
            

        public void calculateTotal()
        {
            
            int vk = 0;
            int proizvod_Pijalok1 = 1;
            int proizvod_Pijalok2 = 1;
            int proizvod_Pijalok3 = 1;

            if (mala.Checked)
            {
                vk += Convert.ToInt32(MalaCena.Text);
                big = mala.Text;

            }
            else if (sredna.Checked)
            {
                vk += Convert.ToInt32(SrednaCena.Text);
                big = sredna.Text;
            }
            else
            {
                vk += Convert.ToInt32(GolemaCena.Text);
                big = golema.Text;
            }

            if (feferonki.Checked)
            {
                vk += Convert.ToInt32(Dodatok1.Text);
                dodatok1 = feferonki.Text;
            }

            else if (!feferonki.Checked)
            {
                dodatok1 =" ";
            }
            if (sirenje.Checked)
            {
                vk += Convert.ToInt32(Dodatok2.Text);
                dodatok2 = sirenje.Text;
            }
            else if (!sirenje.Checked)
            {
                dodatok2 =" ";
            }
            if (kechap.Checked)
            {
                vk += Convert.ToInt32(Dodatok3.Text);
                dodatok3 = kechap.Text;
            }
            else if (!kechap.Checked)
            {
                dodatok3 = " ";
            }


            Int32.TryParse(KolichinaPijalok1.Text, out int rez1);
            Int32.TryParse(KolichinaPijalok2.Text, out int rez2);
            Int32.TryParse(KolichinaPIjalok3.Text, out int rez3);

            if(KolichinaPijalok1.Text != "0")
            {
                kolichina1 = KolichinaPijalok1.Text;
                pijalok1 = label1.Text;
            }
            if (KolichinaPijalok2.Text != "0")
            {
                kolichina2 = KolichinaPijalok2.Text;
                pijalok2 = label2.Text;
            }
            if (KolichinaPijalok2.Text != "0")
            {
                kolichina3 = KolichinaPIjalok3.Text;
                pijalok3 = label3.Text;
            }
            
            proizvod_Pijalok1 = rez1 * Convert.ToInt32(CenaPijalok1.Text);
            proizvod_Pijalok2 = rez2 * Convert.ToInt32(CenaPijalok2.Text);
            proizvod_Pijalok3 = rez3 * Convert.ToInt32(CenaPijalok3.Text);
            VkPijalok1.Text = proizvod_Pijalok1.ToString();
            VkPijalok2.Text = proizvod_Pijalok2.ToString();
            VkPijalok3.Text = proizvod_Pijalok3.ToString();
            vk += proizvod_Pijalok1 + proizvod_Pijalok2 + proizvod_Pijalok3;





            if (listBox1.SelectedItem == "Овошна пита")
            {
                vk += Convert.ToInt32(CenaDesert.Text);
                desertche = "Овошна пита";
            }
            else if (listBox1.SelectedItem =="Сладолед")
                {
                    vk += Convert.ToInt32(CenaDesert.Text);
                desertche = "Сладолед";
                }
            else if (listBox1.SelectedItem == "Торта")
            {
                vk += Convert.ToInt32(CenaDesert.Text);
                desertche = "Торта";
            }
            else
            {
                vk += 0;
            }

            Vkupno.Text = vk.ToString();
 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "Овошна пита")
            {
                CenaDesert.Text = "60";
            }
            else if (listBox1.SelectedItem == "Сладолед")
            {
                CenaDesert.Text = "30";
            }
            else if (listBox1.SelectedItem == "Торта")
            {
                CenaDesert.Text = "50";
            }
            calculateTotal();

        }

        private void mala_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void sredna_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void golema_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void feferonki_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void sirenje_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void kechap_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void KolichinaPijalok1_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void KolichinaPijalok2_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void KolichinaPIjalok3_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        public string prozorche()
        {
            StringBuilder prvo = new StringBuilder();
            StringBuilder vtoro = new StringBuilder();
            StringBuilder treto = new StringBuilder();
            StringBuilder chetvrto = new StringBuilder();
            StringBuilder celo = new StringBuilder();

            prvo.Append("Големина: " + big + "\n");
            prvo.ToString();
            vtoro.Append("Додаток: " + dodatok1 + " " + dodatok2 + " " + dodatok3 + "\n");
            vtoro.ToString();

            treto.Append("Пијалок: " + pijalok1 + " " + kolichina1 + "\n" + pijalok2 + " " + kolichina2 + "\n" + pijalok3 + " " + kolichina3 + "\n");
            treto.ToString();

            chetvrto.Append("Десерт: " + desertche);

            celo.Append(prvo);
            if (dodatok1 != " " || dodatok2 != " " || dodatok3 != " ")
            {
                celo.Append(vtoro);

            }

            if (kolichina1 != " " || kolichina2 != " " || kolichina3 != " ")
            {
                celo.Append(treto);

            }
            if (desertche != " ")
            {
                celo.Append(chetvrto);
            }
            return celo.ToString();
     }

        private void btnNarachaj_Click(object sender, EventArgs e)
        {

            string celo = prozorche();
            DialogResult result = MessageBox.Show(celo, "Вашата нарачка",
               MessageBoxButtons.OK, // vid na dijalogot 
               MessageBoxIcon.Question); // ikona na dijalogot
            
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сакате да ја откажете нарачката", "Откажи",
               MessageBoxButtons.YesNo, // vid na dijalogot 
               MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        int plati = 0;
        private void Naplateno_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(Naplateno.Text, out int rez);
            Int32.TryParse(Vkupno.Text, out int rez1);
            if(rez != 0)
            {
                plati = rez - rez1;
            }
            Vrakjanje.Text = plati.ToString();

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            if(Form.ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                string celo = prozorche();
                DialogResult result = MessageBox.Show(celo, "Вашата нарачка",
             MessageBoxButtons.OK, 
             MessageBoxIcon.Question); 
                return true;
            }

            return base.ProcessDialogKey(keyData);

        }
    }

   }

        
    

