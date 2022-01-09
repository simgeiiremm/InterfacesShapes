namespace InterfacesShapes
{
    partial class form1
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
            this.rbDaire = new System.Windows.Forms.RadioButton();
            this.rbDortgen = new System.Windows.Forms.RadioButton();
            this.rbDikUcgen = new System.Windows.Forms.RadioButton();
            this.pDaire = new System.Windows.Forms.Panel();
            this.tbYaricap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pDiger = new System.Windows.Forms.Panel();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGenislik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pHesap = new System.Windows.Forms.Panel();
            this.ddlIslem = new System.Windows.Forms.ComboBox();
            this.bHesapla = new System.Windows.Forms.Button();
            this.cbPi = new System.Windows.Forms.CheckBox();
            this.lSonuc = new System.Windows.Forms.Label();
            this.pDaire.SuspendLayout();
            this.pDiger.SuspendLayout();
            this.pHesap.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDaire
            // 
            this.rbDaire.AutoSize = true;
            this.rbDaire.Checked = true;
            this.rbDaire.Location = new System.Drawing.Point(37, 24);
            this.rbDaire.Name = "rbDaire";
            this.rbDaire.Size = new System.Drawing.Size(50, 17);
            this.rbDaire.TabIndex = 0;
            this.rbDaire.TabStop = true;
            this.rbDaire.Text = "Daire";
            this.rbDaire.UseVisualStyleBackColor = true;
            this.rbDaire.CheckedChanged += new System.EventHandler(this.rbDaire_CheckedChanged);
            // 
            // rbDortgen
            // 
            this.rbDortgen.AutoSize = true;
            this.rbDortgen.Location = new System.Drawing.Point(119, 24);
            this.rbDortgen.Name = "rbDortgen";
            this.rbDortgen.Size = new System.Drawing.Size(63, 17);
            this.rbDortgen.TabIndex = 1;
            this.rbDortgen.Text = "Dörtgen";
            this.rbDortgen.UseVisualStyleBackColor = true;
            this.rbDortgen.CheckedChanged += new System.EventHandler(this.rbDortgen_CheckedChanged);
            // 
            // rbDikUcgen
            // 
            this.rbDikUcgen.AutoSize = true;
            this.rbDikUcgen.Location = new System.Drawing.Point(210, 24);
            this.rbDikUcgen.Name = "rbDikUcgen";
            this.rbDikUcgen.Size = new System.Drawing.Size(76, 17);
            this.rbDikUcgen.TabIndex = 2;
            this.rbDikUcgen.Text = "Dik Üçgen";
            this.rbDikUcgen.UseVisualStyleBackColor = true;
            this.rbDikUcgen.CheckedChanged += new System.EventHandler(this.rbDikUcgen_CheckedChanged);
            // 
            // pDaire
            // 
            this.pDaire.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pDaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pDaire.Controls.Add(this.cbPi);
            this.pDaire.Controls.Add(this.tbYaricap);
            this.pDaire.Controls.Add(this.label1);
            this.pDaire.Location = new System.Drawing.Point(37, 66);
            this.pDaire.Name = "pDaire";
            this.pDaire.Size = new System.Drawing.Size(272, 75);
            this.pDaire.TabIndex = 3;
            // 
            // tbYaricap
            // 
            this.tbYaricap.Location = new System.Drawing.Point(75, 14);
            this.tbYaricap.Name = "tbYaricap";
            this.tbYaricap.Size = new System.Drawing.Size(100, 20);
            this.tbYaricap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarıçap:";
            // 
            // pDiger
            // 
            this.pDiger.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pDiger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pDiger.Controls.Add(this.tbYukseklik);
            this.pDiger.Controls.Add(this.label3);
            this.pDiger.Controls.Add(this.tbGenislik);
            this.pDiger.Controls.Add(this.label2);
            this.pDiger.Location = new System.Drawing.Point(37, 147);
            this.pDiger.Name = "pDiger";
            this.pDiger.Size = new System.Drawing.Size(272, 86);
            this.pDiger.TabIndex = 4;
            this.pDiger.Visible = false;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(75, 46);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(100, 20);
            this.tbYukseklik.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yükseklik:";
            // 
            // tbGenislik
            // 
            this.tbGenislik.Location = new System.Drawing.Point(75, 14);
            this.tbGenislik.Name = "tbGenislik";
            this.tbGenislik.Size = new System.Drawing.Size(100, 20);
            this.tbGenislik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genişlik:";
            // 
            // pHesap
            // 
            this.pHesap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pHesap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHesap.Controls.Add(this.lSonuc);
            this.pHesap.Controls.Add(this.ddlIslem);
            this.pHesap.Controls.Add(this.bHesapla);
            this.pHesap.Location = new System.Drawing.Point(37, 239);
            this.pHesap.Name = "pHesap";
            this.pHesap.Size = new System.Drawing.Size(272, 87);
            this.pHesap.TabIndex = 7;
            // 
            // ddlIslem
            // 
            this.ddlIslem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ddlIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ddlIslem.FormattingEnabled = true;
            this.ddlIslem.Location = new System.Drawing.Point(11, 15);
            this.ddlIslem.Name = "ddlIslem";
            this.ddlIslem.Size = new System.Drawing.Size(166, 24);
            this.ddlIslem.TabIndex = 8;
            // 
            // bHesapla
            // 
            this.bHesapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bHesapla.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesapla.Location = new System.Drawing.Point(184, 11);
            this.bHesapla.Name = "bHesapla";
            this.bHesapla.Size = new System.Drawing.Size(75, 31);
            this.bHesapla.TabIndex = 7;
            this.bHesapla.Text = "Hesapla";
            this.bHesapla.UseVisualStyleBackColor = false;
            this.bHesapla.Click += new System.EventHandler(this.bHesapla_Click);
            // 
            // cbPi
            // 
            this.cbPi.AutoSize = true;
            this.cbPi.Location = new System.Drawing.Point(75, 40);
            this.cbPi.Name = "cbPi";
            this.cbPi.Size = new System.Drawing.Size(67, 17);
            this.cbPi.TabIndex = 2;
            this.cbPi.Text = "Pi 3 mü?";
            this.cbPi.UseVisualStyleBackColor = true;
            // 
            // lSonuc
            // 
            this.lSonuc.AutoEllipsis = true;
            this.lSonuc.AutoSize = true;
            this.lSonuc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lSonuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonuc.ForeColor = System.Drawing.Color.Brown;
            this.lSonuc.Location = new System.Drawing.Point(12, 51);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(54, 19);
            this.lSonuc.TabIndex = 9;
            this.lSonuc.Text = "Sonuç:";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 338);
            this.Controls.Add(this.pHesap);
            this.Controls.Add(this.pDiger);
            this.Controls.Add(this.pDaire);
            this.Controls.Add(this.rbDikUcgen);
            this.Controls.Add(this.rbDortgen);
            this.Controls.Add(this.rbDaire);
            this.Name = "form1";
            this.Text = "Shapes";
            this.Load += new System.EventHandler(this.form1_Load);
            this.pDaire.ResumeLayout(false);
            this.pDaire.PerformLayout();
            this.pDiger.ResumeLayout(false);
            this.pDiger.PerformLayout();
            this.pHesap.ResumeLayout(false);
            this.pHesap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDaire;
        private System.Windows.Forms.RadioButton rbDortgen;
        private System.Windows.Forms.RadioButton rbDikUcgen;
        private System.Windows.Forms.Panel pDaire;
        private System.Windows.Forms.TextBox tbYaricap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pDiger;
        private System.Windows.Forms.TextBox tbYukseklik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGenislik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pHesap;
        private System.Windows.Forms.ComboBox ddlIslem;
        private System.Windows.Forms.Button bHesapla;
        private System.Windows.Forms.CheckBox cbPi;
        private System.Windows.Forms.Label lSonuc;
    }
}

