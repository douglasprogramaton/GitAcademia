namespace auladeSexta
{
    partial class frmAutomovel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbModeloCarro = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.tbFabricanteCarro = new System.Windows.Forms.TextBox();
            this.lblOpcionais = new System.Windows.Forms.Label();
            this.lbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.lblPortas = new System.Windows.Forms.Label();
            this.dgAutomoveis = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ABS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Portas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btCarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(130, 259);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 37);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(272, 259);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 35);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbModeloCarro
            // 
            this.tbModeloCarro.Location = new System.Drawing.Point(130, 40);
            this.tbModeloCarro.Name = "tbModeloCarro";
            this.tbModeloCarro.Size = new System.Drawing.Size(217, 23);
            this.tbModeloCarro.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(24, 43);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(97, 15);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo do Carro";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(13, 73);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(111, 15);
            this.lblFabricante.TabIndex = 4;
            this.lblFabricante.Text = "Fabricante do Carro";
            // 
            // tbFabricanteCarro
            // 
            this.tbFabricanteCarro.Location = new System.Drawing.Point(130, 73);
            this.tbFabricanteCarro.Name = "tbFabricanteCarro";
            this.tbFabricanteCarro.Size = new System.Drawing.Size(217, 23);
            this.tbFabricanteCarro.TabIndex = 5;
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.Location = new System.Drawing.Point(34, 102);
            this.lblOpcionais.Name = "lblOpcionais";
            this.lblOpcionais.Size = new System.Drawing.Size(63, 15);
            this.lblOpcionais.TabIndex = 6;
            this.lblOpcionais.Text = "Opcionais ";
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.FormattingEnabled = true;
            this.lbOpcionais.Items.AddRange(new object[] {
            "Ar concicionado",
            "Direção hidráulica",
            "Freios ABS",
            "Air bag",
            "Vidros elétricos"});
            this.lbOpcionais.Location = new System.Drawing.Point(130, 102);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(217, 94);
            this.lbOpcionais.TabIndex = 7;
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Items.AddRange(new object[] {
            "2 portas",
            "3 portas",
            "4 portas",
            "5 portas"});
            this.cbPortas.Location = new System.Drawing.Point(130, 202);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(217, 23);
            this.cbPortas.TabIndex = 8;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(0, 205);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(121, 15);
            this.lblPortas.TabIndex = 9;
            this.lblPortas.Text = "Quantidade de portas";
            // 
            // dgAutomoveis
            // 
            this.dgAutomoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutomoveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Fabricante,
            this.AC,
            this.DH,
            this.ABS,
            this.VE,
            this.AB,
            this.Portas});
            this.dgAutomoveis.Location = new System.Drawing.Point(353, 40);
            this.dgAutomoveis.Name = "dgAutomoveis";
            this.dgAutomoveis.RowTemplate.Height = 25;
            this.dgAutomoveis.Size = new System.Drawing.Size(425, 185);
            this.dgAutomoveis.TabIndex = 10;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Fabricante
            // 
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            // 
            // AC
            // 
            this.AC.HeaderText = "AC";
            this.AC.Name = "AC";
            // 
            // DH
            // 
            this.DH.HeaderText = "DH";
            this.DH.Name = "DH";
            // 
            // ABS
            // 
            this.ABS.HeaderText = "ABS";
            this.ABS.Name = "ABS";
            // 
            // VE
            // 
            this.VE.HeaderText = "VE";
            this.VE.Name = "VE";
            // 
            // AB
            // 
            this.AB.HeaderText = "AB";
            this.AB.Name = "AB";
            // 
            // Portas
            // 
            this.Portas.HeaderText = "Portas";
            this.Portas.Name = "Portas";
            // 
            // btCarregar
            // 
            this.btCarregar.Location = new System.Drawing.Point(123, 331);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(224, 23);
            this.btCarregar.TabIndex = 11;
            this.btCarregar.Text = "Carregar da lista";
            this.btCarregar.UseVisualStyleBackColor = true;
            // 
            // frmAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCarregar);
            this.Controls.Add(this.dgAutomoveis);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.cbPortas);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.lblOpcionais);
            this.Controls.Add(this.tbFabricanteCarro);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.tbModeloCarro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmAutomovel";
            this.Text = "Cadastrando automoveis";
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvar;
        private Button btnLimpar;
        private TextBox tbModeloCarro;
        private Label lblModelo;
        private Label lblFabricante;
        private TextBox tbFabricanteCarro;
        private Label lblOpcionais;
        private CheckedListBox lbOpcionais;
        private ComboBox cbPortas;
        private Label lblPortas;
        private DataGridView dgAutomoveis;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Fabricante;
        private DataGridViewCheckBoxColumn AC;
        private DataGridViewCheckBoxColumn DH;
        private DataGridViewCheckBoxColumn ABS;
        private DataGridViewCheckBoxColumn VE;
        private DataGridViewCheckBoxColumn AB;
        private DataGridViewCheckBoxColumn Portas;
        private Button btCarregar;
    }
}