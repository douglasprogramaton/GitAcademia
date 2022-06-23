namespace ESTACIONAMENTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Topo = new System.Windows.Forms.Panel();
            this.button_Minimizar = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.panel_Central = new System.Windows.Forms.Panel();
            this.panel_Selecao = new System.Windows.Forms.Panel();
            this.button_Cadastros = new System.Windows.Forms.Button();
            this.button_Inicio = new System.Windows.Forms.Button();
            this.panel_Topo.SuspendLayout();
            this.panel_Central.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Topo
            // 
            this.panel_Topo.BackColor = System.Drawing.Color.Transparent;
            this.panel_Topo.Controls.Add(this.button_Minimizar);
            this.panel_Topo.Controls.Add(this.button_Sair);
            this.panel_Topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Topo.Location = new System.Drawing.Point(0, 0);
            this.panel_Topo.Name = "panel_Topo";
            this.panel_Topo.Size = new System.Drawing.Size(688, 54);
            this.panel_Topo.TabIndex = 0;
            // 
            // button_Minimizar
            // 
            this.button_Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Minimizar.BackgroundImage")));
            this.button_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Minimizar.FlatAppearance.BorderSize = 0;
            this.button_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimizar.Location = new System.Drawing.Point(580, 12);
            this.button_Minimizar.Name = "button_Minimizar";
            this.button_Minimizar.Size = new System.Drawing.Size(39, 36);
            this.button_Minimizar.TabIndex = 1;
            this.button_Minimizar.UseVisualStyleBackColor = true;
            this.button_Minimizar.Click += new System.EventHandler(this.button_Minimizar_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Sair.BackgroundImage")));
            this.button_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Sair.FlatAppearance.BorderSize = 0;
            this.button_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sair.Location = new System.Drawing.Point(637, 12);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(39, 36);
            this.button_Sair.TabIndex = 0;
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // panel_Central
            // 
            this.panel_Central.BackColor = System.Drawing.Color.Transparent;
            this.panel_Central.Controls.Add(this.panel_Selecao);
            this.panel_Central.Controls.Add(this.button_Cadastros);
            this.panel_Central.Controls.Add(this.button_Inicio);
            this.panel_Central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Central.Location = new System.Drawing.Point(0, 54);
            this.panel_Central.Name = "panel_Central";
            this.panel_Central.Size = new System.Drawing.Size(688, 521);
            this.panel_Central.TabIndex = 3;
            // 
            // panel_Selecao
            // 
            this.panel_Selecao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Selecao.BackgroundImage")));
            this.panel_Selecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_Selecao.Location = new System.Drawing.Point(6, 121);
            this.panel_Selecao.Name = "panel_Selecao";
            this.panel_Selecao.Size = new System.Drawing.Size(20, 103);
            this.panel_Selecao.TabIndex = 14;
            // 
            // button_Cadastros
            // 
            this.button_Cadastros.FlatAppearance.BorderSize = 0;
            this.button_Cadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cadastros.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cadastros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Cadastros.Location = new System.Drawing.Point(31, 230);
            this.button_Cadastros.Name = "button_Cadastros";
            this.button_Cadastros.Size = new System.Drawing.Size(181, 103);
            this.button_Cadastros.TabIndex = 13;
            this.button_Cadastros.Text = "Cadastros";
            this.button_Cadastros.UseVisualStyleBackColor = true;
            this.button_Cadastros.Click += new System.EventHandler(this.button_Cadastros_Click_1);
            // 
            // button_Inicio
            // 
            this.button_Inicio.FlatAppearance.BorderSize = 0;
            this.button_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Inicio.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Inicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Inicio.Location = new System.Drawing.Point(32, 121);
            this.button_Inicio.Name = "button_Inicio";
            this.button_Inicio.Size = new System.Drawing.Size(181, 103);
            this.button_Inicio.TabIndex = 12;
            this.button_Inicio.Text = "Início";
            this.button_Inicio.UseVisualStyleBackColor = true;
            this.button_Inicio.Click += new System.EventHandler(this.button_Inicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 575);
            this.Controls.Add(this.panel_Central);
            this.Controls.Add(this.panel_Topo);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Topo.ResumeLayout(false);
            this.panel_Central.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Topo;
        private Button button_Minimizar;
        private Button button_Sair;
        private Panel panel_Central;
        private Panel panel_Selecao;
        private Button button_Cadastros;
        private Button button_Inicio;
    }
}