namespace PrimeiroWinForms
{
    partial class Form1
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
            this.BTOK = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.LBLNome = new System.Windows.Forms.Label();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.TXTNome = new System.Windows.Forms.TextBox();
            this.TXTEndereço = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTTelefone = new System.Windows.Forms.Label();
            this.TXTBairro = new System.Windows.Forms.Label();
            this.TXTSexo = new System.Windows.Forms.Label();
            this.TXTCidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(42, 316);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(211, 50);
            this.BTOK.TabIndex = 0;
            this.BTOK.Text = "Ok";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(42, 386);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(211, 52);
            this.BTCancelar.TabIndex = 1;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // LBLNome
            // 
            this.LBLNome.AutoSize = true;
            this.LBLNome.Location = new System.Drawing.Point(27, 31);
            this.LBLNome.Name = "LBLNome";
            this.LBLNome.Size = new System.Drawing.Size(43, 15);
            this.LBLNome.TabIndex = 3;
            this.LBLNome.Text = "Nome:";
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Location = new System.Drawing.Point(32, 60);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(39, 15);
            this.LBLEmail.TabIndex = 4;
            this.LBLEmail.Text = "Email:";
            // 
            // TXTEmail
            // 
            this.TXTEmail.Location = new System.Drawing.Point(77, 52);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(210, 23);
            this.TXTEmail.TabIndex = 5;
            this.TXTEmail.UseSystemPasswordChar = true;
            this.TXTEmail.Visible = false;
            // 
            // TXTNome
            // 
            this.TXTNome.Location = new System.Drawing.Point(76, 23);
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(211, 23);
            this.TXTNome.TabIndex = 6;
            // 
            // TXTEndereço
            // 
            this.TXTEndereço.Location = new System.Drawing.Point(77, 81);
            this.TXTEndereço.Name = "TXTEndereço";
            this.TXTEndereço.Size = new System.Drawing.Size(210, 23);
            this.TXTEndereço.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 23);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 197);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(208, 23);
            this.textBox5.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Endereço:";
            // 
            // TXTTelefone
            // 
            this.TXTTelefone.AutoSize = true;
            this.TXTTelefone.Location = new System.Drawing.Point(16, 118);
            this.TXTTelefone.Name = "TXTTelefone";
            this.TXTTelefone.Size = new System.Drawing.Size(54, 15);
            this.TXTTelefone.TabIndex = 14;
            this.TXTTelefone.Text = "Telefone:";
            // 
            // TXTBairro
            // 
            this.TXTBairro.AutoSize = true;
            this.TXTBairro.Location = new System.Drawing.Point(24, 147);
            this.TXTBairro.Name = "TXTBairro";
            this.TXTBairro.Size = new System.Drawing.Size(41, 15);
            this.TXTBairro.TabIndex = 15;
            this.TXTBairro.Text = "Bairro:";
            // 
            // TXTSexo
            // 
            this.TXTSexo.AutoSize = true;
            this.TXTSexo.Location = new System.Drawing.Point(24, 205);
            this.TXTSexo.Name = "TXTSexo";
            this.TXTSexo.Size = new System.Drawing.Size(35, 15);
            this.TXTSexo.TabIndex = 16;
            this.TXTSexo.Text = "Sexo:";
            // 
            // TXTCidade
            // 
            this.TXTCidade.AutoSize = true;
            this.TXTCidade.Location = new System.Drawing.Point(23, 176);
            this.TXTCidade.Name = "TXTCidade";
            this.TXTCidade.Size = new System.Drawing.Size(47, 15);
            this.TXTCidade.TabIndex = 17;
            this.TXTCidade.Text = "Cidade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTCidade);
            this.Controls.Add(this.TXTSexo);
            this.Controls.Add(this.TXTBairro);
            this.Controls.Add(this.TXTTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TXTEndereço);
            this.Controls.Add(this.TXTNome);
            this.Controls.Add(this.TXTEmail);
            this.Controls.Add(this.LBLEmail);
            this.Controls.Add(this.LBLNome);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.BTOK);
            this.Name = "Form1";
            this.Text = "Formulario da minha primeira aplicação ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTOK;
        private Button BTCancelar;
        private Label LBLNome;
        private Label LBLEmail;
        private TextBox TXTEmail;
        private TextBox TXTNome;
        private TextBox TXTEndereço;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label TXTTelefone;
        private Label TXTBairro;
        private Label TXTSexo;
        private Label TXTCidade;
    }
}