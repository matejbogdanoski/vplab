namespace VPLabTimer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIgrac = new System.Windows.Forms.TextBox();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtZnak = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.pbPoeni = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.pbVreme = new System.Windows.Forms.ProgressBar();
            this.btnPogodi = new System.Windows.Forms.Button();
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.btnNajdobriIgraci = new System.Windows.Forms.Button();
            this.btnIskluci = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Играч: ";
            // 
            // txtIgrac
            // 
            this.txtIgrac.Location = new System.Drawing.Point(105, 43);
            this.txtIgrac.Name = "txtIgrac";
            this.txtIgrac.Size = new System.Drawing.Size(125, 26);
            this.txtIgrac.TabIndex = 1;
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(40, 110);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.ReadOnly = true;
            this.txtOp1.Size = new System.Drawing.Size(106, 26);
            this.txtOp1.TabIndex = 2;
            // 
            // txtZnak
            // 
            this.txtZnak.Location = new System.Drawing.Point(193, 110);
            this.txtZnak.Name = "txtZnak";
            this.txtZnak.ReadOnly = true;
            this.txtZnak.Size = new System.Drawing.Size(46, 26);
            this.txtZnak.TabIndex = 3;
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(282, 110);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.ReadOnly = true;
            this.txtOp2.Size = new System.Drawing.Size(106, 26);
            this.txtOp2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(505, 110);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(106, 26);
            this.txtGuess.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поени:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(136, 188);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(0, 20);
            this.lblPoeni.TabIndex = 8;
            // 
            // pbPoeni
            // 
            this.pbPoeni.Location = new System.Drawing.Point(40, 245);
            this.pbPoeni.Maximum = 50;
            this.pbPoeni.Name = "pbPoeni";
            this.pbPoeni.Size = new System.Drawing.Size(766, 38);
            this.pbPoeni.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Преостанато време:";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(215, 329);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(49, 20);
            this.lblVreme.TabIndex = 11;
            this.lblVreme.Text = "01:00";
            // 
            // pbVreme
            // 
            this.pbVreme.Location = new System.Drawing.Point(40, 386);
            this.pbVreme.Maximum = 60;
            this.pbVreme.Name = "pbVreme";
            this.pbVreme.Size = new System.Drawing.Size(766, 38);
            this.pbVreme.TabIndex = 12;
            // 
            // btnPogodi
            // 
            this.btnPogodi.Location = new System.Drawing.Point(670, 106);
            this.btnPogodi.Name = "btnPogodi";
            this.btnPogodi.Size = new System.Drawing.Size(113, 34);
            this.btnPogodi.TabIndex = 13;
            this.btnPogodi.Text = "Погоди";
            this.btnPogodi.UseVisualStyleBackColor = true;
            this.btnPogodi.Click += new System.EventHandler(this.btnPogodi_Click);
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Location = new System.Drawing.Point(40, 451);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(131, 36);
            this.btnNovaIgra.TabIndex = 14;
            this.btnNovaIgra.Text = "Нова игра";
            this.btnNovaIgra.UseVisualStyleBackColor = true;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnNajdobriIgraci
            // 
            this.btnNajdobriIgraci.Location = new System.Drawing.Point(341, 451);
            this.btnNajdobriIgraci.Name = "btnNajdobriIgraci";
            this.btnNajdobriIgraci.Size = new System.Drawing.Size(192, 36);
            this.btnNajdobriIgraci.TabIndex = 15;
            this.btnNajdobriIgraci.Text = "Најдобри играчи";
            this.btnNajdobriIgraci.UseVisualStyleBackColor = true;
            this.btnNajdobriIgraci.Click += new System.EventHandler(this.btnNajdobriIgraci_Click);
            // 
            // btnIskluci
            // 
            this.btnIskluci.Location = new System.Drawing.Point(675, 451);
            this.btnIskluci.Name = "btnIskluci";
            this.btnIskluci.Size = new System.Drawing.Size(131, 36);
            this.btnIskluci.TabIndex = 16;
            this.btnIskluci.Text = "Исклучи";
            this.btnIskluci.UseVisualStyleBackColor = true;
            this.btnIskluci.Click += new System.EventHandler(this.btnIskluci_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPogodi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 516);
            this.Controls.Add(this.btnIskluci);
            this.Controls.Add(this.btnNajdobriIgraci);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.btnPogodi);
            this.Controls.Add(this.pbVreme);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbPoeni);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtZnak);
            this.Controls.Add(this.txtOp1);
            this.Controls.Add(this.txtIgrac);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIgrac;
        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtZnak;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.ProgressBar pbPoeni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.ProgressBar pbVreme;
        private System.Windows.Forms.Button btnPogodi;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Button btnNajdobriIgraci;
        private System.Windows.Forms.Button btnIskluci;
        private System.Windows.Forms.Timer timer1;
    }
}

