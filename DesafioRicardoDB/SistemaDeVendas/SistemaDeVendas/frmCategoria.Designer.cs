namespace SistemaDeVendas
{
    partial class frmCategoria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.dataGridView_categoria = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_novo = new System.Windows.Forms.Button();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.label_categoria = new System.Windows.Forms.Label();
            this.textBox_categoria = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_categoria
            // 
            this.dataGridView_categoria.AllowUserToAddRows = false;
            this.dataGridView_categoria.AllowUserToDeleteRows = false;
            this.dataGridView_categoria.AutoGenerateColumns = false;
            this.dataGridView_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_categoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView_categoria.DataSource = this.categoriaBindingSource;
            this.dataGridView_categoria.Location = new System.Drawing.Point(13, 89);
            this.dataGridView_categoria.Name = "dataGridView_categoria";
            this.dataGridView_categoria.ReadOnly = true;
            this.dataGridView_categoria.Size = new System.Drawing.Size(363, 161);
            this.dataGridView_categoria.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Infos.DAL.Categoria);
            // 
            // button_novo
            // 
            this.button_novo.Location = new System.Drawing.Point(14, 256);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(75, 23);
            this.button_novo.TabIndex = 1;
            this.button_novo.Text = "Novo";
            this.button_novo.UseVisualStyleBackColor = true;
            this.button_novo.Click += new System.EventHandler(this.button_novo_Click);
            // 
            // button_gravar
            // 
            this.button_gravar.Location = new System.Drawing.Point(112, 256);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 22);
            this.button_gravar.TabIndex = 2;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = true;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(205, 255);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Location = new System.Drawing.Point(302, 256);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 23);
            this.button_excluir.TabIndex = 4;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Location = new System.Drawing.Point(10, 59);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(52, 13);
            this.label_categoria.TabIndex = 5;
            this.label_categoria.Text = "Categoria";
            this.label_categoria.Click += new System.EventHandler(this.label_categoria_Click);
            // 
            // textBox_categoria
            // 
            this.textBox_categoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Descricao", true));
            this.textBox_categoria.Location = new System.Drawing.Point(68, 56);
            this.textBox_categoria.Name = "textBox_categoria";
            this.textBox_categoria.Size = new System.Drawing.Size(199, 20);
            this.textBox_categoria.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 44);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELETRÔNICOS   D\'SANTOS";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_categoria);
            this.Controls.Add(this.label_categoria);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_gravar);
            this.Controls.Add(this.button_novo);
            this.Controls.Add(this.dataGridView_categoria);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCategoria_FormClosed);
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.TextBox textBox_categoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}