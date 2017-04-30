namespace FloriculturaImperial.Forms.uc
{
    partial class ucMontarCesta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstPlantas = new System.Windows.Forms.ListBox();
            this.gbTipoFlor = new System.Windows.Forms.GroupBox();
            this.lblDescricaoTipo = new System.Windows.Forms.Label();
            this.rdbEspeciais = new System.Windows.Forms.RadioButton();
            this.rdbSimples = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnIncluirNaCesta = new System.Windows.Forms.Button();
            this.lblNomeCesta = new System.Windows.Forms.Label();
            this.txtNomeCesta = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPrecoCesta = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCestaPlantas = new System.Windows.Forms.ListBox();
            this.pbImagemFlor = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gbTipoFlor.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemFlor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstPlantas);
            this.panel1.Controls.Add(this.gbTipoFlor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Arial", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 328);
            this.panel1.TabIndex = 0;
            // 
            // lstPlantas
            // 
            this.lstPlantas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lstPlantas.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.lstPlantas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlantas.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lstPlantas.FormattingEnabled = true;
            this.lstPlantas.ItemHeight = 18;
            this.lstPlantas.Location = new System.Drawing.Point(0, 113);
            this.lstPlantas.Name = "lstPlantas";
            this.lstPlantas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPlantas.Size = new System.Drawing.Size(217, 215);
            this.lstPlantas.TabIndex = 1;
            this.lstPlantas.SelectedIndexChanged += new System.EventHandler(this.lstPlantas_SelectedIndexChanged);
            // 
            // gbTipoFlor
            // 
            this.gbTipoFlor.Controls.Add(this.lblDescricaoTipo);
            this.gbTipoFlor.Controls.Add(this.rdbEspeciais);
            this.gbTipoFlor.Controls.Add(this.rdbSimples);
            this.gbTipoFlor.Controls.Add(this.rdbTodos);
            this.gbTipoFlor.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTipoFlor.Font = new System.Drawing.Font("Arial", 10F);
            this.gbTipoFlor.Location = new System.Drawing.Point(0, 0);
            this.gbTipoFlor.Name = "gbTipoFlor";
            this.gbTipoFlor.Size = new System.Drawing.Size(217, 113);
            this.gbTipoFlor.TabIndex = 0;
            this.gbTipoFlor.TabStop = false;
            this.gbTipoFlor.Text = "FILTRA POR......";
            // 
            // lblDescricaoTipo
            // 
            this.lblDescricaoTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescricaoTipo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDescricaoTipo.Location = new System.Drawing.Point(90, 19);
            this.lblDescricaoTipo.Name = "lblDescricaoTipo";
            this.lblDescricaoTipo.Size = new System.Drawing.Size(124, 91);
            this.lblDescricaoTipo.TabIndex = 3;
            this.lblDescricaoTipo.Text = "label1";
            this.lblDescricaoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbEspeciais
            // 
            this.rdbEspeciais.AutoSize = true;
            this.rdbEspeciais.Font = new System.Drawing.Font("Arial", 10F);
            this.rdbEspeciais.Location = new System.Drawing.Point(3, 87);
            this.rdbEspeciais.Name = "rdbEspeciais";
            this.rdbEspeciais.Size = new System.Drawing.Size(86, 20);
            this.rdbEspeciais.TabIndex = 2;
            this.rdbEspeciais.Text = "Especiais";
            this.rdbEspeciais.UseVisualStyleBackColor = true;
            this.rdbEspeciais.CheckedChanged += new System.EventHandler(this.rdbEspeciais_CheckedChanged);
            // 
            // rdbSimples
            // 
            this.rdbSimples.AutoSize = true;
            this.rdbSimples.Font = new System.Drawing.Font("Arial", 10F);
            this.rdbSimples.Location = new System.Drawing.Point(6, 61);
            this.rdbSimples.Name = "rdbSimples";
            this.rdbSimples.Size = new System.Drawing.Size(75, 20);
            this.rdbSimples.TabIndex = 1;
            this.rdbSimples.Text = "Simples";
            this.rdbSimples.UseVisualStyleBackColor = true;
            this.rdbSimples.CheckedChanged += new System.EventHandler(this.rdbSimples_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Arial", 10F);
            this.rdbTodos.Location = new System.Drawing.Point(6, 33);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(64, 20);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todas";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btnSalvar);
            this.pnBotoes.Controls.Add(this.btnRemover);
            this.pnBotoes.Controls.Add(this.btnAjuda);
            this.pnBotoes.Controls.Add(this.btnIncluirNaCesta);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBotoes.Location = new System.Drawing.Point(217, 0);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Padding = new System.Windows.Forms.Padding(10);
            this.pnBotoes.Size = new System.Drawing.Size(620, 53);
            this.pnBotoes.TabIndex = 1;
            this.pnBotoes.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(140, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 33);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemover.Font = new System.Drawing.Font("Arial", 10F);
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemover.Location = new System.Drawing.Point(381, 10);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(136, 33);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover da Cesta";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAjuda.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAjuda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAjuda.Location = new System.Drawing.Point(517, 10);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(93, 33);
            this.btnAjuda.TabIndex = 10;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = false;
            // 
            // btnIncluirNaCesta
            // 
            this.btnIncluirNaCesta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIncluirNaCesta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIncluirNaCesta.Font = new System.Drawing.Font("Arial", 10F);
            this.btnIncluirNaCesta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIncluirNaCesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirNaCesta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIncluirNaCesta.Location = new System.Drawing.Point(10, 10);
            this.btnIncluirNaCesta.Name = "btnIncluirNaCesta";
            this.btnIncluirNaCesta.Size = new System.Drawing.Size(130, 33);
            this.btnIncluirNaCesta.TabIndex = 9;
            this.btnIncluirNaCesta.Text = "Incluir na Cesta";
            this.btnIncluirNaCesta.UseVisualStyleBackColor = false;
            this.btnIncluirNaCesta.Click += new System.EventHandler(this.btnIncluirNaCesta_Click);
            // 
            // lblNomeCesta
            // 
            this.lblNomeCesta.AutoSize = true;
            this.lblNomeCesta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNomeCesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNomeCesta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblNomeCesta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomeCesta.Location = new System.Drawing.Point(6, 13);
            this.lblNomeCesta.Name = "lblNomeCesta";
            this.lblNomeCesta.Size = new System.Drawing.Size(125, 15);
            this.lblNomeCesta.TabIndex = 15;
            this.lblNomeCesta.Text = "NOME DA CESTA :";
            this.lblNomeCesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeCesta
            // 
            this.txtNomeCesta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNomeCesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeCesta.Location = new System.Drawing.Point(147, 11);
            this.txtNomeCesta.Name = "txtNomeCesta";
            this.txtNomeCesta.Size = new System.Drawing.Size(164, 26);
            this.txtNomeCesta.TabIndex = 22;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPreco.Location = new System.Drawing.Point(175, 40);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(136, 26);
            this.txtPreco.TabIndex = 24;
            // 
            // lblPrecoCesta
            // 
            this.lblPrecoCesta.AutoSize = true;
            this.lblPrecoCesta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPrecoCesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecoCesta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPrecoCesta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrecoCesta.Location = new System.Drawing.Point(7, 45);
            this.lblPrecoCesta.Name = "lblPrecoCesta";
            this.lblPrecoCesta.Size = new System.Drawing.Size(149, 15);
            this.lblPrecoCesta.TabIndex = 23;
            this.lblPrecoCesta.Text = "PREÇO DA CESTAR$ :";
            this.lblPrecoCesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lstCestaPlantas);
            this.panel3.Controls.Add(this.txtPreco);
            this.panel3.Controls.Add(this.lblNomeCesta);
            this.panel3.Controls.Add(this.lblPrecoCesta);
            this.panel3.Controls.Add(this.txtNomeCesta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(217, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 275);
            this.panel3.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(230, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 26);
            this.textBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "PERCENTUAL DE DESCONTO % : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstCestaPlantas
            // 
            this.lstCestaPlantas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lstCestaPlantas.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.lstCestaPlantas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstCestaPlantas.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lstCestaPlantas.FormattingEnabled = true;
            this.lstCestaPlantas.ItemHeight = 18;
            this.lstCestaPlantas.Location = new System.Drawing.Point(0, 109);
            this.lstCestaPlantas.Name = "lstCestaPlantas";
            this.lstCestaPlantas.Size = new System.Drawing.Size(343, 166);
            this.lstCestaPlantas.TabIndex = 25;
            // 
            // pbImagemFlor
            // 
            this.pbImagemFlor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagemFlor.Image = global::FloriculturaImperial.Properties.Resources.img_nao_disponivel;
            this.pbImagemFlor.Location = new System.Drawing.Point(560, 53);
            this.pbImagemFlor.Name = "pbImagemFlor";
            this.pbImagemFlor.Size = new System.Drawing.Size(277, 275);
            this.pbImagemFlor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemFlor.TabIndex = 26;
            this.pbImagemFlor.TabStop = false;
            // 
            // ucMontarCesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.pbImagemFlor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.panel1);
            this.Name = "ucMontarCesta";
            this.Size = new System.Drawing.Size(837, 328);
            this.panel1.ResumeLayout(false);
            this.gbTipoFlor.ResumeLayout(false);
            this.gbTipoFlor.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemFlor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbTipoFlor;
        private System.Windows.Forms.RadioButton rdbEspeciais;
        private System.Windows.Forms.RadioButton rdbSimples;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Label lblDescricaoTipo;
        private System.Windows.Forms.ListBox lstPlantas;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btnIncluirNaCesta;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Label lblNomeCesta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNomeCesta;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPrecoCesta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstCestaPlantas;
        private System.Windows.Forms.PictureBox pbImagemFlor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
