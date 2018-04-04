namespace VPL2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGolema = new System.Windows.Forms.TextBox();
            this.txtSredna = new System.Windows.Forms.TextBox();
            this.txtMala = new System.Windows.Forms.TextBox();
            this.rbGolema = new System.Windows.Forms.RadioButton();
            this.rbSredna = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKecap = new System.Windows.Forms.TextBox();
            this.txtSirenje = new System.Windows.Forms.TextBox();
            this.txtFeferonki = new System.Windows.Forms.TextBox();
            this.cbKecap = new System.Windows.Forms.CheckBox();
            this.cbSirenje = new System.Windows.Forms.CheckBox();
            this.cbFeferonki = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPivoTotal = new System.Windows.Forms.TextBox();
            this.txtSokTotal = new System.Windows.Forms.TextBox();
            this.txtColaTotal = new System.Windows.Forms.TextBox();
            this.txtPivoCena = new System.Windows.Forms.TextBox();
            this.txtSokCena = new System.Windows.Forms.TextBox();
            this.txtColaCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPivoKol = new System.Windows.Forms.TextBox();
            this.txtSokKol = new System.Windows.Forms.TextBox();
            this.txtColaKol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtKusur = new System.Windows.Forms.TextBox();
            this.txtNaplateno = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnNaracaj = new System.Windows.Forms.Button();
            this.txtCenaDesert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstDesert = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGolema);
            this.groupBox1.Controls.Add(this.txtSredna);
            this.groupBox1.Controls.Add(this.txtMala);
            this.groupBox1.Controls.Add(this.rbGolema);
            this.groupBox1.Controls.Add(this.rbSredna);
            this.groupBox1.Controls.Add(this.rbMala);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // txtGolema
            // 
            this.txtGolema.Location = new System.Drawing.Point(187, 117);
            this.txtGolema.Name = "txtGolema";
            this.txtGolema.Size = new System.Drawing.Size(100, 26);
            this.txtGolema.TabIndex = 5;
            this.txtGolema.TextChanged += new System.EventHandler(this.txtGolema_TextChanged);
            // 
            // txtSredna
            // 
            this.txtSredna.Location = new System.Drawing.Point(187, 69);
            this.txtSredna.Name = "txtSredna";
            this.txtSredna.Size = new System.Drawing.Size(100, 26);
            this.txtSredna.TabIndex = 4;
            this.txtSredna.TextChanged += new System.EventHandler(this.txtSredna_TextChanged);
            // 
            // txtMala
            // 
            this.txtMala.Location = new System.Drawing.Point(187, 24);
            this.txtMala.Name = "txtMala";
            this.txtMala.Size = new System.Drawing.Size(100, 26);
            this.txtMala.TabIndex = 3;
            this.txtMala.TextChanged += new System.EventHandler(this.txtMala_TextChanged);
            // 
            // rbGolema
            // 
            this.rbGolema.AutoSize = true;
            this.rbGolema.Location = new System.Drawing.Point(7, 119);
            this.rbGolema.Name = "rbGolema";
            this.rbGolema.Size = new System.Drawing.Size(91, 24);
            this.rbGolema.TabIndex = 2;
            this.rbGolema.TabStop = true;
            this.rbGolema.Text = "Голема";
            this.rbGolema.UseVisualStyleBackColor = true;
            this.rbGolema.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // rbSredna
            // 
            this.rbSredna.AutoSize = true;
            this.rbSredna.Location = new System.Drawing.Point(7, 71);
            this.rbSredna.Name = "rbSredna";
            this.rbSredna.Size = new System.Drawing.Size(92, 24);
            this.rbSredna.TabIndex = 1;
            this.rbSredna.TabStop = true;
            this.rbSredna.Text = "Средна";
            this.rbSredna.UseVisualStyleBackColor = true;
            this.rbSredna.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Location = new System.Drawing.Point(7, 26);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(75, 24);
            this.rbMala.TabIndex = 0;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Мала";
            this.rbMala.UseVisualStyleBackColor = true;
            this.rbMala.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKecap);
            this.groupBox2.Controls.Add(this.txtSirenje);
            this.groupBox2.Controls.Add(this.txtFeferonki);
            this.groupBox2.Controls.Add(this.cbKecap);
            this.groupBox2.Controls.Add(this.cbSirenje);
            this.groupBox2.Controls.Add(this.cbFeferonki);
            this.groupBox2.Location = new System.Drawing.Point(427, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатоци";
            // 
            // txtKecap
            // 
            this.txtKecap.Location = new System.Drawing.Point(203, 115);
            this.txtKecap.Name = "txtKecap";
            this.txtKecap.Size = new System.Drawing.Size(100, 26);
            this.txtKecap.TabIndex = 8;
            this.txtKecap.TextChanged += new System.EventHandler(this.txtKecap_TextChanged);
            // 
            // txtSirenje
            // 
            this.txtSirenje.Location = new System.Drawing.Point(203, 71);
            this.txtSirenje.Name = "txtSirenje";
            this.txtSirenje.Size = new System.Drawing.Size(100, 26);
            this.txtSirenje.TabIndex = 7;
            this.txtSirenje.TextChanged += new System.EventHandler(this.txtSirenje_TextChanged);
            // 
            // txtFeferonki
            // 
            this.txtFeferonki.Location = new System.Drawing.Point(203, 25);
            this.txtFeferonki.Name = "txtFeferonki";
            this.txtFeferonki.Size = new System.Drawing.Size(100, 26);
            this.txtFeferonki.TabIndex = 6;
            this.txtFeferonki.TextChanged += new System.EventHandler(this.txtFeferonki_TextChanged);
            // 
            // cbKecap
            // 
            this.cbKecap.AutoSize = true;
            this.cbKecap.Location = new System.Drawing.Point(7, 117);
            this.cbKecap.Name = "cbKecap";
            this.cbKecap.Size = new System.Drawing.Size(81, 24);
            this.cbKecap.TabIndex = 2;
            this.cbKecap.Text = "Кечап";
            this.cbKecap.UseVisualStyleBackColor = true;
            this.cbKecap.CheckedChanged += new System.EventHandler(this.cbKecap_CheckedChanged);
            // 
            // cbSirenje
            // 
            this.cbSirenje.AutoSize = true;
            this.cbSirenje.Location = new System.Drawing.Point(7, 69);
            this.cbSirenje.Name = "cbSirenje";
            this.cbSirenje.Size = new System.Drawing.Size(151, 24);
            this.cbSirenje.TabIndex = 1;
            this.cbSirenje.Text = "Екстра сирење";
            this.cbSirenje.UseVisualStyleBackColor = true;
            this.cbSirenje.CheckedChanged += new System.EventHandler(this.cbSirenje_CheckedChanged);
            // 
            // cbFeferonki
            // 
            this.cbFeferonki.AutoSize = true;
            this.cbFeferonki.Location = new System.Drawing.Point(7, 24);
            this.cbFeferonki.Name = "cbFeferonki";
            this.cbFeferonki.Size = new System.Drawing.Size(127, 24);
            this.cbFeferonki.TabIndex = 0;
            this.cbFeferonki.Text = "Феферонки";
            this.cbFeferonki.UseVisualStyleBackColor = true;
            this.cbFeferonki.CheckedChanged += new System.EventHandler(this.cbFeferonki_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPivoTotal);
            this.groupBox3.Controls.Add(this.txtSokTotal);
            this.groupBox3.Controls.Add(this.txtColaTotal);
            this.groupBox3.Controls.Add(this.txtPivoCena);
            this.groupBox3.Controls.Add(this.txtSokCena);
            this.groupBox3.Controls.Add(this.txtColaCena);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPivoKol);
            this.groupBox3.Controls.Add(this.txtSokKol);
            this.groupBox3.Controls.Add(this.txtColaKol);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 201);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пијалок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Вкупно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Цена";
            // 
            // txtPivoTotal
            // 
            this.txtPivoTotal.Location = new System.Drawing.Point(581, 133);
            this.txtPivoTotal.Name = "txtPivoTotal";
            this.txtPivoTotal.ReadOnly = true;
            this.txtPivoTotal.Size = new System.Drawing.Size(100, 26);
            this.txtPivoTotal.TabIndex = 18;
            // 
            // txtSokTotal
            // 
            this.txtSokTotal.Location = new System.Drawing.Point(581, 85);
            this.txtSokTotal.Name = "txtSokTotal";
            this.txtSokTotal.ReadOnly = true;
            this.txtSokTotal.Size = new System.Drawing.Size(100, 26);
            this.txtSokTotal.TabIndex = 17;
            // 
            // txtColaTotal
            // 
            this.txtColaTotal.Location = new System.Drawing.Point(581, 43);
            this.txtColaTotal.Name = "txtColaTotal";
            this.txtColaTotal.ReadOnly = true;
            this.txtColaTotal.Size = new System.Drawing.Size(100, 26);
            this.txtColaTotal.TabIndex = 16;
            // 
            // txtPivoCena
            // 
            this.txtPivoCena.Location = new System.Drawing.Point(415, 133);
            this.txtPivoCena.Name = "txtPivoCena";
            this.txtPivoCena.Size = new System.Drawing.Size(100, 26);
            this.txtPivoCena.TabIndex = 15;
            this.txtPivoCena.TextChanged += new System.EventHandler(this.txtPivoCena_TextChanged);
            // 
            // txtSokCena
            // 
            this.txtSokCena.Location = new System.Drawing.Point(415, 85);
            this.txtSokCena.Name = "txtSokCena";
            this.txtSokCena.Size = new System.Drawing.Size(100, 26);
            this.txtSokCena.TabIndex = 14;
            this.txtSokCena.TextChanged += new System.EventHandler(this.txtSokCena_TextChanged);
            // 
            // txtColaCena
            // 
            this.txtColaCena.Location = new System.Drawing.Point(415, 43);
            this.txtColaCena.Name = "txtColaCena";
            this.txtColaCena.Size = new System.Drawing.Size(100, 26);
            this.txtColaCena.TabIndex = 13;
            this.txtColaCena.TextChanged += new System.EventHandler(this.txtColaCena_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количина";
            // 
            // txtPivoKol
            // 
            this.txtPivoKol.Location = new System.Drawing.Point(268, 133);
            this.txtPivoKol.Name = "txtPivoKol";
            this.txtPivoKol.Size = new System.Drawing.Size(100, 26);
            this.txtPivoKol.TabIndex = 11;
            this.txtPivoKol.TextChanged += new System.EventHandler(this.txtPivoKol_TextChanged);
            // 
            // txtSokKol
            // 
            this.txtSokKol.Location = new System.Drawing.Point(268, 85);
            this.txtSokKol.Name = "txtSokKol";
            this.txtSokKol.Size = new System.Drawing.Size(100, 26);
            this.txtSokKol.TabIndex = 10;
            this.txtSokKol.TextChanged += new System.EventHandler(this.txtSokKol_TextChanged);
            // 
            // txtColaKol
            // 
            this.txtColaKol.Location = new System.Drawing.Point(268, 43);
            this.txtColaKol.Name = "txtColaKol";
            this.txtColaKol.Size = new System.Drawing.Size(100, 26);
            this.txtColaKol.TabIndex = 9;
            this.txtColaKol.TextChanged += new System.EventHandler(this.txtColaKol_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко / портокал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока кола / Фанта / Спрајт";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtKusur);
            this.groupBox4.Controls.Add(this.txtNaplateno);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(427, 405);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 186);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Наплата";
            // 
            // txtKusur
            // 
            this.txtKusur.Location = new System.Drawing.Point(192, 121);
            this.txtKusur.Name = "txtKusur";
            this.txtKusur.Size = new System.Drawing.Size(143, 26);
            this.txtKusur.TabIndex = 5;
            this.txtKusur.TextChanged += new System.EventHandler(this.txtKusur_TextChanged);
            // 
            // txtNaplateno
            // 
            this.txtNaplateno.Location = new System.Drawing.Point(192, 79);
            this.txtNaplateno.Name = "txtNaplateno";
            this.txtNaplateno.Size = new System.Drawing.Size(143, 26);
            this.txtNaplateno.TabIndex = 4;
            this.txtNaplateno.TextChanged += new System.EventHandler(this.txtNaplateno_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(192, 36);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(143, 26);
            this.txtTotal.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "За враќање:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Наплатено:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вкупно за плаќање:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOtkazi);
            this.groupBox5.Controls.Add(this.btnNaracaj);
            this.groupBox5.Controls.Add(this.txtCenaDesert);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lstDesert);
            this.groupBox5.Location = new System.Drawing.Point(12, 405);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 186);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Десерт";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(165, 136);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(133, 34);
            this.btnOtkazi.TabIndex = 4;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnNaracaj
            // 
            this.btnNaracaj.Location = new System.Drawing.Point(165, 90);
            this.btnNaracaj.Name = "btnNaracaj";
            this.btnNaracaj.Size = new System.Drawing.Size(133, 40);
            this.btnNaracaj.TabIndex = 3;
            this.btnNaracaj.Text = "Нарачај";
            this.btnNaracaj.UseVisualStyleBackColor = true;
            this.btnNaracaj.Click += new System.EventHandler(this.btnNaracaj_Click);
            // 
            // txtCenaDesert
            // 
            this.txtCenaDesert.Location = new System.Drawing.Point(165, 58);
            this.txtCenaDesert.Name = "txtCenaDesert";
            this.txtCenaDesert.Size = new System.Drawing.Size(133, 26);
            this.txtCenaDesert.TabIndex = 2;
            this.txtCenaDesert.TextChanged += new System.EventHandler(this.txtCenaDesert_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цена на десерт :";
            // 
            // lstDesert
            // 
            this.lstDesert.FormattingEnabled = true;
            this.lstDesert.ItemHeight = 20;
            this.lstDesert.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lstDesert.Location = new System.Drawing.Point(7, 26);
            this.lstDesert.Name = "lstDesert";
            this.lstDesert.Size = new System.Drawing.Size(147, 144);
            this.lstDesert.TabIndex = 0;
            this.lstDesert.SelectedIndexChanged += new System.EventHandler(this.lstDesert_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNaracaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(840, 652);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGolema;
        private System.Windows.Forms.TextBox txtSredna;
        private System.Windows.Forms.TextBox txtMala;
        private System.Windows.Forms.RadioButton rbGolema;
        private System.Windows.Forms.RadioButton rbSredna;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtKecap;
        private System.Windows.Forms.TextBox txtSirenje;
        private System.Windows.Forms.TextBox txtFeferonki;
        private System.Windows.Forms.CheckBox cbKecap;
        private System.Windows.Forms.CheckBox cbSirenje;
        private System.Windows.Forms.CheckBox cbFeferonki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPivoTotal;
        private System.Windows.Forms.TextBox txtSokTotal;
        private System.Windows.Forms.TextBox txtColaTotal;
        private System.Windows.Forms.TextBox txtPivoCena;
        private System.Windows.Forms.TextBox txtSokCena;
        private System.Windows.Forms.TextBox txtColaCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPivoKol;
        private System.Windows.Forms.TextBox txtSokKol;
        private System.Windows.Forms.TextBox txtColaKol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKusur;
        private System.Windows.Forms.TextBox txtNaplateno;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnNaracaj;
        private System.Windows.Forms.TextBox txtCenaDesert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstDesert;
    }
}

