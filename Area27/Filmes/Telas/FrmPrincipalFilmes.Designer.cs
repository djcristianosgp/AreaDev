namespace Filmes.Telas
{
    partial class FrmPrincipalFilmes
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
            this.ssPrincipal = new System.Windows.Forms.StatusStrip();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.muArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.muFilmes = new System.Windows.Forms.ToolStripMenuItem();
            this.miListarFilmes = new System.Windows.Forms.ToolStripMenuItem();
            this.miExecutaOrganizacao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssPrincipal
            // 
            this.ssPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssPrincipal.Location = new System.Drawing.Point(0, 428);
            this.ssPrincipal.Name = "ssPrincipal";
            this.ssPrincipal.Size = new System.Drawing.Size(800, 22);
            this.ssPrincipal.TabIndex = 1;
            this.ssPrincipal.Text = "statusStrip1";
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muArquivo,
            this.muFilmes});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(800, 28);
            this.mnPrincipal.TabIndex = 2;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // muArquivo
            // 
            this.muArquivo.Name = "muArquivo";
            this.muArquivo.Size = new System.Drawing.Size(75, 24);
            this.muArquivo.Text = "Arquivo";
            // 
            // muFilmes
            // 
            this.muFilmes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miListarFilmes,
            this.miExecutaOrganizacao});
            this.muFilmes.Name = "muFilmes";
            this.muFilmes.Size = new System.Drawing.Size(65, 24);
            this.muFilmes.Text = "Filmes";
            // 
            // miListarFilmes
            // 
            this.miListarFilmes.Name = "miListarFilmes";
            this.miListarFilmes.Size = new System.Drawing.Size(236, 26);
            this.miListarFilmes.Text = "Listar Filmes";
            this.miListarFilmes.Click += new System.EventHandler(this.miListarFilmes_Click);
            // 
            // miExecutaOrganizacao
            // 
            this.miExecutaOrganizacao.Name = "miExecutaOrganizacao";
            this.miExecutaOrganizacao.Size = new System.Drawing.Size(236, 26);
            this.miExecutaOrganizacao.Text = "Executar Organização";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssPrincipal);
            this.Controls.Add(this.mnPrincipal);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmes - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip ssPrincipal;
        private MenuStrip mnPrincipal;
        private ToolStripMenuItem muArquivo;
        private ToolStripMenuItem muFilmes;
        private ToolStripMenuItem miListarFilmes;
        private ToolStripMenuItem miExecutaOrganizacao;
    }
}