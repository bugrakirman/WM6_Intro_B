namespace KisiselKontroller
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
            this.btnOku = new System.Windows.Forms.Button();
            this.txtConverter1 = new KisiselKontroller.TxtConverter();
            this.SuspendLayout();
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(230, 13);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(76, 49);
            this.btnOku.TabIndex = 1;
            this.btnOku.Text = "button1";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // txtConverter1
            // 
            this.txtConverter1.AktifMi = false;
            this.txtConverter1.Location = new System.Drawing.Point(13, 13);
            this.txtConverter1.MaximumSize = new System.Drawing.Size(200, 60);
            this.txtConverter1.Name = "txtConverter1";
            this.txtConverter1.Renk = System.Drawing.Color.Empty;
            this.txtConverter1.Sayi = 0;
            this.txtConverter1.Size = new System.Drawing.Size(200, 60);
            this.txtConverter1.TabIndex = 2;
            this.txtConverter1.Tarih = new System.DateTime(((long)(0)));
            this.txtConverter1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtConverter1.SinirAsildi += new KisiselKontroller.SinirAsimiHandler(this.txtConverter1_SinirAsildi);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 289);
            this.Controls.Add(this.txtConverter1);
            this.Controls.Add(this.btnOku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOku;
        private TxtConverter txtConverter1;
    }
}

