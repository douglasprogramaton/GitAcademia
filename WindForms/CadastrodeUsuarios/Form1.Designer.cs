namespace CadastrodeUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lbNome
            // 
            resources.ApplyResources(this.lbNome, "lbNome");
            this.lbNome.Name = "lbNome";
            // 
            // lbTelefone
            // 
            resources.ApplyResources(this.lbTelefone, "lbTelefone");
            this.lbTelefone.Name = "lbTelefone";
            // 
            // tbNome
            // 
            this.tbNome.ForeColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.tbNome, "tbNome");
            this.tbNome.Name = "tbNome";
            // 
            // tbTelefone
            // 
            this.tbTelefone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.tbTelefone, "tbTelefone");
            this.tbTelefone.Name = "tbTelefone";
            // 
            // tbLogin
            // 
            this.tbLogin.ForeColor = System.Drawing.SystemColors.MenuText;
            resources.ApplyResources(this.tbLogin, "tbLogin");
            this.tbLogin.Name = "tbLogin";
            // 
            // tbSenha
            // 
            resources.ApplyResources(this.tbSenha, "tbSenha");
            this.tbSenha.Name = "tbSenha";
            // 
            // lbLogin
            // 
            resources.ApplyResources(this.lbLogin, "lbLogin");
            this.lbLogin.Name = "lbLogin";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbTipo
            // 
            resources.ApplyResources(this.lbTipo, "lbTipo");
            this.lbTipo.Name = "lbTipo";
            // 
            // cbTipo
            // 
            this.cbTipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            resources.GetString("cbTipo.Items"),
            resources.GetString("cbTipo.Items1")});
            resources.ApplyResources(this.cbTipo, "cbTipo");
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Tag = "";
            // 
            // lbCpf
            // 
            resources.ApplyResources(this.lbCpf, "lbCpf");
            this.lbCpf.Name = "lbCpf";
            // 
            // tbCpf
            // 
            this.tbCpf.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.tbCpf, "tbCpf");
            this.tbCpf.Name = "tbCpf";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Name = "label1";
            // 
            // lbStatus
            // 
            resources.ApplyResources(this.lbStatus, "lbStatus");
            this.lbStatus.Name = "lbStatus";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            resources.GetString("cbStatus.Items"),
            resources.GetString("cbStatus.Items1")});
            resources.ApplyResources(this.cbStatus, "cbStatus");
            this.cbStatus.Name = "cbStatus";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadastrodeUsuarios.Properties.Resources.atos_transparente;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOK;
        private Button btnLimpar;
        private Label lbNome;
        private Label lbTelefone;
        private TextBox tbNome;
        private ToolTip toolTip1;
        private TextBox tbTelefone;
        private TextBox tbLogin;
        private TextBox tbSenha;
        private Label lbLogin;
        private Label label3;
        private ComboBox cbTipo;
        private Label lbCpf;
        private TextBox tbCpf;
        private Label label1;
        private Label lbStatus;
        protected Label lbTipo;
        private CheckedListBox cbStatus;
        private PictureBox pictureBox1;
    }
}