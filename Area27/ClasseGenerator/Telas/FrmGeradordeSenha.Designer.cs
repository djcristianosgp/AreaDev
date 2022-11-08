namespace ClasseGenerator.Telas
{
    partial class FrmGeradordeSenha
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
            this.nmQuantidade = new System.Windows.Forms.NumericUpDown();
            this.chkLetras = new System.Windows.Forms.CheckBox();
            this.chkNumero = new System.Windows.Forms.CheckBox();
            this.chkCaracteres = new System.Windows.Forms.CheckBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Caracteres:";
            // 
            // nmQuantidade
            // 
            this.nmQuantidade.Location = new System.Drawing.Point(12, 27);
            this.nmQuantidade.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantidade.Name = "nmQuantidade";
            this.nmQuantidade.Size = new System.Drawing.Size(245, 23);
            this.nmQuantidade.TabIndex = 1;
            this.nmQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmQuantidade.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chkLetras
            // 
            this.chkLetras.AutoSize = true;
            this.chkLetras.Location = new System.Drawing.Point(12, 56);
            this.chkLetras.Name = "chkLetras";
            this.chkLetras.Size = new System.Drawing.Size(83, 19);
            this.chkLetras.TabIndex = 2;
            this.chkLetras.Text = "Usar Letras";
            this.chkLetras.UseVisualStyleBackColor = true;
            // 
            // chkNumero
            // 
            this.chkNumero.AutoSize = true;
            this.chkNumero.Location = new System.Drawing.Point(12, 81);
            this.chkNumero.Name = "chkNumero";
            this.chkNumero.Size = new System.Drawing.Size(104, 19);
            this.chkNumero.TabIndex = 3;
            this.chkNumero.Text = "Usar Números:";
            this.chkNumero.UseVisualStyleBackColor = true;
            // 
            // chkCaracteres
            // 
            this.chkCaracteres.AutoSize = true;
            this.chkCaracteres.Location = new System.Drawing.Point(12, 106);
            this.chkCaracteres.Name = "chkCaracteres";
            this.chkCaracteres.Size = new System.Drawing.Size(157, 19);
            this.chkCaracteres.TabIndex = 4;
            this.chkCaracteres.Text = "Usar Caracteres Especiais";
            this.chkCaracteres.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 131);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(245, 23);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResultado.Location = new System.Drawing.Point(0, 175);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(269, 96);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.Text = "";
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCopy.Location = new System.Drawing.Point(0, 271);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(269, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // FrmGeradordeSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 294);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.chkCaracteres);
            this.Controls.Add(this.chkNumero);
            this.Controls.Add(this.chkLetras);
            this.Controls.Add(this.nmQuantidade);
            this.Controls.Add(this.label1);
            this.Name = "FrmGeradordeSenha";
            this.Text = "FrmGeradordeSenha";
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown nmQuantidade;
        private CheckBox chkLetras;
        private CheckBox chkNumero;
        private CheckBox chkCaracteres;
        private Button btnGerar;
        private RichTextBox txtResultado;
        private Button btnCopy;
    }
}