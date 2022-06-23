namespace auladeSexta
{
    partial class principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automóveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCarrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.consutarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frToolStripMenuItem
            // 
            this.frToolStripMenuItem.Name = "frToolStripMenuItem";
            this.frToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sairToolStripMenuItem.Text = "Arquivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem1.Text = "Configuarar Impressora";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automóveisToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // automóveisToolStripMenuItem
            // 
            this.automóveisToolStripMenuItem.Name = "automóveisToolStripMenuItem";
            this.automóveisToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.automóveisToolStripMenuItem.Text = "Automóveis";
            this.automóveisToolStripMenuItem.Click += new System.EventHandler(this.automóveisToolStripMenuItem_Click);
            // 
            // consutarToolStripMenuItem
            // 
            this.consutarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCarrosToolStripMenuItem});
            this.consutarToolStripMenuItem.Name = "consutarToolStripMenuItem";
            this.consutarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.consutarToolStripMenuItem.Text = "Consutar";
            // 
            // consultarCarrosToolStripMenuItem
            // 
            this.consultarCarrosToolStripMenuItem.Name = "consultarCarrosToolStripMenuItem";
            this.consultarCarrosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarCarrosToolStripMenuItem.Text = "Consultar Carros ";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.Text = "Sistema de cadastro de automoveis ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem frToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem automóveisToolStripMenuItem;
        private ToolStripMenuItem consutarToolStripMenuItem;
        private ToolStripMenuItem consultarCarrosToolStripMenuItem;
    }
}