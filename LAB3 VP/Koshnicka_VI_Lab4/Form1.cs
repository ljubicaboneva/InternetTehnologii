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

    public partial class Form1 : Form
    {
        public ProductItem produkt { get; set; }
        public void Izbrishi()
        {
            txtIme.Text = "";
            txtKategorija.Text = "";
            txtCenaProdukt.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIsprazniProdukti_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата продукти?", "Испразни ја листата?",
               MessageBoxButtons.YesNo, // vid na dijalogot 
               MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                listProdukti.Items.Clear();
                Izbrishi();
            }

        }

        private void btnDodadiNov_Click(object sender, EventArgs e)
        {
            Form2 nov = new Form2();
            DialogResult rez = nov.ShowDialog();
            if (rez == DialogResult.OK)
            {
                listProdukti.Items.Add(nov.produkt);
            }


        }

        private void listProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProdukti.SelectedIndex != -1)
            {
                txtIme.Text = ((Product)listProdukti.SelectedItem).Name;
                txtKategorija.Text = ((Product)listProdukti.SelectedItem).Kateogrija;
                txtCenaProdukt.Text = (((Product)listProdukti.SelectedItem).Cena).ToString("0.00");
            }
        }

        private void btnIzbrishiProdukt_Click(object sender, EventArgs e)
        {
            if (listProdukti.SelectedIndex != -1)
            {
                listProdukti.Items.Remove(listProdukti.SelectedItem);
                Izbrishi();
            }
        }

        private void btnIsprazniKoshnicka_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката продукти?", "Испразни ја кошничката?",
               MessageBoxButtons.YesNo, // vid na dijalogot 
               MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                listKoshnicka.Items.Clear();
                txtVkupno.Text = "";
                Izbrishi();
            }



        }

        int vk = 0;
        public int Vkupno()
        {
            foreach (ProductItem i in listKoshnicka.Items)
            {
                vk += i.Kolichina * i.Produkt.Cena;
                
            }
            return vk;
        }


        
        private void btnDodadiKoshnicka_Click(object sender, EventArgs e)
        {
            
            produkt = new ProductItem();
            produkt.Produkt = (Product)listProdukti.SelectedItem;
            produkt.Kolichina = (int)numericUpDown1.Value;
            listKoshnicka.Items.Add(produkt);
            vk = 0;
            txtVkupno.Text = Vkupno().ToString(".00");


        }

        private void btnIzbrishiKosnicka_Click(object sender, EventArgs e)
        {
            if (listKoshnicka.SelectedIndex != -1)
            {
                listKoshnicka.Items.Remove(listKoshnicka.SelectedItem);
                vk = 0;
                txtVkupno.Text = Vkupno().ToString(".00");
                Izbrishi();
            }

        }

        private void listKoshnicka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Kateogrija { get; set; }
        public int Cena { get; set; }
        public Product() { }
        Product(string ime, string kategorija, int cena)
        {
            Name = ime;
            Kateogrija = kategorija;
            Cena = cena;
        }
        public override string ToString()
        {

            return Name;
        }

    }

    public class ProductItem{
        public Product Produkt { get; set; }
        public int Kolichina { get; set; }
        public ProductItem() { }
        public ProductItem(Product produkt,int kolichina)
        {
            Produkt = produkt;
            Kolichina = kolichina;
        }
        public override string ToString()
        {
            string rez=Produkt.Name + " " + Kolichina + " x " + Produkt.Cena + " = " + Kolichina * Produkt.Cena;
            return rez;
            
        }

    }
}
