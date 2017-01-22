namespace AnotacoesDiaria
{
    partial class fmPrincinpal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnBotoesPrincipais = new System.Windows.Forms.Panel();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.btnPlantas = new System.Windows.Forms.Button();
            this.btnBrinquedo = new System.Windows.Forms.Button();
            this.btnCestas = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.pnVendas = new System.Windows.Forms.Panel();
            this.pnTabGeral = new System.Windows.Forms.Panel();
            this.dgvTabVendasGeral = new System.Windows.Forms.DataGridView();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.btnRelatorioVenda = new System.Windows.Forms.Button();
            this.btnCadVendas = new System.Windows.Forms.Button();
            this.btnTabVendasGeral = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plantas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentVendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBotoesPrincipais.SuspendLayout();
            this.pnVendas.SuspendLayout();
            this.pnTabGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabVendasGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbTitulo.Location = new System.Drawing.Point(129, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(336, 30);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "FLORICULTURA IMPERIAL";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBotoesPrincipais
            // 
            this.pnBotoesPrincipais.BackColor = System.Drawing.Color.CadetBlue;
            this.pnBotoesPrincipais.Controls.Add(this.btnEntrega);
            this.pnBotoesPrincipais.Controls.Add(this.btnPlantas);
            this.pnBotoesPrincipais.Controls.Add(this.btnBrinquedo);
            this.pnBotoesPrincipais.Controls.Add(this.btnCestas);
            this.pnBotoesPrincipais.Controls.Add(this.btnVendas);
            this.pnBotoesPrincipais.Location = new System.Drawing.Point(2, 52);
            this.pnBotoesPrincipais.Name = "pnBotoesPrincipais";
            this.pnBotoesPrincipais.Size = new System.Drawing.Size(816, 77);
            this.pnBotoesPrincipais.TabIndex = 7;
            // 
            // btnEntrega
            // 
            this.btnEntrega.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEntrega.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEntrega.Location = new System.Drawing.Point(681, 21);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(123, 38);
            this.btnEntrega.TabIndex = 5;
            this.btnEntrega.Text = "Entregas";
            this.btnEntrega.UseVisualStyleBackColor = false;
            // 
            // btnPlantas
            // 
            this.btnPlantas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPlantas.Font = new System.Drawing.Font("Arial", 12F);
            this.btnPlantas.Location = new System.Drawing.Point(169, 21);
            this.btnPlantas.Name = "btnPlantas";
            this.btnPlantas.Size = new System.Drawing.Size(106, 38);
            this.btnPlantas.TabIndex = 2;
            this.btnPlantas.Text = "Plantas";
            this.btnPlantas.UseVisualStyleBackColor = false;
            // 
            // btnBrinquedo
            // 
            this.btnBrinquedo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBrinquedo.Font = new System.Drawing.Font("Arial", 12F);
            this.btnBrinquedo.Location = new System.Drawing.Point(514, 21);
            this.btnBrinquedo.Name = "btnBrinquedo";
            this.btnBrinquedo.Size = new System.Drawing.Size(123, 38);
            this.btnBrinquedo.TabIndex = 4;
            this.btnBrinquedo.Text = "Brinquedos";
            this.btnBrinquedo.UseVisualStyleBackColor = false;
            // 
            // btnCestas
            // 
            this.btnCestas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCestas.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCestas.Location = new System.Drawing.Point(340, 21);
            this.btnCestas.Name = "btnCestas";
            this.btnCestas.Size = new System.Drawing.Size(123, 38);
            this.btnCestas.TabIndex = 3;
            this.btnCestas.Text = "Cestas";
            this.btnCestas.UseVisualStyleBackColor = false;
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVendas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Location = new System.Drawing.Point(8, 21);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(103, 38);
            this.btnVendas.TabIndex = 1;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            // 
            // pnVendas
            // 
            this.pnVendas.Controls.Add(this.pnTabGeral);
            this.pnVendas.Controls.Add(this.btnGerarPdf);
            this.pnVendas.Controls.Add(this.btnRelatorioVenda);
            this.pnVendas.Controls.Add(this.btnCadVendas);
            this.pnVendas.Controls.Add(this.btnTabVendasGeral);
            this.pnVendas.Location = new System.Drawing.Point(10, 138);
            this.pnVendas.Name = "pnVendas";
            this.pnVendas.Size = new System.Drawing.Size(808, 314);
            this.pnVendas.TabIndex = 8;
            // 
            // pnTabGeral
            // 
            this.pnTabGeral.Controls.Add(this.dgvTabVendasGeral);
            this.pnTabGeral.Location = new System.Drawing.Point(114, 3);
            this.pnTabGeral.Name = "pnTabGeral";
            this.pnTabGeral.Size = new System.Drawing.Size(674, 308);
            this.pnTabGeral.TabIndex = 10;
            // 
            // dgvTabVendasGeral
            // 
            this.dgvTabVendasGeral.AllowUserToAddRows = false;
            this.dgvTabVendasGeral.AllowUserToDeleteRows = false;
            this.dgvTabVendasGeral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTabVendasGeral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabVendasGeral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabVendasGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabVendasGeral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Plantas,
            this.Preco,
            this.TotalVendidas,
            this.PorcentVendidas,
            this.TotalEstoque,
            this.PorcentEstoque});
            this.dgvTabVendasGeral.Location = new System.Drawing.Point(0, 0);
            this.dgvTabVendasGeral.Name = "dgvTabVendasGeral";
            this.dgvTabVendasGeral.ReadOnly = true;
            this.dgvTabVendasGeral.RowTemplate.ReadOnly = true;
            this.dgvTabVendasGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabVendasGeral.Size = new System.Drawing.Size(682, 308);
            this.dgvTabVendasGeral.TabIndex = 0;
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGerarPdf.Font = new System.Drawing.Font("Arial", 10F);
            this.btnGerarPdf.Location = new System.Drawing.Point(4, 233);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(103, 72);
            this.btnGerarPdf.TabIndex = 9;
            this.btnGerarPdf.Text = "Gerar PDF  ";
            this.btnGerarPdf.UseVisualStyleBackColor = false;
            // 
            // btnRelatorioVenda
            // 
            this.btnRelatorioVenda.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRelatorioVenda.Font = new System.Drawing.Font("Arial", 10F);
            this.btnRelatorioVenda.Location = new System.Drawing.Point(5, 155);
            this.btnRelatorioVenda.Name = "btnRelatorioVenda";
            this.btnRelatorioVenda.Size = new System.Drawing.Size(103, 72);
            this.btnRelatorioVenda.TabIndex = 8;
            this.btnRelatorioVenda.Text = "Relatório de Vendas";
            this.btnRelatorioVenda.UseVisualStyleBackColor = false;
            // 
            // btnCadVendas
            // 
            this.btnCadVendas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCadVendas.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCadVendas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadVendas.Location = new System.Drawing.Point(5, 79);
            this.btnCadVendas.Name = "btnCadVendas";
            this.btnCadVendas.Size = new System.Drawing.Size(103, 70);
            this.btnCadVendas.TabIndex = 7;
            this.btnCadVendas.Text = "Cadastro De Vendas";
            this.btnCadVendas.UseVisualStyleBackColor = false;
            // 
            // btnTabVendasGeral
            // 
            this.btnTabVendasGeral.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTabVendasGeral.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnTabVendasGeral.Font = new System.Drawing.Font("Arial", 10F);
            this.btnTabVendasGeral.Location = new System.Drawing.Point(5, 3);
            this.btnTabVendasGeral.Name = "btnTabVendasGeral";
            this.btnTabVendasGeral.Size = new System.Drawing.Size(103, 70);
            this.btnTabVendasGeral.TabIndex = 6;
            this.btnTabVendasGeral.Text = "Tabela De Vendas Geral";
            this.btnTabVendasGeral.UseVisualStyleBackColor = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Codigo.ToolTipText = "Código das Plantas";
            this.Codigo.Width = 80;
            // 
            // Plantas
            // 
            this.Plantas.HeaderText = "Plantas";
            this.Plantas.Name = "Plantas";
            this.Plantas.ReadOnly = true;
            this.Plantas.Width = 190;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 80;
            // 
            // TotalVendidas
            // 
            this.TotalVendidas.HeaderText = "Vendidas";
            this.TotalVendidas.Name = "TotalVendidas";
            this.TotalVendidas.ReadOnly = true;
            this.TotalVendidas.Width = 80;
            // 
            // PorcentVendidas
            // 
            this.PorcentVendidas.HeaderText = "%";
            this.PorcentVendidas.Name = "PorcentVendidas";
            this.PorcentVendidas.ReadOnly = true;
            this.PorcentVendidas.Width = 60;
            // 
            // TotalEstoque
            // 
            this.TotalEstoque.HeaderText = "Estouqe";
            this.TotalEstoque.Name = "TotalEstoque";
            this.TotalEstoque.ReadOnly = true;
            this.TotalEstoque.Width = 80;
            // 
            // PorcentEstoque
            // 
            this.PorcentEstoque.HeaderText = "%";
            this.PorcentEstoque.Name = "PorcentEstoque";
            this.PorcentEstoque.ReadOnly = true;
            this.PorcentEstoque.Width = 60;
            // 
            // fmPrincinpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(821, 466);
            this.Controls.Add(this.pnVendas);
            this.Controls.Add(this.pnBotoesPrincipais);
            this.Controls.Add(this.lbTitulo);
            this.MaximizeBox = false;
            this.Name = "fmPrincinpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floricultura Imperial";
            this.pnBotoesPrincipais.ResumeLayout(false);
            this.pnVendas.ResumeLayout(false);
            this.pnTabGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabVendasGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel pnBotoesPrincipais;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnPlantas;
        private System.Windows.Forms.Button btnBrinquedo;
        private System.Windows.Forms.Button btnCestas;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Panel pnVendas;
        private System.Windows.Forms.Button btnGerarPdf;
        private System.Windows.Forms.Button btnRelatorioVenda;
        private System.Windows.Forms.Button btnCadVendas;
        private System.Windows.Forms.Button btnTabVendasGeral;
        private System.Windows.Forms.Panel pnTabGeral;
        private System.Windows.Forms.DataGridView dgvTabVendasGeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plantas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentVendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentEstoque;
    }
}

