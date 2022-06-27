namespace SistemaDeVendas
{
    partial class FrmVenda
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
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBox_codigoPessoa = new System.Windows.Forms.ComboBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_novavenda = new System.Windows.Forms.Button();
            this.groupBox_novavenda = new System.Windows.Forms.GroupBox();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoVendaTextBox = new System.Windows.Forms.TextBox();
            this.ComboBox_codigoProduto = new System.Windows.Forms.ComboBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.DataGridView_itemVenda = new System.Windows.Forms.DataGridView();
            this.button_novoitem = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TextBox_valoritens = new System.Windows.Forms.TextBox();
            this.TextBox_desconto = new System.Windows.Forms.TextBox();
            this.TextBox_valorPago = new System.Windows.Forms.TextBox();
            this.button_finalizarpedido = new System.Windows.Forms.Button();
            this.button_finalizarvenda = new System.Windows.Forms.Button();
            this.button_imprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.groupBox_novavenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_itemVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(17, 100);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(42, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Infos.DAL.Venda);
            // 
            // ComboBox_codigoPessoa
            // 
            this.ComboBox_codigoPessoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.ComboBox_codigoPessoa.DataSource = this.pessoaBindingSource;
            this.ComboBox_codigoPessoa.DisplayMember = "Nome";
            this.ComboBox_codigoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_codigoPessoa.FormattingEnabled = true;
            this.ComboBox_codigoPessoa.Location = new System.Drawing.Point(65, 92);
            this.ComboBox_codigoPessoa.Name = "ComboBox_codigoPessoa";
            this.ComboBox_codigoPessoa.Size = new System.Drawing.Size(165, 21);
            this.ComboBox_codigoPessoa.TabIndex = 2;
            this.ComboBox_codigoPessoa.ValueMember = "Código";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Infos.DAL.Pessoa);
            // 
            // button_novavenda
            // 
            this.button_novavenda.Location = new System.Drawing.Point(236, 90);
            this.button_novavenda.Name = "button_novavenda";
            this.button_novavenda.Size = new System.Drawing.Size(75, 23);
            this.button_novavenda.TabIndex = 3;
            this.button_novavenda.Text = "Nova Venda";
            this.button_novavenda.UseVisualStyleBackColor = true;
            this.button_novavenda.Click += new System.EventHandler(this.button_novavenda_Click);
            // 
            // groupBox_novavenda
            // 
            this.groupBox_novavenda.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_novavenda.Controls.Add(this.button_imprimir);
            this.groupBox_novavenda.Controls.Add(this.button_novoitem);
            this.groupBox_novavenda.Controls.Add(this.button_finalizarvenda);
            this.groupBox_novavenda.Controls.Add(this.DataGridView_itemVenda);
            this.groupBox_novavenda.Controls.Add(this.button_finalizarpedido);
            this.groupBox_novavenda.Controls.Add(valorPagoLabel);
            this.groupBox_novavenda.Controls.Add(valorLabel);
            this.groupBox_novavenda.Controls.Add(this.TextBox_valorPago);
            this.groupBox_novavenda.Controls.Add(this.valorTextBox);
            this.groupBox_novavenda.Controls.Add(descontoLabel);
            this.groupBox_novavenda.Controls.Add(quantidadeLabel);
            this.groupBox_novavenda.Controls.Add(this.TextBox_desconto);
            this.groupBox_novavenda.Controls.Add(this.quantidadeTextBox);
            this.groupBox_novavenda.Controls.Add(valorLabel1);
            this.groupBox_novavenda.Controls.Add(codigoProdutoLabel);
            this.groupBox_novavenda.Controls.Add(this.TextBox_valoritens);
            this.groupBox_novavenda.Controls.Add(this.ComboBox_codigoProduto);
            this.groupBox_novavenda.Controls.Add(codigoVendaLabel);
            this.groupBox_novavenda.Controls.Add(this.codigoVendaTextBox);
            this.groupBox_novavenda.Location = new System.Drawing.Point(12, 134);
            this.groupBox_novavenda.Name = "groupBox_novavenda";
            this.groupBox_novavenda.Size = new System.Drawing.Size(754, 372);
            this.groupBox_novavenda.TabIndex = 4;
            this.groupBox_novavenda.TabStop = false;
            this.groupBox_novavenda.Text = "Nova Venda";
            this.groupBox_novavenda.Visible = false;
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataSource = typeof(Infos.DAL.ItemVenda);
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(9, 49);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // codigoVendaTextBox
            // 
            this.codigoVendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "CodigoVenda", true));
            this.codigoVendaTextBox.Location = new System.Drawing.Point(92, 46);
            this.codigoVendaTextBox.Name = "codigoVendaTextBox";
            this.codigoVendaTextBox.ReadOnly = true;
            this.codigoVendaTextBox.Size = new System.Drawing.Size(181, 20);
            this.codigoVendaTextBox.TabIndex = 1;
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(22, 95);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(50, 13);
            codigoProdutoLabel.TabIndex = 2;
            codigoProdutoLabel.Text = " Produto:";
            // 
            // ComboBox_codigoProduto
            // 
            this.ComboBox_codigoProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemVendaBindingSource, "CodigoProduto", true));
            this.ComboBox_codigoProduto.DataSource = this.produtoBindingSource;
            this.ComboBox_codigoProduto.DisplayMember = "Descricao";
            this.ComboBox_codigoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_codigoProduto.FormattingEnabled = true;
            this.ComboBox_codigoProduto.Location = new System.Drawing.Point(92, 92);
            this.ComboBox_codigoProduto.Name = "ComboBox_codigoProduto";
            this.ComboBox_codigoProduto.Size = new System.Drawing.Size(181, 21);
            this.ComboBox_codigoProduto.TabIndex = 3;
            this.ComboBox_codigoProduto.ValueMember = "Codigo";
            this.ComboBox_codigoProduto.SelectedIndexChanged += new System.EventHandler(this.codigoProdutoComboBox_SelectedIndexChanged);
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(15, 135);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(92, 132);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(181, 20);
            this.quantidadeTextBox.TabIndex = 5;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(31, 178);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(92, 175);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // DataGridView_itemVenda
            // 
            this.DataGridView_itemVenda.AllowUserToAddRows = false;
            this.DataGridView_itemVenda.AllowUserToDeleteRows = false;
            this.DataGridView_itemVenda.AutoGenerateColumns = false;
            this.DataGridView_itemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_itemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.DataGridView_itemVenda.DataSource = this.itemVendaBindingSource;
            this.DataGridView_itemVenda.Location = new System.Drawing.Point(296, 19);
            this.DataGridView_itemVenda.Name = "DataGridView_itemVenda";
            this.DataGridView_itemVenda.ReadOnly = true;
            this.DataGridView_itemVenda.Size = new System.Drawing.Size(437, 220);
            this.DataGridView_itemVenda.TabIndex = 8;
            this.DataGridView_itemVenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_itemVenda_CellFormatting);
            // 
            // button_novoitem
            // 
            this.button_novoitem.Location = new System.Drawing.Point(198, 173);
            this.button_novoitem.Name = "button_novoitem";
            this.button_novoitem.Size = new System.Drawing.Size(75, 23);
            this.button_novoitem.TabIndex = 9;
            this.button_novoitem.Text = "Novo Item";
            this.button_novoitem.UseVisualStyleBackColor = true;
            this.button_novoitem.Click += new System.EventHandler(this.button_novoitem_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(System.Data.Linq.EntitySet<Infos.DAL.Produto>);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(537, 252);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 4;
            valorLabel1.Text = "Valor:";
            // 
            // TextBox_valoritens
            // 
            this.TextBox_valoritens.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.TextBox_valoritens.Location = new System.Drawing.Point(577, 245);
            this.TextBox_valoritens.Name = "TextBox_valoritens";
            this.TextBox_valoritens.ReadOnly = true;
            this.TextBox_valoritens.Size = new System.Drawing.Size(100, 20);
            this.TextBox_valoritens.TabIndex = 5;
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(515, 288);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 6;
            descontoLabel.Text = "Desconto:";
            // 
            // TextBox_desconto
            // 
            this.TextBox_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.TextBox_desconto.Location = new System.Drawing.Point(577, 285);
            this.TextBox_desconto.Name = "TextBox_desconto";
            this.TextBox_desconto.ReadOnly = true;
            this.TextBox_desconto.Size = new System.Drawing.Size(100, 20);
            this.TextBox_desconto.TabIndex = 7;
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(509, 324);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(62, 13);
            valorPagoLabel.TabIndex = 8;
            valorPagoLabel.Text = "Valor Pago:";
            // 
            // TextBox_valorPago
            // 
            this.TextBox_valorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.TextBox_valorPago.Location = new System.Drawing.Point(577, 321);
            this.TextBox_valorPago.Name = "TextBox_valorPago";
            this.TextBox_valorPago.ReadOnly = true;
            this.TextBox_valorPago.Size = new System.Drawing.Size(100, 20);
            this.TextBox_valorPago.TabIndex = 9;
            // 
            // button_finalizarpedido
            // 
            this.button_finalizarpedido.Location = new System.Drawing.Point(361, 245);
            this.button_finalizarpedido.Name = "button_finalizarpedido";
            this.button_finalizarpedido.Size = new System.Drawing.Size(118, 22);
            this.button_finalizarpedido.TabIndex = 10;
            this.button_finalizarpedido.Text = "Finalizar Pedido";
            this.button_finalizarpedido.UseVisualStyleBackColor = true;
            this.button_finalizarpedido.Click += new System.EventHandler(this.button_finalizarpedido_Click);
            // 
            // button_finalizarvenda
            // 
            this.button_finalizarvenda.Enabled = false;
            this.button_finalizarvenda.Location = new System.Drawing.Point(361, 283);
            this.button_finalizarvenda.Name = "button_finalizarvenda";
            this.button_finalizarvenda.Size = new System.Drawing.Size(118, 22);
            this.button_finalizarvenda.TabIndex = 11;
            this.button_finalizarvenda.Text = "Finalizar Venda";
            this.button_finalizarvenda.UseVisualStyleBackColor = true;
            this.button_finalizarvenda.Click += new System.EventHandler(this.button_finalizarvenda_Click);
            // 
            // button_imprimir
            // 
            this.button_imprimir.Enabled = false;
            this.button_imprimir.Location = new System.Drawing.Point(361, 319);
            this.button_imprimir.Name = "button_imprimir";
            this.button_imprimir.Size = new System.Drawing.Size(118, 22);
            this.button_imprimir.TabIndex = 12;
            this.button_imprimir.Text = "Imprimir";
            this.button_imprimir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 44);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELETRÔNICOS   D\'SANTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_novavenda);
            this.Controls.Add(this.button_novavenda);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.ComboBox_codigoPessoa);
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVenda_FormClosed);
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.groupBox_novavenda.ResumeLayout(false);
            this.groupBox_novavenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_itemVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox ComboBox_codigoPessoa;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.Button button_novavenda;
        private System.Windows.Forms.GroupBox groupBox_novavenda;
        private System.Windows.Forms.Button button_novoitem;
        private System.Windows.Forms.DataGridView DataGridView_itemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.ComboBox ComboBox_codigoProduto;
        private System.Windows.Forms.TextBox codigoVendaTextBox;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox TextBox_valoritens;
        private System.Windows.Forms.TextBox TextBox_desconto;
        private System.Windows.Forms.TextBox TextBox_valorPago;
        private System.Windows.Forms.Button button_finalizarpedido;
        private System.Windows.Forms.Button button_finalizarvenda;
        private System.Windows.Forms.Button button_imprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}