namespace ESTACIONAMENTO
{
    partial class frmCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastros));
            this.button_Limpar = new System.Windows.Forms.Button();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.textBox_Horario = new System.Windows.Forms.TextBox();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.textBox_Placa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Saida = new System.Windows.Forms.Panel();
            this.textBox_HoraSaida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_Saida = new System.Windows.Forms.TextBox();
            this.label_Saida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Guardados = new System.Windows.Forms.TextBox();
            this.panel_Saida.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Limpar
            // 
            this.button_Limpar.BackColor = System.Drawing.Color.Transparent;
            this.button_Limpar.FlatAppearance.BorderSize = 0;
            this.button_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Limpar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Limpar.Location = new System.Drawing.Point(116, 196);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(88, 35);
            this.button_Limpar.TabIndex = 39;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = false;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // button_Salvar
            // 
            this.button_Salvar.BackColor = System.Drawing.Color.Transparent;
            this.button_Salvar.FlatAppearance.BorderSize = 0;
            this.button_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Salvar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Salvar.Location = new System.Drawing.Point(8, 196);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(88, 35);
            this.button_Salvar.TabIndex = 38;
            this.button_Salvar.Text = "Salvar";
            this.button_Salvar.UseVisualStyleBackColor = false;
            this.button_Salvar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // textBox_Horario
            // 
            this.textBox_Horario.Location = new System.Drawing.Point(116, 124);
            this.textBox_Horario.Name = "textBox_Horario";
            this.textBox_Horario.PlaceholderText = "__:__:__";
            this.textBox_Horario.Size = new System.Drawing.Size(100, 23);
            this.textBox_Horario.TabIndex = 37;
            this.textBox_Horario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(116, 83);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.PlaceholderText = "__/__/__";
            this.textBox_Data.Size = new System.Drawing.Size(100, 23);
            this.textBox_Data.TabIndex = 36;
            this.textBox_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Placa
            // 
            this.textBox_Placa.Location = new System.Drawing.Point(116, 39);
            this.textBox_Placa.Name = "textBox_Placa";
            this.textBox_Placa.PlaceholderText = "__________";
            this.textBox_Placa.Size = new System.Drawing.Size(100, 23);
            this.textBox_Placa.TabIndex = 35;
            this.textBox_Placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Horário: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Placa:";
            // 
            // panel_Saida
            // 
            this.panel_Saida.BackColor = System.Drawing.Color.Transparent;
            this.panel_Saida.Controls.Add(this.textBox_HoraSaida);
            this.panel_Saida.Controls.Add(this.label5);
            this.panel_Saida.Controls.Add(this.button2);
            this.panel_Saida.Controls.Add(this.textBox_Saida);
            this.panel_Saida.Controls.Add(this.label_Saida);
            this.panel_Saida.Controls.Add(this.button_Limpar);
            this.panel_Saida.Controls.Add(this.label4);
            this.panel_Saida.Controls.Add(this.button_Salvar);
            this.panel_Saida.Controls.Add(this.textBox_Guardados);
            this.panel_Saida.Controls.Add(this.textBox_Horario);
            this.panel_Saida.Controls.Add(this.label1);
            this.panel_Saida.Controls.Add(this.textBox_Data);
            this.panel_Saida.Controls.Add(this.label2);
            this.panel_Saida.Controls.Add(this.textBox_Placa);
            this.panel_Saida.Controls.Add(this.label3);
            this.panel_Saida.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Saida.Location = new System.Drawing.Point(83, 0);
            this.panel_Saida.Name = "panel_Saida";
            this.panel_Saida.Size = new System.Drawing.Size(373, 515);
            this.panel_Saida.TabIndex = 1;
            // 
            // textBox_HoraSaida
            // 
            this.textBox_HoraSaida.Location = new System.Drawing.Point(116, 170);
            this.textBox_HoraSaida.Name = "textBox_HoraSaida";
            this.textBox_HoraSaida.PlaceholderText = "__:__:__";
            this.textBox_HoraSaida.Size = new System.Drawing.Size(100, 23);
            this.textBox_HoraSaida.TabIndex = 47;
            this.textBox_HoraSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(-1, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Hora saida";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(58, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 45;
            this.button2.Text = "Saida";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Saida
            // 
            this.textBox_Saida.Enabled = false;
            this.textBox_Saida.Location = new System.Drawing.Point(230, 170);
            this.textBox_Saida.Multiline = true;
            this.textBox_Saida.Name = "textBox_Saida";
            this.textBox_Saida.Size = new System.Drawing.Size(117, 110);
            this.textBox_Saida.TabIndex = 43;
            this.textBox_Saida.TextChanged += new System.EventHandler(this.textBox_Saida_TextChanged);
            // 
            // label_Saida
            // 
            this.label_Saida.AutoSize = true;
            this.label_Saida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Saida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Saida.Location = new System.Drawing.Point(256, 144);
            this.label_Saida.Name = "label_Saida";
            this.label_Saida.Size = new System.Drawing.Size(64, 23);
            this.label_Saida.TabIndex = 42;
            this.label_Saida.Text = "Saida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(256, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Carros";
            // 
            // textBox_Guardados
            // 
            this.textBox_Guardados.Enabled = false;
            this.textBox_Guardados.Location = new System.Drawing.Point(230, 35);
            this.textBox_Guardados.Multiline = true;
            this.textBox_Guardados.Name = "textBox_Guardados";
            this.textBox_Guardados.Size = new System.Drawing.Size(117, 110);
            this.textBox_Guardados.TabIndex = 41;
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 515);
            this.Controls.Add(this.panel_Saida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastros";
            this.panel_Saida.ResumeLayout(false);
            this.panel_Saida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel_Saida;
        private Button button_Limpar;
        private Button button_Salvar;
        private TextBox textBox_Horario;
        private TextBox textBox_Data;
        private TextBox textBox_Placa;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox_Guardados;
        private TextBox textBox_Saida;
        private Label label_Saida;
        private Button button2;
        private TextBox textBox_HoraSaida;
        private Label label5;
    }
}