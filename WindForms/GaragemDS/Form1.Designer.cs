namespace GaragemDS
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
            this.panel_superior = new System.Windows.Forms.Panel();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_fechar = new System.Windows.Forms.Button();
            this.panel_centro = new System.Windows.Forms.Panel();
            this.button_inicio = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.panel_escolha = new System.Windows.Forms.Panel();
            this.panel_superior.SuspendLayout();
            this.panel_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.Transparent;
            this.panel_superior.Controls.Add(this.button_minimizar);
            this.panel_superior.Controls.Add(this.button_fechar);
            this.panel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_superior.Location = new System.Drawing.Point(0, 0);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(1221, 48);
            this.panel_superior.TabIndex = 0;
            // 
            // button_minimizar
            // 
            this.button_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_minimizar.BackgroundImage")));
            this.button_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_minimizar.FlatAppearance.BorderSize = 0;
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimizar.Location = new System.Drawing.Point(1100, 3);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(45, 42);
            this.button_minimizar.TabIndex = 1;
            this.button_minimizar.UseVisualStyleBackColor = true;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // button_fechar
            // 
            this.button_fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_fechar.BackgroundImage")));
            this.button_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fechar.FlatAppearance.BorderSize = 0;
            this.button_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fechar.Location = new System.Drawing.Point(1164, 3);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(45, 42);
            this.button_fechar.TabIndex = 0;
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // panel_centro
            // 
            this.panel_centro.BackColor = System.Drawing.Color.Transparent;
            this.panel_centro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_centro.Location = new System.Drawing.Point(256, 48);
            this.panel_centro.Name = "panel_centro";
            this.panel_centro.Size = new System.Drawing.Size(965, 631);
            this.panel_centro.TabIndex = 1;
            // 
            // button_inicio
            // 
            this.button_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inicio.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_inicio.Location = new System.Drawing.Point(87, 184);
            this.button_inicio.Name = "button_inicio";
            this.button_inicio.Size = new System.Drawing.Size(148, 57);
            this.button_inicio.TabIndex = 0;
            this.button_inicio.Text = "Início";
            this.button_inicio.UseVisualStyleBackColor = true;
            this.button_inicio.Click += new System.EventHandler(this.button_inicio_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastrar.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cadastrar.Location = new System.Drawing.Point(87, 272);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(148, 57);
            this.button_cadastrar.TabIndex = 1;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.Transparent;
            this.panel_lateral.Controls.Add(this.panel_escolha);
            this.panel_lateral.Controls.Add(this.button_cadastrar);
            this.panel_lateral.Controls.Add(this.button_inicio);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 48);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(256, 631);
            this.panel_lateral.TabIndex = 1;
            // 
            // panel_escolha
            // 
            this.panel_escolha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_escolha.BackgroundImage")));
            this.panel_escolha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_escolha.Location = new System.Drawing.Point(29, 184);
            this.panel_escolha.Name = "panel_escolha";
            this.panel_escolha.Size = new System.Drawing.Size(52, 57);
            this.panel_escolha.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 679);
            this.Controls.Add(this.panel_centro);
            this.Controls.Add(this.panel_lateral);
            this.Controls.Add(this.panel_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_superior.ResumeLayout(false);
            this.panel_lateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_superior;
        private Panel panel_centro;
        private Button button_inicio;
        private Button button_cadastrar;
        private Panel panel_lateral;
        private Button button_minimizar;
        private Button button_fechar;
        private Panel panel_escolha;
    }
}