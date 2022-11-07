namespace ClasseGenerator.Telas
{
    partial class frmGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbGenerator = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grFuncoes = new System.Windows.Forms.GroupBox();
            this.btnListarTabelas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.cbxDriverBanco = new System.Windows.Forms.ComboBox();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stGenerator = new System.Windows.Forms.StatusStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.tbGenerator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grFuncoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGenerator
            // 
            this.tbGenerator.Controls.Add(this.tabPage1);
            this.tbGenerator.Controls.Add(this.tabPage2);
            this.tbGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGenerator.Location = new System.Drawing.Point(0, 48);
            this.tbGenerator.Name = "tbGenerator";
            this.tbGenerator.SelectedIndex = 0;
            this.tbGenerator.Size = new System.Drawing.Size(585, 308);
            this.tbGenerator.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grFuncoes);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parâmtros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grFuncoes
            // 
            this.grFuncoes.Controls.Add(this.button1);
            this.grFuncoes.Controls.Add(this.btnListarTabelas);
            this.grFuncoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.grFuncoes.Enabled = false;
            this.grFuncoes.Location = new System.Drawing.Point(206, 3);
            this.grFuncoes.Name = "grFuncoes";
            this.grFuncoes.Size = new System.Drawing.Size(200, 274);
            this.grFuncoes.TabIndex = 8;
            this.grFuncoes.TabStop = false;
            this.grFuncoes.Text = "Funções";
            // 
            // btnListarTabelas
            // 
            this.btnListarTabelas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarTabelas.Location = new System.Drawing.Point(3, 19);
            this.btnListarTabelas.Name = "btnListarTabelas";
            this.btnListarTabelas.Size = new System.Drawing.Size(194, 31);
            this.btnListarTabelas.TabIndex = 7;
            this.btnListarTabelas.Text = "Listar Tabelas";
            this.btnListarTabelas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTestarConexao);
            this.groupBox1.Controls.Add(this.cbxDriverBanco);
            this.groupBox1.Controls.Add(this.txtDataBase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHost);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 274);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Driver:";
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Location = new System.Drawing.Point(6, 154);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(187, 23);
            this.btnTestarConexao.TabIndex = 6;
            this.btnTestarConexao.Text = "Testar";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // cbxDriverBanco
            // 
            this.cbxDriverBanco.FormattingEnabled = true;
            this.cbxDriverBanco.Items.AddRange(new object[] {
            "FIREBIRD"});
            this.cbxDriverBanco.Location = new System.Drawing.Point(6, 37);
            this.cbxDriverBanco.Name = "cbxDriverBanco";
            this.cbxDriverBanco.Size = new System.Drawing.Size(187, 23);
            this.cbxDriverBanco.TabIndex = 1;
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(6, 125);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(187, 23);
            this.txtDataBase.TabIndex = 5;
            this.txtDataBase.Text = "D:\\RG_BD\\Cidadao\\SGP_CIDADAO.FDB";
            this.txtDataBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Host:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "DataBase:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(6, 81);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(187, 23);
            this.txtHost.TabIndex = 3;
            this.txtHost.Text = "localhost";
            this.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabelas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stGenerator
            // 
            this.stGenerator.Location = new System.Drawing.Point(0, 356);
            this.stGenerator.Name = "stGenerator";
            this.stGenerator.Size = new System.Drawing.Size(585, 22);
            this.stGenerator.TabIndex = 2;
            this.stGenerator.Text = "statusStrip1";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Listar Tabelas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 378);
            this.Controls.Add(this.tbGenerator);
            this.Controls.Add(this.stGenerator);
            this.Controls.Add(this.label1);
            this.Name = "frmGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator";
            this.Load += new System.EventHandler(this.frmGenerator_Load);
            this.tbGenerator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grFuncoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabControl tbGenerator;
        private TabPage tabPage1;
        private ComboBox cbxDriverBanco;
        private Label label2;
        private TabPage tabPage2;
        private StatusStrip stGenerator;
        private TextBox txtDataBase;
        private Label label4;
        private TextBox txtHost;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnTestarConexao;
        private GroupBox grFuncoes;
        private Button btnListarTabelas;
        private Button button1;
    }
}