namespace FloriculturaImperial.Forms
{
    partial class fmExportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmExportar));
            this.label1 = new System.Windows.Forms.Label();
            this.pbXls = new System.Windows.Forms.PictureBox();
            this.pbPdf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbXls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha o Modo de Exportação";
            // 
            // pbXls
            // 
            this.pbXls.BackColor = System.Drawing.Color.MintCream;
            this.pbXls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbXls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbXls.Image = ((System.Drawing.Image)(resources.GetObject("pbXls.Image")));
            this.pbXls.Location = new System.Drawing.Point(29, 41);
            this.pbXls.Name = "pbXls";
            this.pbXls.Size = new System.Drawing.Size(86, 64);
            this.pbXls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbXls.TabIndex = 3;
            this.pbXls.TabStop = false;
            this.pbXls.Click += new System.EventHandler(this.pbXls_Click);
            this.pbXls.MouseLeave += new System.EventHandler(this.pbXls_MouseLeave);
            this.pbXls.MouseHover += new System.EventHandler(this.pbXls_MouseHover);
            // 
            // pbPdf
            // 
            this.pbPdf.BackColor = System.Drawing.Color.MintCream;
            this.pbPdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPdf.Image = ((System.Drawing.Image)(resources.GetObject("pbPdf.Image")));
            this.pbPdf.Location = new System.Drawing.Point(216, 41);
            this.pbPdf.Name = "pbPdf";
            this.pbPdf.Size = new System.Drawing.Size(86, 64);
            this.pbPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPdf.TabIndex = 4;
            this.pbPdf.TabStop = false;
            this.pbPdf.MouseLeave += new System.EventHandler(this.pbPdf_MouseLeave);
            this.pbPdf.MouseHover += new System.EventHandler(this.pbPdf_MouseHover);
            // 
            // fmExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 115);
            this.Controls.Add(this.pbPdf);
            this.Controls.Add(this.pbXls);
            this.Controls.Add(this.label1);
            this.Name = "fmExportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar";
            ((System.ComponentModel.ISupportInitialize)(this.pbXls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbXls;
        private System.Windows.Forms.PictureBox pbPdf;
    }
}