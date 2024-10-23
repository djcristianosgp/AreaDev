namespace Area27.Telas
{
    partial class FrmContaPessoas
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
            btnCarregarImagem = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnCarregarImagem
            // 
            btnCarregarImagem.Location = new Point(324, 127);
            btnCarregarImagem.Name = "btnCarregarImagem";
            btnCarregarImagem.Size = new Size(75, 23);
            btnCarregarImagem.TabIndex = 0;
            btnCarregarImagem.Text = "button1";
            btnCarregarImagem.UseVisualStyleBackColor = true;
            btnCarregarImagem.Click += btnCarregarImagem_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(59, 38);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "label1";
            // 
            // FrmContaPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCarregarImagem);
            Name = "FrmContaPessoas";
            Text = "FrmContaPessoas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarregarImagem;
        private Label lblResultado;
    }
}