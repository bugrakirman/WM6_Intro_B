namespace Cs.App
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
            this.cmbSilahlar = new System.Windows.Forms.ComboBox();
            this.lblDetay = new System.Windows.Forms.Label();
            this.gbAtesliSilah = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnYenidenDoldur = new System.Windows.Forms.Button();
            this.btnAtesEt = new System.Windows.Forms.Button();
            this.gbYakinSaldiri = new System.Windows.Forms.GroupBox();
            this.btnSaldir = new System.Windows.Forms.Button();
            this.gbFirlatilan = new System.Windows.Forms.GroupBox();
            this.btnFirlat = new System.Windows.Forms.Button();
            this.panelSilah = new System.Windows.Forms.Panel();
            this.gbAtesliSilah.SuspendLayout();
            this.gbYakinSaldiri.SuspendLayout();
            this.gbFirlatilan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silah Seçiniz";
            // 
            // cmbSilahlar
            // 
            this.cmbSilahlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSilahlar.FormattingEnabled = true;
            this.cmbSilahlar.Location = new System.Drawing.Point(117, 12);
            this.cmbSilahlar.Name = "cmbSilahlar";
            this.cmbSilahlar.Size = new System.Drawing.Size(168, 21);
            this.cmbSilahlar.TabIndex = 1;
            this.cmbSilahlar.SelectedIndexChanged += new System.EventHandler(this.cmbSilahlar_SelectedIndexChanged);
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetay.Location = new System.Drawing.Point(12, 62);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(51, 20);
            this.lblDetay.TabIndex = 2;
            this.lblDetay.Text = "label2";
            // 
            // gbAtesliSilah
            // 
            this.gbAtesliSilah.Controls.Add(this.lblDurum);
            this.gbAtesliSilah.Controls.Add(this.btnYenidenDoldur);
            this.gbAtesliSilah.Controls.Add(this.btnAtesEt);
            this.gbAtesliSilah.Location = new System.Drawing.Point(15, 136);
            this.gbAtesliSilah.Name = "gbAtesliSilah";
            this.gbAtesliSilah.Size = new System.Drawing.Size(278, 100);
            this.gbAtesliSilah.TabIndex = 3;
            this.gbAtesliSilah.TabStop = false;
            this.gbAtesliSilah.Text = "Silah Kontrol";
            this.gbAtesliSilah.Visible = false;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(169, 40);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(101, 31);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "label12";
            // 
            // btnYenidenDoldur
            // 
            this.btnYenidenDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenidenDoldur.ForeColor = System.Drawing.Color.Red;
            this.btnYenidenDoldur.Location = new System.Drawing.Point(88, 19);
            this.btnYenidenDoldur.Name = "btnYenidenDoldur";
            this.btnYenidenDoldur.Size = new System.Drawing.Size(75, 75);
            this.btnYenidenDoldur.TabIndex = 1;
            this.btnYenidenDoldur.Text = "Doldur";
            this.btnYenidenDoldur.UseVisualStyleBackColor = true;
            this.btnYenidenDoldur.Click += new System.EventHandler(this.btnYenidenDoldur_Click);
            // 
            // btnAtesEt
            // 
            this.btnAtesEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAtesEt.ForeColor = System.Drawing.Color.Red;
            this.btnAtesEt.Location = new System.Drawing.Point(7, 19);
            this.btnAtesEt.Name = "btnAtesEt";
            this.btnAtesEt.Size = new System.Drawing.Size(75, 75);
            this.btnAtesEt.TabIndex = 0;
            this.btnAtesEt.Text = "Ateş Et";
            this.btnAtesEt.UseVisualStyleBackColor = true;
            this.btnAtesEt.Click += new System.EventHandler(this.btnAtesEt_Click);
            this.btnAtesEt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseDown);
            this.btnAtesEt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseUp);
            // 
            // gbYakinSaldiri
            // 
            this.gbYakinSaldiri.Controls.Add(this.btnSaldir);
            this.gbYakinSaldiri.Location = new System.Drawing.Point(16, 263);
            this.gbYakinSaldiri.Name = "gbYakinSaldiri";
            this.gbYakinSaldiri.Size = new System.Drawing.Size(278, 100);
            this.gbYakinSaldiri.TabIndex = 4;
            this.gbYakinSaldiri.TabStop = false;
            this.gbYakinSaldiri.Text = "Yakın Saldırı Kontrol";
            this.gbYakinSaldiri.Visible = false;
            // 
            // btnSaldir
            // 
            this.btnSaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaldir.Location = new System.Drawing.Point(6, 19);
            this.btnSaldir.Name = "btnSaldir";
            this.btnSaldir.Size = new System.Drawing.Size(75, 75);
            this.btnSaldir.TabIndex = 1;
            this.btnSaldir.Text = "Saldır";
            this.btnSaldir.UseVisualStyleBackColor = true;
            this.btnSaldir.Click += new System.EventHandler(this.btnSaldir_Click);
            // 
            // gbFirlatilan
            // 
            this.gbFirlatilan.Controls.Add(this.btnFirlat);
            this.gbFirlatilan.Location = new System.Drawing.Point(300, 263);
            this.gbFirlatilan.Name = "gbFirlatilan";
            this.gbFirlatilan.Size = new System.Drawing.Size(321, 100);
            this.gbFirlatilan.TabIndex = 4;
            this.gbFirlatilan.TabStop = false;
            this.gbFirlatilan.Text = "Fırlatılan Silah Kontrol";
            this.gbFirlatilan.Visible = false;
            // 
            // btnFirlat
            // 
            this.btnFirlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirlat.Location = new System.Drawing.Point(6, 19);
            this.btnFirlat.Name = "btnFirlat";
            this.btnFirlat.Size = new System.Drawing.Size(75, 75);
            this.btnFirlat.TabIndex = 2;
            this.btnFirlat.Text = "Fırlat";
            this.btnFirlat.UseVisualStyleBackColor = true;
            this.btnFirlat.Click += new System.EventHandler(this.btnFirlat_Click);
            // 
            // panelSilah
            // 
            this.panelSilah.Location = new System.Drawing.Point(299, 13);
            this.panelSilah.Name = "panelSilah";
            this.panelSilah.Size = new System.Drawing.Size(322, 224);
            this.panelSilah.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 386);
            this.Controls.Add(this.panelSilah);
            this.Controls.Add(this.gbFirlatilan);
            this.Controls.Add(this.gbYakinSaldiri);
            this.Controls.Add(this.gbAtesliSilah);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.cmbSilahlar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAtesliSilah.ResumeLayout(false);
            this.gbAtesliSilah.PerformLayout();
            this.gbYakinSaldiri.ResumeLayout(false);
            this.gbFirlatilan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSilahlar;
        private System.Windows.Forms.Label lblDetay;
        private System.Windows.Forms.GroupBox gbAtesliSilah;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnYenidenDoldur;
        private System.Windows.Forms.Button btnAtesEt;
        private System.Windows.Forms.GroupBox gbYakinSaldiri;
        private System.Windows.Forms.Button btnSaldir;
        private System.Windows.Forms.GroupBox gbFirlatilan;
        private System.Windows.Forms.Button btnFirlat;
        private System.Windows.Forms.Panel panelSilah;
    }
}

