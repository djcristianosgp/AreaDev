namespace ClasseGenerator.Telas
{
    partial class frmPrincipal
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
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnGerador = new System.Windows.Forms.ToolStripMenuItem();
            this.stPrincipal = new System.Windows.Forms.StatusStrip();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArquivo,
            this.mnGerador});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnPrincipal.TabIndex = 0;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // mnArquivo
            // 
            this.mnArquivo.Name = "mnArquivo";
            this.mnArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnArquivo.Text = "Arquivo";
            // 
            // mnGerador
            // 
            this.mnGerador.Name = "mnGerador";
            this.mnGerador.Size = new System.Drawing.Size(61, 20);
            this.mnGerador.Text = "Gerador";
            this.mnGerador.Click += new System.EventHandler(this.mnGerador_Click);
            // 
            // stPrincipal
            // 
            this.stPrincipal.Location = new System.Drawing.Point(0, 428);
            this.stPrincipal.Name = "stPrincipal";
            this.stPrincipal.Size = new System.Drawing.Size(800, 22);
            this.stPrincipal.TabIndex = 2;
            this.stPrincipal.Text = "statusStrip1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stPrincipal);
            this.Controls.Add(this.mnPrincipal);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnPrincipal;
        private ToolStripMenuItem mnArquivo;
        private ToolStripMenuItem mnGerador;
        private StatusStrip stPrincipal;
    }
}