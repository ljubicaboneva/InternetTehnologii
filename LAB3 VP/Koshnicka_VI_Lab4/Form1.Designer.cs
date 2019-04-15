namespace Koshnicka_VI_Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbllista = new System.Windows.Forms.Label();
            this.listProdukti = new System.Windows.Forms.ListBox();
            this.btnIsprazniProdukti = new System.Windows.Forms.Button();
            this.gboxDetali = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtCenaProdukt = new System.Windows.Forms.TextBox();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.listKoshnicka = new System.Windows.Forms.ListBox();
            this.lblKoshnica = new System.Windows.Forms.Label();
            this.lblVkupno = new System.Windows.Forms.Label();
            this.btnDodadiKoshnicka = new System.Windows.Forms.Button();
            this.btnIzbrishiKosnicka = new System.Windows.Forms.Button();
            this.btnIzbrishiProdukt = new System.Windows.Forms.Button();
            this.btnDodadiNov = new System.Windows.Forms.Button();
            this.btnIsprazniKoshnicka = new System.Windows.Forms.Button();
            this.txtVkupno = new System.Windows.Forms.TextBox();
            this.gboxDetali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Location = new System.Drawing.Point(18, 27);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(105, 13);
            this.lbllista.TabIndex = 0;
            this.lbllista.Text = "Листа на продукти:";
            // 
            // listProdukti
            // 
            this.listProdukti.FormattingEnabled = true;
            this.listProdukti.Location = new System.Drawing.Point(21, 43);
            this.listProdukti.Name = "listProdukti";
            this.listProdukti.Size = new System.Drawing.Size(219, 342);
            this.listProdukti.TabIndex = 1;
            this.listProdukti.SelectedIndexChanged += new System.EventHandler(this.listProdukti_SelectedIndexChanged);
            // 
            // btnIsprazniProdukti
            // 
            this.btnIsprazniProdukti.Location = new System.Drawing.Point(21, 403);
            this.btnIsprazniProdukti.Name = "btnIsprazniProdukti";
            this.btnIsprazniProdukti.Size = new System.Drawing.Size(219, 23);
            this.btnIsprazniProdukti.TabIndex = 2;
            this.btnIsprazniProdukti.Text = "Испразни ја листата со продукти?";
            this.btnIsprazniProdukti.UseVisualStyleBackColor = true;
            this.btnIsprazniProdukti.Click += new System.EventHandler(this.btnIsprazniProdukti_Click);
            // 
            // gboxDetali
            // 
            this.gboxDetali.Controls.Add(this.txtCenaProdukt);
            this.gboxDetali.Controls.Add(this.txtKategorija);
            this.gboxDetali.Controls.Add(this.txtIme);
            this.gboxDetali.Controls.Add(this.lblCena);
            this.gboxDetali.Controls.Add(this.lblKategorija);
            this.gboxDetali.Controls.Add(this.lblIme);
            this.gboxDetali.Location = new System.Drawing.Point(261, 43);
            this.gboxDetali.Name = "gboxDetali";
            this.gboxDetali.Size = new System.Drawing.Size(279, 178);
            this.gboxDetali.TabIndex = 3;
            this.gboxDetali.TabStop = false;
            this.gboxDetali.Text = "Детали за продуктот";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(464, 241);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // txtCenaProdukt
            // 
            this.txtCenaProdukt.Enabled = false;
            this.txtCenaProdukt.Location = new System.Drawing.Point(6, 152);
            this.txtCenaProdukt.Name = "txtCenaProdukt";
            this.txtCenaProdukt.Size = new System.Drawing.Size(177, 20);
            this.txtCenaProdukt.TabIndex = 5;
            // 
            // txtKategorija
            // 
            this.txtKategorija.Enabled = false;
            this.txtKategorija.Location = new System.Drawing.Point(6, 94);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(259, 20);
            this.txtKategorija.TabIndex = 4;
            // 
            // txtIme
            // 
            this.txtIme.Enabled = false;
            this.txtIme.Location = new System.Drawing.Point(6, 36);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(259, 20);
            this.txtIme.TabIndex = 3;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(10, 136);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(36, 13);
            this.lblCena.TabIndex = 2;
            this.lblCena.Text = "Цена:";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(10, 78);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(65, 13);
            this.lblKategorija.TabIndex = 1;
            this.lblKategorija.Text = "Категорија:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(7, 20);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Име:";
            // 
            // listKoshnicka
            // 
            this.listKoshnicka.FormattingEnabled = true;
            this.listKoshnicka.Location = new System.Drawing.Point(558, 43);
            this.listKoshnicka.Name = "listKoshnicka";
            this.listKoshnicka.Size = new System.Drawing.Size(219, 303);
            this.listKoshnicka.TabIndex = 4;
            this.listKoshnicka.SelectedIndexChanged += new System.EventHandler(this.listKoshnicka_SelectedIndexChanged);
            // 
            // lblKoshnica
            // 
            this.lblKoshnica.AutoSize = true;
            this.lblKoshnica.Location = new System.Drawing.Point(555, 27);
            this.lblKoshnica.Name = "lblKoshnica";
            this.lblKoshnica.Size = new System.Drawing.Size(60, 13);
            this.lblKoshnica.TabIndex = 5;
            this.lblKoshnica.Text = "Кошничка:";
            // 
            // lblVkupno
            // 
            this.lblVkupno.AutoSize = true;
            this.lblVkupno.Location = new System.Drawing.Point(552, 368);
            this.lblVkupno.Name = "lblVkupno";
            this.lblVkupno.Size = new System.Drawing.Size(46, 13);
            this.lblVkupno.TabIndex = 6;
            this.lblVkupno.Text = "Вкупно:";
            // 
            // btnDodadiKoshnicka
            // 
            this.btnDodadiKoshnicka.Location = new System.Drawing.Point(280, 241);
            this.btnDodadiKoshnicka.Name = "btnDodadiKoshnicka";
            this.btnDodadiKoshnicka.Size = new System.Drawing.Size(164, 23);
            this.btnDodadiKoshnicka.TabIndex = 7;
            this.btnDodadiKoshnicka.Text = "Додади во кошничка >>";
            this.btnDodadiKoshnicka.UseVisualStyleBackColor = true;
            this.btnDodadiKoshnicka.Click += new System.EventHandler(this.btnDodadiKoshnicka_Click);
            // 
            // btnIzbrishiKosnicka
            // 
            this.btnIzbrishiKosnicka.Location = new System.Drawing.Point(280, 280);
            this.btnIzbrishiKosnicka.Name = "btnIzbrishiKosnicka";
            this.btnIzbrishiKosnicka.Size = new System.Drawing.Size(253, 23);
            this.btnIzbrishiKosnicka.TabIndex = 8;
            this.btnIzbrishiKosnicka.Text = "Избриши од кошничка";
            this.btnIzbrishiKosnicka.UseVisualStyleBackColor = true;
            this.btnIzbrishiKosnicka.Click += new System.EventHandler(this.btnIzbrishiKosnicka_Click);
            // 
            // btnIzbrishiProdukt
            // 
            this.btnIzbrishiProdukt.Location = new System.Drawing.Point(280, 356);
            this.btnIzbrishiProdukt.Name = "btnIzbrishiProdukt";
            this.btnIzbrishiProdukt.Size = new System.Drawing.Size(253, 23);
            this.btnIzbrishiProdukt.TabIndex = 10;
            this.btnIzbrishiProdukt.Text = "Избриши продукт";
            this.btnIzbrishiProdukt.UseVisualStyleBackColor = true;
            this.btnIzbrishiProdukt.Click += new System.EventHandler(this.btnIzbrishiProdukt_Click);
            // 
            // btnDodadiNov
            // 
            this.btnDodadiNov.Location = new System.Drawing.Point(280, 319);
            this.btnDodadiNov.Name = "btnDodadiNov";
            this.btnDodadiNov.Size = new System.Drawing.Size(253, 23);
            this.btnDodadiNov.TabIndex = 9;
            this.btnDodadiNov.Text = "Додади нов продукт";
            this.btnDodadiNov.UseVisualStyleBackColor = true;
            this.btnDodadiNov.Click += new System.EventHandler(this.btnDodadiNov_Click);
            // 
            // btnIsprazniKoshnicka
            // 
            this.btnIsprazniKoshnicka.Location = new System.Drawing.Point(558, 403);
            this.btnIsprazniKoshnicka.Name = "btnIsprazniKoshnicka";
            this.btnIsprazniKoshnicka.Size = new System.Drawing.Size(216, 23);
            this.btnIsprazniKoshnicka.TabIndex = 11;
            this.btnIsprazniKoshnicka.Text = "Испразни ја кошничката?";
            this.btnIsprazniKoshnicka.UseVisualStyleBackColor = true;
            this.btnIsprazniKoshnicka.Click += new System.EventHandler(this.btnIsprazniKoshnicka_Click);
            // 
            // txtVkupno
            // 
            this.txtVkupno.Enabled = false;
            this.txtVkupno.Location = new System.Drawing.Point(607, 365);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.Size = new System.Drawing.Size(166, 20);
            this.txtVkupno.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtVkupno);
            this.Controls.Add(this.btnIsprazniKoshnicka);
            this.Controls.Add(this.btnIzbrishiProdukt);
            this.Controls.Add(this.btnDodadiNov);
            this.Controls.Add(this.btnIzbrishiKosnicka);
            this.Controls.Add(this.btnDodadiKoshnicka);
            this.Controls.Add(this.lblVkupno);
            this.Controls.Add(this.lblKoshnica);
            this.Controls.Add(this.listKoshnicka);
            this.Controls.Add(this.gboxDetali);
            this.Controls.Add(this.btnIsprazniProdukti);
            this.Controls.Add(this.listProdukti);
            this.Controls.Add(this.lbllista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxDetali.ResumeLayout(false);
            this.gboxDetali.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllista;
        private System.Windows.Forms.ListBox listProdukti;
        private System.Windows.Forms.Button btnIsprazniProdukti;
        private System.Windows.Forms.GroupBox gboxDetali;
        private System.Windows.Forms.TextBox txtCenaProdukt;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.ListBox listKoshnicka;
        private System.Windows.Forms.Label lblKoshnica;
        private System.Windows.Forms.Label lblVkupno;
        private System.Windows.Forms.Button btnDodadiKoshnicka;
        private System.Windows.Forms.Button btnIzbrishiKosnicka;
        private System.Windows.Forms.Button btnIzbrishiProdukt;
        private System.Windows.Forms.Button btnDodadiNov;
        private System.Windows.Forms.Button btnIsprazniKoshnicka;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

