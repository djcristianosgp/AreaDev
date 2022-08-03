namespace Musicas.Telas
{
    partial class FrmDadosMusica
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
            this.txtRetorno = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblMusica = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRetorno
            // 
            this.txtRetorno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRetorno.Location = new System.Drawing.Point(0, 80);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(546, 370);
            this.txtRetorno.TabIndex = 0;
            this.txtRetorno.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMusica);
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 80);
            this.panel1.TabIndex = 1;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExecutar.Location = new System.Drawing.Point(471, 0);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 80);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblMusica
            // 
            this.lblMusica.AutoSize = true;
            this.lblMusica.Location = new System.Drawing.Point(12, 9);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(38, 15);
            this.lblMusica.TabIndex = 1;
            this.lblMusica.Text = "label1";
            // 
            // FrmDadosMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDadosMusica";
            this.Text = "FrmDadosMusica";
            this.Load += new System.EventHandler(this.FrmDadosMusica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox txtRetorno;
        private Panel panel1;
        private Label lblMusica;
        private Button btnExecutar;
    }
}