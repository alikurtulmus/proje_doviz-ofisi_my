namespace proje_doviz_ofisi_my
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbles = new System.Windows.Forms.Label();
            this.lblea = new System.Windows.Forms.Label();
            this.lblds = new System.Windows.Forms.Label();
            this.lblda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsatis2 = new System.Windows.Forms.Button();
            this.btnsatis = new System.Windows.Forms.Button();
            this.txtkalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.txtkur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnda = new System.Windows.Forms.Button();
            this.btnds = new System.Windows.Forms.Button();
            this.btnea = new System.Windows.Forms.Button();
            this.btnes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar Satış:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro Alış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Satış:";
            // 
            // lbles
            // 
            this.lbles.AutoSize = true;
            this.lbles.Location = new System.Drawing.Point(141, 183);
            this.lbles.Name = "lbles";
            this.lbles.Size = new System.Drawing.Size(29, 20);
            this.lbles.TabIndex = 7;
            this.lbles.Text = "00";
            // 
            // lblea
            // 
            this.lblea.AutoSize = true;
            this.lblea.Location = new System.Drawing.Point(141, 139);
            this.lblea.Name = "lblea";
            this.lblea.Size = new System.Drawing.Size(29, 20);
            this.lblea.TabIndex = 6;
            this.lblea.Text = "00";
            // 
            // lblds
            // 
            this.lblds.AutoSize = true;
            this.lblds.Location = new System.Drawing.Point(141, 95);
            this.lblds.Name = "lblds";
            this.lblds.Size = new System.Drawing.Size(29, 20);
            this.lblds.TabIndex = 5;
            this.lblds.Text = "00";
            // 
            // lblda
            // 
            this.lblda.AutoSize = true;
            this.lblda.Location = new System.Drawing.Point(141, 51);
            this.lblda.Name = "lblda";
            this.lblda.Size = new System.Drawing.Size(29, 20);
            this.lblda.TabIndex = 4;
            this.lblda.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsatis2);
            this.groupBox1.Controls.Add(this.btnsatis);
            this.groupBox1.Controls.Add(this.txtkalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtmiktar);
            this.groupBox1.Controls.Add(this.txtkur);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(459, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnsatis2
            // 
            this.btnsatis2.Location = new System.Drawing.Point(260, 80);
            this.btnsatis2.Name = "btnsatis2";
            this.btnsatis2.Size = new System.Drawing.Size(114, 54);
            this.btnsatis2.TabIndex = 11;
            this.btnsatis2.Text = "Satış Yap-Tutar";
            this.btnsatis2.UseVisualStyleBackColor = true;
            this.btnsatis2.Click += new System.EventHandler(this.btnsatis2_Click);
            // 
            // btnsatis
            // 
            this.btnsatis.Location = new System.Drawing.Point(260, 25);
            this.btnsatis.Name = "btnsatis";
            this.btnsatis.Size = new System.Drawing.Size(114, 49);
            this.btnsatis.TabIndex = 10;
            this.btnsatis.Text = "Satış Yap-Miktar";
            this.btnsatis.UseVisualStyleBackColor = true;
            this.btnsatis.Click += new System.EventHandler(this.btnsatis_Click);
            // 
            // txtkalan
            // 
            this.txtkalan.Location = new System.Drawing.Point(96, 121);
            this.txtkalan.Name = "txtkalan";
            this.txtkalan.Size = new System.Drawing.Size(158, 26);
            this.txtkalan.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kalan:";
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(96, 89);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(158, 26);
            this.txttutar.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tutar:";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(96, 57);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(158, 26);
            this.txtmiktar.TabIndex = 3;
            // 
            // txtkur
            // 
            this.txtkur.Location = new System.Drawing.Point(96, 25);
            this.txtkur.Name = "txtkur";
            this.txtkur.Size = new System.Drawing.Size(158, 26);
            this.txtkur.TabIndex = 2;
            this.txtkur.TextChanged += new System.EventHandler(this.txtkur_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Miktar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kur:";
            // 
            // btnda
            // 
            this.btnda.Location = new System.Drawing.Point(282, 43);
            this.btnda.Name = "btnda";
            this.btnda.Size = new System.Drawing.Size(114, 37);
            this.btnda.TabIndex = 9;
            this.btnda.Text = "Dolar Al";
            this.btnda.UseVisualStyleBackColor = true;
            this.btnda.Click += new System.EventHandler(this.btnda_Click);
            // 
            // btnds
            // 
            this.btnds.Location = new System.Drawing.Point(282, 87);
            this.btnds.Name = "btnds";
            this.btnds.Size = new System.Drawing.Size(114, 37);
            this.btnds.TabIndex = 10;
            this.btnds.Text = "Dolar Sat";
            this.btnds.UseVisualStyleBackColor = true;
            this.btnds.Click += new System.EventHandler(this.btnds_Click);
            // 
            // btnea
            // 
            this.btnea.Location = new System.Drawing.Point(282, 131);
            this.btnea.Name = "btnea";
            this.btnea.Size = new System.Drawing.Size(114, 37);
            this.btnea.TabIndex = 11;
            this.btnea.Text = "Euro Al";
            this.btnea.UseVisualStyleBackColor = true;
            this.btnea.Click += new System.EventHandler(this.btnea_Click);
            // 
            // btnes
            // 
            this.btnes.Location = new System.Drawing.Point(282, 175);
            this.btnes.Name = "btnes";
            this.btnes.Size = new System.Drawing.Size(114, 37);
            this.btnes.TabIndex = 12;
            this.btnes.Text = "Euro Sat";
            this.btnes.UseVisualStyleBackColor = true;
            this.btnes.Click += new System.EventHandler(this.btnes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 515);
            this.Controls.Add(this.btnes);
            this.Controls.Add(this.btnea);
            this.Controls.Add(this.btnds);
            this.Controls.Add(this.btnda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbles);
            this.Controls.Add(this.lblea);
            this.Controls.Add(this.lblds);
            this.Controls.Add(this.lblda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbles;
        private System.Windows.Forms.Label lblea;
        private System.Windows.Forms.Label lblds;
        private System.Windows.Forms.Label lblda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsatis;
        private System.Windows.Forms.TextBox txtkalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.TextBox txtkur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnda;
        private System.Windows.Forms.Button btnds;
        private System.Windows.Forms.Button btnea;
        private System.Windows.Forms.Button btnes;
        private System.Windows.Forms.Button btnsatis2;
    }
}

