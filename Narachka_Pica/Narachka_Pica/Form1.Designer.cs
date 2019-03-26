namespace Narachka_Pica
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
            this.golemina = new System.Windows.Forms.GroupBox();
            this.GolemaCena = new System.Windows.Forms.TextBox();
            this.SrednaCena = new System.Windows.Forms.TextBox();
            this.MalaCena = new System.Windows.Forms.TextBox();
            this.golema = new System.Windows.Forms.RadioButton();
            this.sredna = new System.Windows.Forms.RadioButton();
            this.mala = new System.Windows.Forms.RadioButton();
            this.dodatoci = new System.Windows.Forms.GroupBox();
            this.Dodatok3 = new System.Windows.Forms.TextBox();
            this.Dodatok2 = new System.Windows.Forms.TextBox();
            this.Dodatok1 = new System.Windows.Forms.TextBox();
            this.kechap = new System.Windows.Forms.CheckBox();
            this.sirenje = new System.Windows.Forms.CheckBox();
            this.feferonki = new System.Windows.Forms.CheckBox();
            this.pijalok = new System.Windows.Forms.GroupBox();
            this.VkPijalok3 = new System.Windows.Forms.TextBox();
            this.VkPijalok2 = new System.Windows.Forms.TextBox();
            this.VkPijalok1 = new System.Windows.Forms.TextBox();
            this.CenaPijalok3 = new System.Windows.Forms.TextBox();
            this.CenaPijalok2 = new System.Windows.Forms.TextBox();
            this.CenaPijalok1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KolichinaPIjalok3 = new System.Windows.Forms.TextBox();
            this.KolichinaPijalok2 = new System.Windows.Forms.TextBox();
            this.KolichinaPijalok1 = new System.Windows.Forms.TextBox();
            this.desert = new System.Windows.Forms.GroupBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnNarachaj = new System.Windows.Forms.Button();
            this.CenaDesert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.naplata = new System.Windows.Forms.GroupBox();
            this.Vrakjanje = new System.Windows.Forms.TextBox();
            this.Naplateno = new System.Windows.Forms.TextBox();
            this.Vkupno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.golemina.SuspendLayout();
            this.dodatoci.SuspendLayout();
            this.pijalok.SuspendLayout();
            this.desert.SuspendLayout();
            this.naplata.SuspendLayout();
            this.SuspendLayout();
            // 
            // golemina
            // 
            this.golemina.Controls.Add(this.GolemaCena);
            this.golemina.Controls.Add(this.SrednaCena);
            this.golemina.Controls.Add(this.MalaCena);
            this.golemina.Controls.Add(this.golema);
            this.golemina.Controls.Add(this.sredna);
            this.golemina.Controls.Add(this.mala);
            this.golemina.Location = new System.Drawing.Point(12, 12);
            this.golemina.Name = "golemina";
            this.golemina.Size = new System.Drawing.Size(378, 149);
            this.golemina.TabIndex = 0;
            this.golemina.TabStop = false;
            this.golemina.Text = "Големина";
            // 
            // GolemaCena
            // 
            this.GolemaCena.Location = new System.Drawing.Point(209, 115);
            this.GolemaCena.Name = "GolemaCena";
            this.GolemaCena.Size = new System.Drawing.Size(144, 20);
            this.GolemaCena.TabIndex = 5;
            this.GolemaCena.Text = "500";
            // 
            // SrednaCena
            // 
            this.SrednaCena.Location = new System.Drawing.Point(209, 74);
            this.SrednaCena.Name = "SrednaCena";
            this.SrednaCena.Size = new System.Drawing.Size(144, 20);
            this.SrednaCena.TabIndex = 4;
            this.SrednaCena.Text = "300";
            // 
            // MalaCena
            // 
            this.MalaCena.Location = new System.Drawing.Point(209, 29);
            this.MalaCena.Name = "MalaCena";
            this.MalaCena.Size = new System.Drawing.Size(144, 20);
            this.MalaCena.TabIndex = 3;
            this.MalaCena.Text = "200";
            // 
            // golema
            // 
            this.golema.AutoSize = true;
            this.golema.Location = new System.Drawing.Point(7, 115);
            this.golema.Name = "golema";
            this.golema.Size = new System.Drawing.Size(63, 17);
            this.golema.TabIndex = 2;
            this.golema.TabStop = true;
            this.golema.Text = "Голема";
            this.golema.UseVisualStyleBackColor = true;
            this.golema.CheckedChanged += new System.EventHandler(this.golema_CheckedChanged);
            // 
            // sredna
            // 
            this.sredna.AutoSize = true;
            this.sredna.Location = new System.Drawing.Point(7, 74);
            this.sredna.Name = "sredna";
            this.sredna.Size = new System.Drawing.Size(62, 17);
            this.sredna.TabIndex = 1;
            this.sredna.TabStop = true;
            this.sredna.Text = "Средна";
            this.sredna.UseVisualStyleBackColor = true;
            this.sredna.CheckedChanged += new System.EventHandler(this.sredna_CheckedChanged);
            // 
            // mala
            // 
            this.mala.AutoSize = true;
            this.mala.Location = new System.Drawing.Point(7, 29);
            this.mala.Name = "mala";
            this.mala.Size = new System.Drawing.Size(52, 17);
            this.mala.TabIndex = 0;
            this.mala.TabStop = true;
            this.mala.Text = "Мала";
            this.mala.UseVisualStyleBackColor = true;
            this.mala.CheckedChanged += new System.EventHandler(this.mala_CheckedChanged);
            // 
            // dodatoci
            // 
            this.dodatoci.Controls.Add(this.Dodatok3);
            this.dodatoci.Controls.Add(this.Dodatok2);
            this.dodatoci.Controls.Add(this.Dodatok1);
            this.dodatoci.Controls.Add(this.kechap);
            this.dodatoci.Controls.Add(this.sirenje);
            this.dodatoci.Controls.Add(this.feferonki);
            this.dodatoci.Location = new System.Drawing.Point(428, 12);
            this.dodatoci.Name = "dodatoci";
            this.dodatoci.Size = new System.Drawing.Size(360, 149);
            this.dodatoci.TabIndex = 1;
            this.dodatoci.TabStop = false;
            this.dodatoci.Text = "Додатоци";
            // 
            // Dodatok3
            // 
            this.Dodatok3.Location = new System.Drawing.Point(206, 114);
            this.Dodatok3.Name = "Dodatok3";
            this.Dodatok3.Size = new System.Drawing.Size(132, 20);
            this.Dodatok3.TabIndex = 8;
            this.Dodatok3.Text = "20";
            // 
            // Dodatok2
            // 
            this.Dodatok2.Location = new System.Drawing.Point(206, 72);
            this.Dodatok2.Name = "Dodatok2";
            this.Dodatok2.Size = new System.Drawing.Size(132, 20);
            this.Dodatok2.TabIndex = 7;
            this.Dodatok2.Text = "30";
            // 
            // Dodatok1
            // 
            this.Dodatok1.Location = new System.Drawing.Point(206, 26);
            this.Dodatok1.Name = "Dodatok1";
            this.Dodatok1.Size = new System.Drawing.Size(132, 20);
            this.Dodatok1.TabIndex = 6;
            this.Dodatok1.Text = "40";
            // 
            // kechap
            // 
            this.kechap.AutoSize = true;
            this.kechap.Location = new System.Drawing.Point(7, 115);
            this.kechap.Name = "kechap";
            this.kechap.Size = new System.Drawing.Size(56, 17);
            this.kechap.TabIndex = 2;
            this.kechap.Text = "Кечап";
            this.kechap.UseVisualStyleBackColor = true;
            this.kechap.CheckedChanged += new System.EventHandler(this.kechap_CheckedChanged);
            // 
            // sirenje
            // 
            this.sirenje.AutoSize = true;
            this.sirenje.Location = new System.Drawing.Point(7, 74);
            this.sirenje.Name = "sirenje";
            this.sirenje.Size = new System.Drawing.Size(105, 17);
            this.sirenje.TabIndex = 1;
            this.sirenje.Text = "Екстра сирење";
            this.sirenje.UseVisualStyleBackColor = true;
            this.sirenje.CheckedChanged += new System.EventHandler(this.sirenje_CheckedChanged);
            // 
            // feferonki
            // 
            this.feferonki.AutoSize = true;
            this.feferonki.Location = new System.Drawing.Point(7, 29);
            this.feferonki.Name = "feferonki";
            this.feferonki.Size = new System.Drawing.Size(87, 17);
            this.feferonki.TabIndex = 0;
            this.feferonki.Text = "Феферонки";
            this.feferonki.UseVisualStyleBackColor = true;
            this.feferonki.CheckedChanged += new System.EventHandler(this.feferonki_CheckedChanged);
            // 
            // pijalok
            // 
            this.pijalok.Controls.Add(this.VkPijalok3);
            this.pijalok.Controls.Add(this.VkPijalok2);
            this.pijalok.Controls.Add(this.VkPijalok1);
            this.pijalok.Controls.Add(this.CenaPijalok3);
            this.pijalok.Controls.Add(this.CenaPijalok2);
            this.pijalok.Controls.Add(this.CenaPijalok1);
            this.pijalok.Controls.Add(this.label6);
            this.pijalok.Controls.Add(this.label5);
            this.pijalok.Controls.Add(this.label4);
            this.pijalok.Controls.Add(this.label3);
            this.pijalok.Controls.Add(this.label2);
            this.pijalok.Controls.Add(this.label1);
            this.pijalok.Controls.Add(this.KolichinaPIjalok3);
            this.pijalok.Controls.Add(this.KolichinaPijalok2);
            this.pijalok.Controls.Add(this.KolichinaPijalok1);
            this.pijalok.Location = new System.Drawing.Point(12, 167);
            this.pijalok.Name = "pijalok";
            this.pijalok.Size = new System.Drawing.Size(776, 133);
            this.pijalok.TabIndex = 2;
            this.pijalok.TabStop = false;
            this.pijalok.Text = "Пијалок";
            // 
            // VkPijalok3
            // 
            this.VkPijalok3.Enabled = false;
            this.VkPijalok3.Location = new System.Drawing.Point(543, 102);
            this.VkPijalok3.Name = "VkPijalok3";
            this.VkPijalok3.Size = new System.Drawing.Size(100, 20);
            this.VkPijalok3.TabIndex = 20;
            // 
            // VkPijalok2
            // 
            this.VkPijalok2.Enabled = false;
            this.VkPijalok2.Location = new System.Drawing.Point(543, 67);
            this.VkPijalok2.Name = "VkPijalok2";
            this.VkPijalok2.Size = new System.Drawing.Size(100, 20);
            this.VkPijalok2.TabIndex = 19;
            // 
            // VkPijalok1
            // 
            this.VkPijalok1.Enabled = false;
            this.VkPijalok1.Location = new System.Drawing.Point(543, 26);
            this.VkPijalok1.Name = "VkPijalok1";
            this.VkPijalok1.Size = new System.Drawing.Size(100, 20);
            this.VkPijalok1.TabIndex = 18;
            // 
            // CenaPijalok3
            // 
            this.CenaPijalok3.Location = new System.Drawing.Point(385, 102);
            this.CenaPijalok3.Name = "CenaPijalok3";
            this.CenaPijalok3.Size = new System.Drawing.Size(100, 20);
            this.CenaPijalok3.TabIndex = 17;
            this.CenaPijalok3.Text = "80";
            // 
            // CenaPijalok2
            // 
            this.CenaPijalok2.Location = new System.Drawing.Point(385, 67);
            this.CenaPijalok2.Name = "CenaPijalok2";
            this.CenaPijalok2.Size = new System.Drawing.Size(100, 20);
            this.CenaPijalok2.TabIndex = 16;
            this.CenaPijalok2.Text = "70";
            // 
            // CenaPijalok1
            // 
            this.CenaPijalok1.Location = new System.Drawing.Point(385, 26);
            this.CenaPijalok1.Name = "CenaPijalok1";
            this.CenaPijalok1.Size = new System.Drawing.Size(100, 20);
            this.CenaPijalok1.TabIndex = 15;
            this.CenaPijalok1.Text = "60";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Вкупно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сок од јаболко / портокал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Кока Кола/ Фанта / Спрајт";
            // 
            // KolichinaPIjalok3
            // 
            this.KolichinaPIjalok3.Location = new System.Drawing.Point(221, 105);
            this.KolichinaPIjalok3.Name = "KolichinaPIjalok3";
            this.KolichinaPIjalok3.Size = new System.Drawing.Size(100, 20);
            this.KolichinaPIjalok3.TabIndex = 8;
            this.KolichinaPIjalok3.Text = "0";
            this.KolichinaPIjalok3.TextChanged += new System.EventHandler(this.KolichinaPIjalok3_TextChanged);
            // 
            // KolichinaPijalok2
            // 
            this.KolichinaPijalok2.Location = new System.Drawing.Point(221, 70);
            this.KolichinaPijalok2.Name = "KolichinaPijalok2";
            this.KolichinaPijalok2.Size = new System.Drawing.Size(100, 20);
            this.KolichinaPijalok2.TabIndex = 7;
            this.KolichinaPijalok2.Text = "0";
            this.KolichinaPijalok2.TextChanged += new System.EventHandler(this.KolichinaPijalok2_TextChanged);
            // 
            // KolichinaPijalok1
            // 
            this.KolichinaPijalok1.Location = new System.Drawing.Point(221, 29);
            this.KolichinaPijalok1.Name = "KolichinaPijalok1";
            this.KolichinaPijalok1.Size = new System.Drawing.Size(100, 20);
            this.KolichinaPijalok1.TabIndex = 6;
            this.KolichinaPijalok1.Text = "0";
            this.KolichinaPijalok1.TextChanged += new System.EventHandler(this.KolichinaPijalok1_TextChanged);
            // 
            // desert
            // 
            this.desert.Controls.Add(this.btnOtkazi);
            this.desert.Controls.Add(this.btnNarachaj);
            this.desert.Controls.Add(this.CenaDesert);
            this.desert.Controls.Add(this.label7);
            this.desert.Controls.Add(this.listBox1);
            this.desert.Location = new System.Drawing.Point(12, 306);
            this.desert.Name = "desert";
            this.desert.Size = new System.Drawing.Size(378, 132);
            this.desert.TabIndex = 3;
            this.desert.TabStop = false;
            this.desert.Text = "Десерт";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(221, 103);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 23);
            this.btnOtkazi.TabIndex = 4;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnNarachaj
            // 
            this.btnNarachaj.Location = new System.Drawing.Point(221, 69);
            this.btnNarachaj.Name = "btnNarachaj";
            this.btnNarachaj.Size = new System.Drawing.Size(100, 23);
            this.btnNarachaj.TabIndex = 3;
            this.btnNarachaj.Text = "Нарачај";
            this.btnNarachaj.UseVisualStyleBackColor = true;
            this.btnNarachaj.Click += new System.EventHandler(this.btnNarachaj_Click);
            // 
            // CenaDesert
            // 
            this.CenaDesert.Location = new System.Drawing.Point(221, 36);
            this.CenaDesert.Name = "CenaDesert";
            this.CenaDesert.Size = new System.Drawing.Size(132, 20);
            this.CenaDesert.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цена на десерт:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.listBox1.Location = new System.Drawing.Point(7, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // naplata
            // 
            this.naplata.Controls.Add(this.Vrakjanje);
            this.naplata.Controls.Add(this.Naplateno);
            this.naplata.Controls.Add(this.Vkupno);
            this.naplata.Controls.Add(this.label10);
            this.naplata.Controls.Add(this.label9);
            this.naplata.Controls.Add(this.label8);
            this.naplata.Location = new System.Drawing.Point(428, 306);
            this.naplata.Name = "naplata";
            this.naplata.Size = new System.Drawing.Size(360, 132);
            this.naplata.TabIndex = 4;
            this.naplata.TabStop = false;
            this.naplata.Text = "Наплата";
            // 
            // Vrakjanje
            // 
            this.Vrakjanje.Location = new System.Drawing.Point(206, 103);
            this.Vrakjanje.Name = "Vrakjanje";
            this.Vrakjanje.Size = new System.Drawing.Size(132, 20);
            this.Vrakjanje.TabIndex = 10;
            this.Vrakjanje.Text = "0";
            // 
            // Naplateno
            // 
            this.Naplateno.Location = new System.Drawing.Point(206, 69);
            this.Naplateno.Name = "Naplateno";
            this.Naplateno.Size = new System.Drawing.Size(132, 20);
            this.Naplateno.TabIndex = 9;
            this.Naplateno.Text = "0";
            this.Naplateno.TextChanged += new System.EventHandler(this.Naplateno_TextChanged);
            // 
            // Vkupno
            // 
            this.Vkupno.Enabled = false;
            this.Vkupno.Location = new System.Drawing.Point(206, 35);
            this.Vkupno.Name = "Vkupno";
            this.Vkupno.Size = new System.Drawing.Size(132, 20);
            this.Vkupno.TabIndex = 8;
            this.Vkupno.Text = "200";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "За враќање:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Наплатено:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Вкупно за плаќање:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naplata);
            this.Controls.Add(this.desert);
            this.Controls.Add(this.pijalok);
            this.Controls.Add(this.dodatoci);
            this.Controls.Add(this.golemina);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.golemina.ResumeLayout(false);
            this.golemina.PerformLayout();
            this.dodatoci.ResumeLayout(false);
            this.dodatoci.PerformLayout();
            this.pijalok.ResumeLayout(false);
            this.pijalok.PerformLayout();
            this.desert.ResumeLayout(false);
            this.desert.PerformLayout();
            this.naplata.ResumeLayout(false);
            this.naplata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox golemina;
        private System.Windows.Forms.GroupBox dodatoci;
        private System.Windows.Forms.GroupBox pijalok;
        private System.Windows.Forms.GroupBox desert;
        private System.Windows.Forms.GroupBox naplata;
        private System.Windows.Forms.RadioButton golema;
        private System.Windows.Forms.RadioButton sredna;
        private System.Windows.Forms.RadioButton mala;
        private System.Windows.Forms.CheckBox kechap;
        private System.Windows.Forms.CheckBox sirenje;
        private System.Windows.Forms.CheckBox feferonki;
        private System.Windows.Forms.TextBox GolemaCena;
        private System.Windows.Forms.TextBox SrednaCena;
        private System.Windows.Forms.TextBox MalaCena;
        private System.Windows.Forms.TextBox Dodatok3;
        private System.Windows.Forms.TextBox Dodatok2;
        private System.Windows.Forms.TextBox Dodatok1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KolichinaPIjalok3;
        private System.Windows.Forms.TextBox KolichinaPijalok2;
        private System.Windows.Forms.TextBox KolichinaPijalok1;
        private System.Windows.Forms.TextBox VkPijalok3;
        private System.Windows.Forms.TextBox VkPijalok2;
        private System.Windows.Forms.TextBox VkPijalok1;
        private System.Windows.Forms.TextBox CenaPijalok3;
        private System.Windows.Forms.TextBox CenaPijalok2;
        private System.Windows.Forms.TextBox CenaPijalok1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnNarachaj;
        private System.Windows.Forms.TextBox CenaDesert;
        private System.Windows.Forms.TextBox Vrakjanje;
        private System.Windows.Forms.TextBox Naplateno;
        private System.Windows.Forms.TextBox Vkupno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

