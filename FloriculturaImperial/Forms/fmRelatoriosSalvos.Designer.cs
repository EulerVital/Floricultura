namespace FloriculturaImperial.Forms
{
    partial class fmRelatoriosSalvos
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
            this.ltbRelatorios = new System.Windows.Forms.ListBox();
            this.gbTipoApresenta = new System.Windows.Forms.GroupBox();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.rbtData = new System.Windows.Forms.RadioButton();
            this.gbTipoApresenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbRelatorios
            // 
            this.ltbRelatorios.BackColor = System.Drawing.SystemColors.Control;
            this.ltbRelatorios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ltbRelatorios.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbRelatorios.FormattingEnabled = true;
            this.ltbRelatorios.ItemHeight = 18;
            this.ltbRelatorios.Location = new System.Drawing.Point(0, 84);
            this.ltbRelatorios.Name = "ltbRelatorios";
            this.ltbRelatorios.Size = new System.Drawing.Size(257, 202);
            this.ltbRelatorios.TabIndex = 0;
            this.ltbRelatorios.SelectedIndexChanged += new System.EventHandler(this.ltbRelatorios_SelectedIndexChanged);
            // 
            // gbTipoApresenta
            // 
            this.gbTipoApresenta.Controls.Add(this.rbtNome);
            this.gbTipoApresenta.Controls.Add(this.rbtData);
            this.gbTipoApresenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTipoApresenta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoApresenta.Location = new System.Drawing.Point(0, 0);
            this.gbTipoApresenta.Name = "gbTipoApresenta";
            this.gbTipoApresenta.Size = new System.Drawing.Size(257, 84);
            this.gbTipoApresenta.TabIndex = 1;
            this.gbTipoApresenta.TabStop = false;
            this.gbTipoApresenta.Text = "Escolha o modo de Apresentação";
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNome.Location = new System.Drawing.Point(122, 39);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(71, 22);
            this.rbtNome.TabIndex = 4;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            this.rbtNome.CheckedChanged += new System.EventHandler(this.rbtNome_CheckedChanged);
            // 
            // rbtData
            // 
            this.rbtData.AutoSize = true;
            this.rbtData.Checked = true;
            this.rbtData.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtData.Location = new System.Drawing.Point(27, 39);
            this.rbtData.Name = "rbtData";
            this.rbtData.Size = new System.Drawing.Size(61, 22);
            this.rbtData.TabIndex = 3;
            this.rbtData.TabStop = true;
            this.rbtData.Text = "Data";
            this.rbtData.UseVisualStyleBackColor = true;
            this.rbtData.CheckedChanged += new System.EventHandler(this.rbtData_CheckedChanged);
            // 
            // fmRelatoriosSalvos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(257, 286);
            this.Controls.Add(this.gbTipoApresenta);
            this.Controls.Add(this.ltbRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmRelatoriosSalvos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios Salvos";
            this.gbTipoApresenta.ResumeLayout(false);
            this.gbTipoApresenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbRelatorios;
        private System.Windows.Forms.GroupBox gbTipoApresenta;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.RadioButton rbtData;
    }
}