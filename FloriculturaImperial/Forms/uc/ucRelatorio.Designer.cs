namespace FloriculturaImperial.Forms.uc
{
    partial class ucRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSalvarRelatorio = new System.Windows.Forms.Button();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.mtbDataDe = new System.Windows.Forms.MaskedTextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.mtbDataAte = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Nome Produto:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(191, 13);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(272, 26);
            this.txtPesquisar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia de";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dia Até";
            // 
            // nudQtd
            // 
            this.nudQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudQtd.Location = new System.Drawing.Point(176, 50);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.ReadOnly = true;
            this.nudQtd.Size = new System.Drawing.Size(52, 26);
            this.nudQtd.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Retornar qtd maior que:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Preço maior que";
            // 
            // dgvRelatorio
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Produto,
            this.Preco,
            this.QtdVendidos,
            this.Data});
            this.dgvRelatorio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRelatorio.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvRelatorio.Location = new System.Drawing.Point(0, 98);
            this.dgvRelatorio.MultiSelect = false;
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(846, 226);
            this.dgvRelatorio.TabIndex = 19;
            // 
            // Codigo
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 90;
            // 
            // Produto
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Produto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Produto.HeaderText = "Produtos";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.ToolTipText = "Produtos vendidos";
            this.Produto.Width = 290;
            // 
            // Preco
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle5;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // QtdVendidos
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.QtdVendidos.DefaultCellStyle = dataGridViewCellStyle6;
            this.QtdVendidos.HeaderText = "Qtd Vendidos";
            this.QtdVendidos.Name = "QtdVendidos";
            this.QtdVendidos.ReadOnly = true;
            this.QtdVendidos.Width = 150;
            // 
            // Data
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Data.DefaultCellStyle = dataGridViewCellStyle7;
            this.Data.HeaderText = "Data Vendida";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 150;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Green;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnFiltrar.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFiltrar.Location = new System.Drawing.Point(463, 49);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(117, 43);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "FILTAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            this.btnFiltrar.MouseLeave += new System.EventHandler(this.btnFiltrar_MouseLeave);
            this.btnFiltrar.MouseHover += new System.EventHandler(this.btnFiltrar_MouseHover);
            // 
            // btnSalvarRelatorio
            // 
            this.btnSalvarRelatorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalvarRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSalvarRelatorio.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSalvarRelatorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvarRelatorio.Location = new System.Drawing.Point(722, 47);
            this.btnSalvarRelatorio.Name = "btnSalvarRelatorio";
            this.btnSalvarRelatorio.Size = new System.Drawing.Size(106, 43);
            this.btnSalvarRelatorio.TabIndex = 15;
            this.btnSalvarRelatorio.Text = "Salvar Relatorio ";
            this.btnSalvarRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExportarPdf.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnExportarPdf.Font = new System.Drawing.Font("Arial", 10F);
            this.btnExportarPdf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExportarPdf.Location = new System.Drawing.Point(602, 48);
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Size = new System.Drawing.Size(110, 43);
            this.btnExportarPdf.TabIndex = 14;
            this.btnExportarPdf.Text = "Exportar para PDF";
            this.btnExportarPdf.UseVisualStyleBackColor = false;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // mtbDataDe
            // 
            this.mtbDataDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbDataDe.Location = new System.Drawing.Point(537, 11);
            this.mtbDataDe.Mask = "00/00/0000";
            this.mtbDataDe.Name = "mtbDataDe";
            this.mtbDataDe.Size = new System.Drawing.Size(95, 26);
            this.mtbDataDe.TabIndex = 20;
            this.mtbDataDe.ValidatingType = typeof(System.DateTime);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(358, 49);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(96, 26);
            this.txtPreco.TabIndex = 12;
            // 
            // mtbDataAte
            // 
            this.mtbDataAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbDataAte.Location = new System.Drawing.Point(708, 11);
            this.mtbDataAte.Mask = "00/00/0000";
            this.mtbDataAte.Name = "mtbDataAte";
            this.mtbDataAte.Size = new System.Drawing.Size(95, 26);
            this.mtbDataAte.TabIndex = 21;
            this.mtbDataAte.ValidatingType = typeof(System.DateTime);
            // 
            // ucRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtbDataAte);
            this.Controls.Add(this.mtbDataDe);
            this.Controls.Add(this.btnExportarPdf);
            this.Controls.Add(this.btnSalvarRelatorio);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Name = "ucRelatorio";
            this.Size = new System.Drawing.Size(846, 324);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnSalvarRelatorio;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.MaskedTextBox mtbDataDe;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.MaskedTextBox mtbDataAte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}
