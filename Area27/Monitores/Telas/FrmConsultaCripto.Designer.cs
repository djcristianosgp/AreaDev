namespace Monitores.Telas
{
    partial class FrmConsultaCripto
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
            this.txtCriptoMoeda = new System.Windows.Forms.TextBox();
            this.txtTipoConsulta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecutarConsulta = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cripto Moeda";
            // 
            // txtCriptoMoeda
            // 
            this.txtCriptoMoeda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCriptoMoeda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCriptoMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCriptoMoeda.Location = new System.Drawing.Point(10, 28);
            this.txtCriptoMoeda.Name = "txtCriptoMoeda";
            this.txtCriptoMoeda.PlaceholderText = "Digite a sigla a Criptomoeda que deseja consultar...";
            this.txtCriptoMoeda.Size = new System.Drawing.Size(296, 23);
            this.txtCriptoMoeda.TabIndex = 1;
            // 
            // txtTipoConsulta
            // 
            this.txtTipoConsulta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTipoConsulta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTipoConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoConsulta.Location = new System.Drawing.Point(10, 72);
            this.txtTipoConsulta.Name = "txtTipoConsulta";
            this.txtTipoConsulta.Size = new System.Drawing.Size(296, 23);
            this.txtTipoConsulta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de consulta";
            // 
            // btnExecutarConsulta
            // 
            this.btnExecutarConsulta.Location = new System.Drawing.Point(10, 106);
            this.btnExecutarConsulta.Name = "btnExecutarConsulta";
            this.btnExecutarConsulta.Size = new System.Drawing.Size(296, 34);
            this.btnExecutarConsulta.TabIndex = 4;
            this.btnExecutarConsulta.Text = "Executar Consulta";
            this.btnExecutarConsulta.UseVisualStyleBackColor = true;
            this.btnExecutarConsulta.Click += new System.EventHandler(this.btnExecutarConsulta_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtResultado.Location = new System.Drawing.Point(330, 0);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(470, 450);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.Text = "";
            // 
            // FrmConsultaCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnExecutarConsulta);
            this.Controls.Add(this.txtTipoConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCriptoMoeda);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaCripto";
            this.Text = "FrmConsultaCripto";
            this.Load += new System.EventHandler(this.FrmConsultaCripto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCriptoMoeda;
        private TextBox txtTipoConsulta;
        private Label label2;
        private Button btnExecutarConsulta;
        private RichTextBox txtResultado;
    }
}