namespace area_27_dashboard.Views
{
    partial class FrmGerarChaveLiberacao
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            nmDias = new NumericUpDown();
            btnGerarChave = new Button();
            label2 = new Label();
            dtpDataValidade = new DateTimePicker();
            txtDescricaoCliente = new TextBox();
            txtCodCliente = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtChave = new RichTextBox();
            btnChecarChave = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDias).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nmDias);
            groupBox1.Controls.Add(btnGerarChave);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpDataValidade);
            groupBox1.Controls.Add(txtDescricaoCliente);
            groupBox1.Controls.Add(txtCodCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da liberação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 64);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 9;
            label3.Text = "Dias:";
            // 
            // nmDias
            // 
            nmDias.Location = new Point(218, 82);
            nmDias.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nmDias.Name = "nmDias";
            nmDias.Size = new Size(71, 23);
            nmDias.TabIndex = 8;
            nmDias.TextAlign = HorizontalAlignment.Center;
            nmDias.ValueChanged += nmDias_ValueChanged;
            // 
            // btnGerarChave
            // 
            btnGerarChave.Dock = DockStyle.Bottom;
            btnGerarChave.Location = new Point(3, 111);
            btnGerarChave.Name = "btnGerarChave";
            btnGerarChave.Size = new Size(537, 31);
            btnGerarChave.TabIndex = 7;
            btnGerarChave.Text = "Gerar Chave";
            btnGerarChave.UseVisualStyleBackColor = true;
            btnGerarChave.Click += btnGerarChave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Validade:";
            // 
            // dtpDataValidade
            // 
            dtpDataValidade.Location = new Point(12, 81);
            dtpDataValidade.Name = "dtpDataValidade";
            dtpDataValidade.Size = new Size(200, 23);
            dtpDataValidade.TabIndex = 5;
            dtpDataValidade.ValueChanged += dtpDataValidade_ValueChanged;
            // 
            // txtDescricaoCliente
            // 
            txtDescricaoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricaoCliente.BackColor = Color.White;
            txtDescricaoCliente.Location = new Point(62, 37);
            txtDescricaoCliente.Name = "txtDescricaoCliente";
            txtDescricaoCliente.ReadOnly = true;
            txtDescricaoCliente.Size = new Size(469, 23);
            txtDescricaoCliente.TabIndex = 4;
            // 
            // txtCodCliente
            // 
            txtCodCliente.Location = new Point(12, 37);
            txtCodCliente.Name = "txtCodCliente";
            txtCodCliente.Size = new Size(44, 23);
            txtCodCliente.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtChave);
            groupBox2.Controls.Add(btnChecarChave);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(543, 166);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chave de liberação";
            // 
            // txtChave
            // 
            txtChave.Dock = DockStyle.Fill;
            txtChave.Location = new Point(3, 19);
            txtChave.Name = "txtChave";
            txtChave.Size = new Size(537, 113);
            txtChave.TabIndex = 9;
            txtChave.Text = "";
            // 
            // btnChecarChave
            // 
            btnChecarChave.Dock = DockStyle.Bottom;
            btnChecarChave.Location = new Point(3, 132);
            btnChecarChave.Name = "btnChecarChave";
            btnChecarChave.Size = new Size(537, 31);
            btnChecarChave.TabIndex = 8;
            btnChecarChave.Text = "Gerar Chave";
            btnChecarChave.UseVisualStyleBackColor = true;
            btnChecarChave.Click += btnChecarChave_Click;
            // 
            // groupBox3
            // 
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(543, 240);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Histórico";
            // 
            // FrmGerarChaveLiberacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 551);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmGerarChaveLiberacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGerarChaveLiberacao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDias).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDescricaoCliente;
        private TextBox txtCodCliente;
        private Label label1;
        private Button btnGerarChave;
        private Label label2;
        private DateTimePicker dtpDataValidade;
        private GroupBox groupBox2;
        private RichTextBox txtChave;
        private Button btnChecarChave;
        private GroupBox groupBox3;
        private NumericUpDown nmDias;
        private Label label3;
    }
}