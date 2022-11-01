namespace Manipuladores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtDataTeste = new System.Windows.Forms.DateTimePicker();
            this.btExecutar = new System.Windows.Forms.Button();
            this.txtRetorno = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dtDataTeste
            // 
            this.dtDataTeste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataTeste.Location = new System.Drawing.Point(25, 21);
            this.dtDataTeste.Name = "dtDataTeste";
            this.dtDataTeste.Size = new System.Drawing.Size(208, 23);
            this.dtDataTeste.TabIndex = 0;
            this.dtDataTeste.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btExecutar
            // 
            this.btExecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExecutar.Location = new System.Drawing.Point(253, 21);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(75, 23);
            this.btExecutar.TabIndex = 1;
            this.btExecutar.Text = "Executar";
            this.btExecutar.UseVisualStyleBackColor = true;
            this.btExecutar.Click += new System.EventHandler(this.btExecutar_Click);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRetorno.Location = new System.Drawing.Point(25, 55);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(303, 177);
            this.txtRetorno.TabIndex = 2;
            this.txtRetorno.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 251);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.btExecutar);
            this.Controls.Add(this.dtDataTeste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtDataTeste;
        private Button btExecutar;
        private RichTextBox txtRetorno;
    }
}