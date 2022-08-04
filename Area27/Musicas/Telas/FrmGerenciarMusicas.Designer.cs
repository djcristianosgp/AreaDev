namespace Musicas.Telas
{
    partial class FrmGerenciarMusicas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtListaMusicas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPastaOrigem = new System.Windows.Forms.TextBox();
            this.txtPastaDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscaPastaOrigem = new System.Windows.Forms.Button();
            this.btnBuscaPastaDestino = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxOrganizarPor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaMusicas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnBuscaPastaDestino);
            this.panel1.Controls.Add(this.btnBuscaPastaOrigem);
            this.panel1.Controls.Add(this.txtPastaDestino);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPastaOrigem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 90);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 53);
            this.panel2.TabIndex = 1;
            // 
            // dtListaMusicas
            // 
            this.dtListaMusicas.AllowUserToAddRows = false;
            this.dtListaMusicas.AllowUserToOrderColumns = true;
            this.dtListaMusicas.BackgroundColor = System.Drawing.Color.White;
            this.dtListaMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaMusicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListaMusicas.Location = new System.Drawing.Point(0, 90);
            this.dtListaMusicas.Name = "dtListaMusicas";
            this.dtListaMusicas.RowTemplate.Height = 25;
            this.dtListaMusicas.Size = new System.Drawing.Size(507, 247);
            this.dtListaMusicas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a Pasta de Origem:";
            // 
            // txtPastaOrigem
            // 
            this.txtPastaOrigem.Location = new System.Drawing.Point(4, 20);
            this.txtPastaOrigem.Name = "txtPastaOrigem";
            this.txtPastaOrigem.Size = new System.Drawing.Size(292, 22);
            this.txtPastaOrigem.TabIndex = 1;
            this.txtPastaOrigem.Text = "D:\\Users\\Homologacao01\\Music\\Musica Eletronica\\";
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.Location = new System.Drawing.Point(4, 61);
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.Size = new System.Drawing.Size(292, 22);
            this.txtPastaDestino.TabIndex = 3;
            this.txtPastaDestino.Text = "D:\\Users\\Homologacao01\\Music\\Organizadas\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione a Pasta de Destino:";
            // 
            // btnBuscaPastaOrigem
            // 
            this.btnBuscaPastaOrigem.Location = new System.Drawing.Point(302, 19);
            this.btnBuscaPastaOrigem.Name = "btnBuscaPastaOrigem";
            this.btnBuscaPastaOrigem.Size = new System.Drawing.Size(26, 23);
            this.btnBuscaPastaOrigem.TabIndex = 4;
            this.btnBuscaPastaOrigem.Text = "...";
            this.btnBuscaPastaOrigem.UseVisualStyleBackColor = true;
            // 
            // btnBuscaPastaDestino
            // 
            this.btnBuscaPastaDestino.Location = new System.Drawing.Point(302, 60);
            this.btnBuscaPastaDestino.Name = "btnBuscaPastaDestino";
            this.btnBuscaPastaDestino.Size = new System.Drawing.Size(26, 23);
            this.btnBuscaPastaDestino.TabIndex = 5;
            this.btnBuscaPastaDestino.Text = "...";
            this.btnBuscaPastaDestino.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnListar.Location = new System.Drawing.Point(569, 0);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(95, 90);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxOrganizarPor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(507, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Organizar Por:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxOrganizarPor
            // 
            this.cbxOrganizarPor.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxOrganizarPor.FormattingEnabled = true;
            this.cbxOrganizarPor.Location = new System.Drawing.Point(3, 40);
            this.cbxOrganizarPor.Name = "cbxOrganizarPor";
            this.cbxOrganizarPor.Size = new System.Drawing.Size(151, 21);
            this.cbxOrganizarPor.TabIndex = 2;
            // 
            // FrmGerenciarMusicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 390);
            this.Controls.Add(this.dtListaMusicas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmGerenciarMusicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Musicas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGerenciarMusicas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaMusicas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnBuscaPastaDestino;
        private Button btnBuscaPastaOrigem;
        private TextBox txtPastaDestino;
        private Label label2;
        private TextBox txtPastaOrigem;
        private Label label1;
        private Panel panel2;
        private DataGridView dtListaMusicas;
        private Button btnListar;
        private GroupBox groupBox1;
        private ComboBox cbxOrganizarPor;
        private Label label3;
    }
}