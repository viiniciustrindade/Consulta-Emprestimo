namespace Consulta_Emprestimo
{
    partial class FrmConsultaEmprestimo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.txtSecao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.btnCarregarSecao = new System.Windows.Forms.Button();
            this.btnCarregarLocal = new System.Windows.Forms.Button();
            this.btnCarregarAutor = new System.Windows.Forms.Button();
            this.btnCarregarLeitor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Item";
            // 
            // txtCodItem
            // 
            this.txtCodItem.Location = new System.Drawing.Point(94, 12);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.Size = new System.Drawing.Size(66, 22);
            this.txtCodItem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo item";
            // 
            // cbxTipoItem
            // 
            this.cbxTipoItem.FormattingEnabled = true;
            this.cbxTipoItem.Location = new System.Drawing.Point(94, 40);
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(201, 24);
            this.cbxTipoItem.TabIndex = 3;
            this.cbxTipoItem.SelectedIndexChanged += new System.EventHandler(this.cbxTipoItem_SelectedIndexChanged);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(94, 70);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(201, 22);
            this.txtLocal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Local";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 101);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 16);
            this.label.TabIndex = 6;
            this.label.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(94, 98);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(201, 22);
            this.txtAutor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Leitor";
            // 
            // txtLeitor
            // 
            this.txtLeitor.Location = new System.Drawing.Point(94, 126);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(201, 22);
            this.txtLeitor.TabIndex = 9;
            // 
            // txtSecao
            // 
            this.txtSecao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecao.Location = new System.Drawing.Point(428, 40);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.Size = new System.Drawing.Size(329, 22);
            this.txtSecao.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seção";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInicio.Location = new System.Drawing.Point(428, 68);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(359, 22);
            this.dtpDataInicio.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data Inicio";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data Fim ";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataFim.Location = new System.Drawing.Point(428, 96);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(359, 22);
            this.dtpDataFim.TabIndex = 15;
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Location = new System.Drawing.Point(428, 124);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(134, 24);
            this.cbxSituacao.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Situação";
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItem,
            this.colNomeItem,
            this.colLocal,
            this.colAutor,
            this.colLeitor,
            this.colSecao,
            this.colSituacao,
            this.colDataInicio,
            this.colDataFim});
            this.dadosGrid.Location = new System.Drawing.Point(15, 155);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(772, 282);
            this.dadosGrid.TabIndex = 18;
            // 
            // colCodItem
            // 
            this.colCodItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodItem.FillWeight = 152.2843F;
            this.colCodItem.HeaderText = "Item";
            this.colCodItem.MinimumWidth = 6;
            this.colCodItem.Name = "colCodItem";
            this.colCodItem.ReadOnly = true;
            this.colCodItem.Width = 61;
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Tipo Item";
            this.colNomeItem.MinimumWidth = 6;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            this.colNomeItem.Visible = false;
            // 
            // colLocal
            // 
            this.colLocal.HeaderText = "Local";
            this.colLocal.MinimumWidth = 6;
            this.colLocal.Name = "colLocal";
            this.colLocal.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 6;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colLeitor
            // 
            this.colLeitor.HeaderText = "Leitor";
            this.colLeitor.MinimumWidth = 6;
            this.colLeitor.Name = "colLeitor";
            this.colLeitor.ReadOnly = true;
            // 
            // colSecao
            // 
            this.colSecao.HeaderText = "Seção";
            this.colSecao.MinimumWidth = 6;
            this.colSecao.Name = "colSecao";
            this.colSecao.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.MinimumWidth = 6;
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // colDataInicio
            // 
            this.colDataInicio.HeaderText = "Data Inicio";
            this.colDataInicio.MinimumWidth = 6;
            this.colDataInicio.Name = "colDataInicio";
            this.colDataInicio.ReadOnly = true;
            // 
            // colDataFim
            // 
            this.colDataFim.HeaderText = "Data Fim";
            this.colDataFim.MinimumWidth = 6;
            this.colDataFim.Name = "colDataFim";
            this.colDataFim.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(568, 125);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(105, 23);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaConsulta.Location = new System.Drawing.Point(682, 126);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(105, 22);
            this.btnNovaConsulta.TabIndex = 20;
            this.btnNovaConsulta.Text = "Nova consulta";
            this.btnNovaConsulta.UseVisualStyleBackColor = true;
            // 
            // btnCarregarSecao
            // 
            this.btnCarregarSecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregarSecao.Location = new System.Drawing.Point(763, 41);
            this.btnCarregarSecao.Name = "btnCarregarSecao";
            this.btnCarregarSecao.Size = new System.Drawing.Size(24, 23);
            this.btnCarregarSecao.TabIndex = 21;
            this.btnCarregarSecao.Text = "button3";
            this.btnCarregarSecao.UseVisualStyleBackColor = true;
            this.btnCarregarSecao.Click += new System.EventHandler(this.btnCarregarSecao_Click);
            // 
            // btnCarregarLocal
            // 
            this.btnCarregarLocal.Location = new System.Drawing.Point(301, 70);
            this.btnCarregarLocal.Name = "btnCarregarLocal";
            this.btnCarregarLocal.Size = new System.Drawing.Size(24, 23);
            this.btnCarregarLocal.TabIndex = 22;
            this.btnCarregarLocal.Text = "button4";
            this.btnCarregarLocal.UseVisualStyleBackColor = true;
            this.btnCarregarLocal.Click += new System.EventHandler(this.btnCarregarLocal_Click);
            // 
            // btnCarregarAutor
            // 
            this.btnCarregarAutor.Location = new System.Drawing.Point(301, 99);
            this.btnCarregarAutor.Name = "btnCarregarAutor";
            this.btnCarregarAutor.Size = new System.Drawing.Size(24, 23);
            this.btnCarregarAutor.TabIndex = 23;
            this.btnCarregarAutor.Text = "button5";
            this.btnCarregarAutor.UseVisualStyleBackColor = true;
            this.btnCarregarAutor.Click += new System.EventHandler(this.btnCarregarAutor_Click);
            // 
            // btnCarregarLeitor
            // 
            this.btnCarregarLeitor.Location = new System.Drawing.Point(301, 126);
            this.btnCarregarLeitor.Name = "btnCarregarLeitor";
            this.btnCarregarLeitor.Size = new System.Drawing.Size(24, 23);
            this.btnCarregarLeitor.TabIndex = 24;
            this.btnCarregarLeitor.Text = "button6";
            this.btnCarregarLeitor.UseVisualStyleBackColor = true;
            this.btnCarregarLeitor.Click += new System.EventHandler(this.btnCarregarLeitor_Click);
            // 
            // FrmConsultaEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarregarLeitor);
            this.Controls.Add(this.btnCarregarAutor);
            this.Controls.Add(this.btnCarregarLocal);
            this.Controls.Add(this.btnCarregarSecao);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.cbxSituacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.txtSecao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLeitor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.cbxTipoItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodItem);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaEmprestimo";
            this.Text = "Consulta Emprestimo";
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoItem;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNovaConsulta;
        private System.Windows.Forms.Button btnCarregarSecao;
        private System.Windows.Forms.Button btnCarregarLocal;
        private System.Windows.Forms.Button btnCarregarAutor;
        private System.Windows.Forms.Button btnCarregarLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataFim;
    }
}

