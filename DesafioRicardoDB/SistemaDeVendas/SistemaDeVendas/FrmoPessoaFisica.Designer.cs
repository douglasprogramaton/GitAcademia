namespace SistemaDeVendas
{
    partial class FrmoPessoaFisica
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cPFLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmoPessoaFisica));
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.pessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_novo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(18, 74);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(333, 106);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 3;
            telefoneLabel.Text = "Telefone:";
            telefoneLabel.Click += new System.EventHandler(this.telefoneLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(21, 110);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(355, 74);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 7;
            cPFLabel.Text = "CPF:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(62, 67);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(227, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Infos.DAL.Pessoa);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(391, 103);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(129, 20);
            this.telefoneTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(62, 106);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(227, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(391, 67);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(129, 20);
            this.cPFTextBox.TabIndex = 8;
            // 
            // pessoaDataGridView
            // 
            this.pessoaDataGridView.AllowUserToAddRows = false;
            this.pessoaDataGridView.AllowUserToDeleteRows = false;
            this.pessoaDataGridView.AutoGenerateColumns = false;
            this.pessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pessoaDataGridView.DataSource = this.pessoaBindingSource;
            this.pessoaDataGridView.Location = new System.Drawing.Point(21, 145);
            this.pessoaDataGridView.Name = "pessoaDataGridView";
            this.pessoaDataGridView.ReadOnly = true;
            this.pessoaDataGridView.Size = new System.Drawing.Size(544, 220);
            this.pessoaDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Código";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn5.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // button_excluir
            // 
            this.button_excluir.Location = new System.Drawing.Point(388, 371);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 23);
            this.button_excluir.TabIndex = 13;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(293, 371);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 12;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_gravar
            // 
            this.button_gravar.Location = new System.Drawing.Point(198, 371);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(75, 22);
            this.button_gravar.TabIndex = 11;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = true;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_novo
            // 
            this.button_novo.Location = new System.Drawing.Point(100, 371);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(75, 23);
            this.button_novo.TabIndex = 10;
            this.button_novo.Text = "Novo";
            this.button_novo.UseVisualStyleBackColor = true;
            this.button_novo.Click += new System.EventHandler(this.button_novo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 44);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELETRÔNICOS   D\'SANTOS";
            // 
            // FrmoPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_gravar);
            this.Controls.Add(this.button_novo);
            this.Controls.Add(this.pessoaDataGridView);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Name = "FrmoPessoaFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCliente_FormClosed);
            this.Load += new System.EventHandler(this.FrmoPessoaFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.DataGridView pessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_gravar;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}