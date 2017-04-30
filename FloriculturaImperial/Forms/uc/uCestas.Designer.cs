namespace FloriculturaImperial.Forms.uc
{
    partial class uCestas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMontarCestas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMontarCestas
            // 
            this.btnMontarCestas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMontarCestas.Font = new System.Drawing.Font("Arial", 10F);
            this.btnMontarCestas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMontarCestas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMontarCestas.Location = new System.Drawing.Point(6, 1);
            this.btnMontarCestas.Name = "btnMontarCestas";
            this.btnMontarCestas.Size = new System.Drawing.Size(115, 70);
            this.btnMontarCestas.TabIndex = 8;
            this.btnMontarCestas.Text = "Montar Cestas";
            this.btnMontarCestas.UseVisualStyleBackColor = false;
            this.btnMontarCestas.Click += new System.EventHandler(this.btnMontarCestas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Arial", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(6, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cestas Disponiveis";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Arial", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(6, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 70);
            this.button2.TabIndex = 10;
            this.button2.Text = "Relatorios de Cestas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnMontarCestas);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 328);
            this.panel2.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Arial", 10F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(6, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 70);
            this.button3.TabIndex = 11;
            this.button3.Text = "Relatorios de Cestas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(128, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(837, 328);
            this.pnPrincipal.TabIndex = 12;
            // 
            // uCestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.panel2);
            this.Name = "uCestas";
            this.Size = new System.Drawing.Size(965, 328);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMontarCestas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Button button3;
    }
}
