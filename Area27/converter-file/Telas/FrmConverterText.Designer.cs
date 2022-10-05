namespace converter_file.Telas
{
    partial class FrmConverterText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConverterText));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalvarArquivo = new System.Windows.Forms.Button();
            this.cbxConverterPara = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnLerArquivoSelecionado = new System.Windows.Forms.Button();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.txtArquivoSelecionado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtArquivoOrigem = new System.Windows.Forms.RichTextBox();
            this.btnCopyArquiOrigem = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnCopyResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ofpFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 315);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalvarArquivo);
            this.tabPage1.Controls.Add(this.cbxConverterPara);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnConverter);
            this.tabPage1.Controls.Add(this.btnLerArquivoSelecionado);
            this.tabPage1.Controls.Add(this.btnSelecionarArquivo);
            this.tabPage1.Controls.Add(this.txtArquivoSelecionado);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parametros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSalvarArquivo
            // 
            this.btnSalvarArquivo.Location = new System.Drawing.Point(5, 153);
            this.btnSalvarArquivo.Name = "btnSalvarArquivo";
            this.btnSalvarArquivo.Size = new System.Drawing.Size(548, 23);
            this.btnSalvarArquivo.TabIndex = 7;
            this.btnSalvarArquivo.Text = "Salvar";
            this.btnSalvarArquivo.UseVisualStyleBackColor = true;
            this.btnSalvarArquivo.Click += new System.EventHandler(this.btnSalvarArquivo_Click);
            // 
            // cbxConverterPara
            // 
            this.cbxConverterPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConverterPara.FormattingEnabled = true;
            this.cbxConverterPara.Items.AddRange(new object[] {
            "Html>Rtf",
            "Html>Xaml",
            "Rtf>Html",
            "Xaml>Html",
            ""});
            this.cbxConverterPara.Location = new System.Drawing.Point(5, 95);
            this.cbxConverterPara.Name = "cbxConverterPara";
            this.cbxConverterPara.Size = new System.Drawing.Size(548, 23);
            this.cbxConverterPara.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Converter para:";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(5, 124);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(548, 23);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter Arquivo";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnLerArquivoSelecionado
            // 
            this.btnLerArquivoSelecionado.Location = new System.Drawing.Point(5, 54);
            this.btnLerArquivoSelecionado.Name = "btnLerArquivoSelecionado";
            this.btnLerArquivoSelecionado.Size = new System.Drawing.Size(548, 23);
            this.btnLerArquivoSelecionado.TabIndex = 3;
            this.btnLerArquivoSelecionado.Text = "Ler Arquivo";
            this.btnLerArquivoSelecionado.UseVisualStyleBackColor = true;
            this.btnLerArquivoSelecionado.Click += new System.EventHandler(this.btnLerArquivoSelecionado_Click);
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarArquivo.Image")));
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(562, 25);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(23, 23);
            this.btnSelecionarArquivo.TabIndex = 2;
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // txtArquivoSelecionado
            // 
            this.txtArquivoSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArquivoSelecionado.Location = new System.Drawing.Point(5, 25);
            this.txtArquivoSelecionado.Name = "txtArquivoSelecionado";
            this.txtArquivoSelecionado.Size = new System.Drawing.Size(548, 23);
            this.txtArquivoSelecionado.TabIndex = 1;
            this.txtArquivoSelecionado.Text = "D:\\Users\\Homologacao01\\Downloads\\ValidaIndicadores.rtf";
            this.txtArquivoSelecionado.TextChanged += new System.EventHandler(this.txtArquivoSelecionado_TextChanged);
            this.txtArquivoSelecionado.Leave += new System.EventHandler(this.txtArquivoSelecionado_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecione o Arquivo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtArquivoOrigem);
            this.tabPage2.Controls.Add(this.btnCopyArquiOrigem);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Arquivo Origem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtArquivoOrigem
            // 
            this.txtArquivoOrigem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArquivoOrigem.Location = new System.Drawing.Point(3, 3);
            this.txtArquivoOrigem.Name = "txtArquivoOrigem";
            this.txtArquivoOrigem.ReadOnly = true;
            this.txtArquivoOrigem.Size = new System.Drawing.Size(587, 258);
            this.txtArquivoOrigem.TabIndex = 1;
            this.txtArquivoOrigem.Text = "";
            // 
            // btnCopyArquiOrigem
            // 
            this.btnCopyArquiOrigem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCopyArquiOrigem.Location = new System.Drawing.Point(3, 261);
            this.btnCopyArquiOrigem.Name = "btnCopyArquiOrigem";
            this.btnCopyArquiOrigem.Size = new System.Drawing.Size(587, 23);
            this.btnCopyArquiOrigem.TabIndex = 0;
            this.btnCopyArquiOrigem.Text = "Copy";
            this.btnCopyArquiOrigem.UseVisualStyleBackColor = true;
            this.btnCopyArquiOrigem.Click += new System.EventHandler(this.btnCopyArquiOrigem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtResult);
            this.tabPage3.Controls.Add(this.btnCopyResult);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(593, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Conversão";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(587, 258);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "";
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCopyResult.Location = new System.Drawing.Point(3, 261);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(587, 23);
            this.btnCopyResult.TabIndex = 1;
            this.btnCopyResult.Text = "Copy";
            this.btnCopyResult.UseVisualStyleBackColor = true;
            this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversor de Arquivo de Texto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ofpFileOpen
            // 
            this.ofpFileOpen.Title = "Selecione o arquivo que deseja converter!";
            // 
            // FrmConverterText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 372);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Name = "FrmConverterText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter Text";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConverterText_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox txtArquivoOrigem;
        private Button btnCopyArquiOrigem;
        private TabPage tabPage3;
        private RichTextBox txtResult;
        private Button btnCopyResult;
        private Label label1;
        private StatusStrip statusStrip1;
        private Button btnSelecionarArquivo;
        private TextBox txtArquivoSelecionado;
        private Label label2;
        private OpenFileDialog ofpFileOpen;
        private Button btnSalvarArquivo;
        private ComboBox cbxConverterPara;
        private Label label3;
        private Button btnConverter;
        private Button btnLerArquivoSelecionado;
    }
}