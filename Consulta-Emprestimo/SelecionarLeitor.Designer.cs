namespace Consulta_Emprestimo
{
    partial class SelecionarLeitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarLeitor));
            this.txtcodLeitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeLeitor2 = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.Label();
            this.dadosGrid2 = new System.Windows.Forms.DataGridView();
            this.colCodLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodLeitor
            // 
            this.txtcodLeitor.Location = new System.Drawing.Point(97, 9);
            this.txtcodLeitor.Name = "txtcodLeitor";
            this.txtcodLeitor.Size = new System.Drawing.Size(63, 22);
            this.txtcodLeitor.TabIndex = 40;
            this.txtcodLeitor.TextChanged += new System.EventHandler(this.txtcodLeitor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Código";
            // 
            // txtNomeLeitor2
            // 
            this.txtNomeLeitor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLeitor2.Location = new System.Drawing.Point(97, 37);
            this.txtNomeLeitor2.Name = "txtNomeLeitor2";
            this.txtNomeLeitor2.Size = new System.Drawing.Size(266, 22);
            this.txtNomeLeitor2.TabIndex = 38;
            this.txtNomeLeitor2.TextChanged += new System.EventHandler(this.txtNomeLeitor2_TextChanged);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.AutoSize = true;
            this.txtNomeAutor.Location = new System.Drawing.Point(13, 40);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(76, 16);
            this.txtNomeAutor.TabIndex = 37;
            this.txtNomeAutor.Text = "Nome leitor";
            // 
            // dadosGrid2
            // 
            this.dadosGrid2.AllowUserToAddRows = false;
            this.dadosGrid2.AllowUserToDeleteRows = false;
            this.dadosGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodLeitor,
            this.colNomeLeitor});
            this.dadosGrid2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid2.Location = new System.Drawing.Point(16, 65);
            this.dadosGrid2.Name = "dadosGrid2";
            this.dadosGrid2.ReadOnly = true;
            this.dadosGrid2.RowHeadersWidth = 51;
            this.dadosGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid2.Size = new System.Drawing.Size(572, 237);
            this.dadosGrid2.TabIndex = 36;
            this.dadosGrid2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid2_CellDoubleClick);
            // 
            // colCodLeitor
            // 
            this.colCodLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodLeitor.FillWeight = 152.2843F;
            this.colCodLeitor.HeaderText = "Código";
            this.colCodLeitor.MinimumWidth = 6;
            this.colCodLeitor.Name = "colCodLeitor";
            this.colCodLeitor.ReadOnly = true;
            this.colCodLeitor.Width = 80;
            // 
            // colNomeLeitor
            // 
            this.colNomeLeitor.FillWeight = 73.85786F;
            this.colNomeLeitor.HeaderText = "Nome leitor";
            this.colNomeLeitor.MinimumWidth = 6;
            this.colNomeLeitor.Name = "colNomeLeitor";
            this.colNomeLeitor.ReadOnly = true;
            // 
            // SelecionarLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.txtcodLeitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeLeitor2);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.dadosGrid2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelecionarLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar leitor";
            this.Load += new System.EventHandler(this.SelecionarLeitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodLeitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeLeitor2;
        private System.Windows.Forms.Label txtNomeAutor;
        private System.Windows.Forms.DataGridView dadosGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLeitor;
    }
}