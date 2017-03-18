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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbDataDe = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataAte = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pbExportSalvar = new System.Windows.Forms.PictureBox();
            this.pbExportPdf = new System.Windows.Forms.PictureBox();
            this.pbExportExcel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESQUISAR POR NOME: ";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(174, 11);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(324, 25);
            this.txtPesquisar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATA DE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "DATA ATÉ";
            // 
            // mtbDataDe
            // 
            this.mtbDataDe.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataDe.Location = new System.Drawing.Point(565, 11);
            this.mtbDataDe.Mask = "00/00/0000";
            this.mtbDataDe.Name = "mtbDataDe";
            this.mtbDataDe.Size = new System.Drawing.Size(100, 25);
            this.mtbDataDe.TabIndex = 4;
            this.mtbDataDe.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataAte
            // 
            this.mtbDataAte.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataAte.Location = new System.Drawing.Point(743, 11);
            this.mtbDataAte.Mask = "00/00/0000";
            this.mtbDataAte.Name = "mtbDataAte";
            this.mtbDataAte.Size = new System.Drawing.Size(100, 25);
            this.mtbDataAte.TabIndex = 5;
            this.mtbDataAte.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "RETORNAR QTD MAIOR QUE: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(13, 68);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(71, 25);
            this.numericUpDown1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(212, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 25);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "RETORNAR PREÇO MAIOR QUE: ";
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Produto,
            this.Preco,
            this.QtdProduto,
            this.Data});
            this.dgvRelatorio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRelatorio.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvRelatorio.Location = new System.Drawing.Point(0, 96);
            this.dgvRelatorio.MultiSelect = false;
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(846, 228);
            this.dgvRelatorio.TabIndex = 14;
            // 
            // Codigo
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.ToolTipText = "Código do Produto";
            this.Codigo.Width = 90;
            // 
            // Produto
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Produto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.ToolTipText = "Produto";
            this.Produto.Width = 250;
            // 
            // Preco
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle4;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.ToolTipText = "Preço do Produto";
            this.Preco.Width = 146;
            // 
            // QtdProduto
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.QtdProduto.DefaultCellStyle = dataGridViewCellStyle5;
            this.QtdProduto.HeaderText = "Qtd Produto";
            this.QtdProduto.Name = "QtdProduto";
            this.QtdProduto.ReadOnly = true;
            this.QtdProduto.ToolTipText = "Quantidade Produto";
            this.QtdProduto.Width = 150;
            // 
            // Data
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Data.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data.HeaderText = "Data Vendida";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 145;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::FloriculturaImperial.Properties.Resources.pesquisa;
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(438, 51);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 35);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // pbExportSalvar
            // 
            this.pbExportSalvar.BackColor = System.Drawing.Color.White;
            this.pbExportSalvar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExportSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExportSalvar.Image = global::FloriculturaImperial.Properties.Resources.salva_icon;
            this.pbExportSalvar.Location = new System.Drawing.Point(780, 50);
            this.pbExportSalvar.Name = "pbExportSalvar";
            this.pbExportSalvar.Size = new System.Drawing.Size(47, 33);
            this.pbExportSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExportSalvar.TabIndex = 13;
            this.pbExportSalvar.TabStop = false;
            this.pbExportSalvar.Click += new System.EventHandler(this.pbExportSalvar_Click);
            this.pbExportSalvar.MouseLeave += new System.EventHandler(this.pbExportSalvar_MouseLeave);
            this.pbExportSalvar.MouseHover += new System.EventHandler(this.pbExportSalvar_MouseHover);
            // 
            // pbExportPdf
            // 
            this.pbExportPdf.BackColor = System.Drawing.Color.White;
            this.pbExportPdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExportPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExportPdf.Image = global::FloriculturaImperial.Properties.Resources.pdf_icon;
            this.pbExportPdf.Location = new System.Drawing.Point(687, 50);
            this.pbExportPdf.Name = "pbExportPdf";
            this.pbExportPdf.Size = new System.Drawing.Size(44, 33);
            this.pbExportPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExportPdf.TabIndex = 11;
            this.pbExportPdf.TabStop = false;
            this.pbExportPdf.Click += new System.EventHandler(this.pbExportPdf_Click);
            this.pbExportPdf.MouseLeave += new System.EventHandler(this.pbExportPdf_MouseLeave);
            this.pbExportPdf.MouseHover += new System.EventHandler(this.pbExportPdf_MouseHover);
            // 
            // pbExportExcel
            // 
            this.pbExportExcel.BackColor = System.Drawing.Color.White;
            this.pbExportExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExportExcel.Image = global::FloriculturaImperial.Properties.Resources.excel_icon1;
            this.pbExportExcel.Location = new System.Drawing.Point(605, 48);
            this.pbExportExcel.Name = "pbExportExcel";
            this.pbExportExcel.Size = new System.Drawing.Size(42, 35);
            this.pbExportExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExportExcel.TabIndex = 10;
            this.pbExportExcel.TabStop = false;
            this.pbExportExcel.Click += new System.EventHandler(this.pbExportExcel_Click);
            this.pbExportExcel.MouseLeave += new System.EventHandler(this.pbExportExcel_MouseLeave);
            this.pbExportExcel.MouseHover += new System.EventHandler(this.pbExportExcel_MouseHover);
            // 
            // ucRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.pbExportSalvar);
            this.Controls.Add(this.pbExportPdf);
            this.Controls.Add(this.pbExportExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbDataAte);
            this.Controls.Add(this.mtbDataDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Name = "ucRelatorio";
            this.Size = new System.Drawing.Size(846, 324);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbDataDe;
        private System.Windows.Forms.MaskedTextBox mtbDataAte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbExportExcel;
        private System.Windows.Forms.PictureBox pbExportPdf;
        private System.Windows.Forms.PictureBox pbExportSalvar;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Button btnPesquisar;
    }
}
