namespace Teste_API.Telas
{
    partial class frmAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAPI));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbParametros = new System.Windows.Forms.TabPage();
            this.btnAddQuery = new System.Windows.Forms.Button();
            this.btnRemoveQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtQueryParameters = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEndpointUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConfigure = new System.Windows.Forms.TabPage();
            this.btnAddHeader = new System.Windows.Forms.Button();
            this.btnRemoveHeader = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtHeaderParameters = new System.Windows.Forms.DataGridView();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbResultado = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCopyResult = new System.Windows.Forms.Button();
            this.BTNbUSCAaRQUIVO = new System.Windows.Forms.Button();
            this.txtEndpointUriResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNameConexao = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.opArquivo = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcPrincipal.SuspendLayout();
            this.tbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtQueryParameters)).BeginInit();
            this.tbConfigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHeaderParameters)).BeginInit();
            this.tbResultado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(704, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Teste API";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(0, 489);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(704, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbParametros);
            this.tbcPrincipal.Controls.Add(this.tbConfigure);
            this.tbcPrincipal.Controls.Add(this.tbResultado);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 31);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(704, 327);
            this.tbcPrincipal.TabIndex = 2;
            // 
            // tbParametros
            // 
            this.tbParametros.Controls.Add(this.btnAddQuery);
            this.tbParametros.Controls.Add(this.btnRemoveQuery);
            this.tbParametros.Controls.Add(this.label2);
            this.tbParametros.Controls.Add(this.dtQueryParameters);
            this.tbParametros.Controls.Add(this.txtEndpointUri);
            this.tbParametros.Controls.Add(this.label1);
            this.tbParametros.Location = new System.Drawing.Point(4, 24);
            this.tbParametros.Name = "tbParametros";
            this.tbParametros.Padding = new System.Windows.Forms.Padding(3);
            this.tbParametros.Size = new System.Drawing.Size(696, 299);
            this.tbParametros.TabIndex = 0;
            this.tbParametros.Text = "Parâmetros";
            this.tbParametros.UseVisualStyleBackColor = true;
            // 
            // btnAddQuery
            // 
            this.btnAddQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnAddQuery.Image")));
            this.btnAddQuery.Location = new System.Drawing.Point(636, 49);
            this.btnAddQuery.Name = "btnAddQuery";
            this.btnAddQuery.Size = new System.Drawing.Size(23, 23);
            this.btnAddQuery.TabIndex = 8;
            this.btnAddQuery.UseVisualStyleBackColor = true;
            this.btnAddQuery.Click += new System.EventHandler(this.btnAddQuery_Click);
            // 
            // btnRemoveQuery
            // 
            this.btnRemoveQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveQuery.Image")));
            this.btnRemoveQuery.Location = new System.Drawing.Point(665, 49);
            this.btnRemoveQuery.Name = "btnRemoveQuery";
            this.btnRemoveQuery.Size = new System.Drawing.Size(23, 23);
            this.btnRemoveQuery.TabIndex = 7;
            this.btnRemoveQuery.UseVisualStyleBackColor = true;
            this.btnRemoveQuery.Click += new System.EventHandler(this.btnRemoveQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Query Parameters:";
            // 
            // dtQueryParameters
            // 
            this.dtQueryParameters.AllowUserToAddRows = false;
            this.dtQueryParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtQueryParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtQueryParameters.BackgroundColor = System.Drawing.Color.White;
            this.dtQueryParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtQueryParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CValue});
            this.dtQueryParameters.Location = new System.Drawing.Point(5, 74);
            this.dtQueryParameters.Name = "dtQueryParameters";
            this.dtQueryParameters.RowTemplate.Height = 25;
            this.dtQueryParameters.Size = new System.Drawing.Size(683, 219);
            this.dtQueryParameters.TabIndex = 2;
            this.dtQueryParameters.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQueryParameters_CellLeave);
            this.dtQueryParameters.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQueryParameters_RowLeave);
            this.dtQueryParameters.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtQueryParameters_RowsAdded);
            this.dtQueryParameters.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtQueryParameters_RowsRemoved);
            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            this.CName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CName.Width = 64;
            // 
            // CValue
            // 
            this.CValue.HeaderText = "Value";
            this.CValue.Name = "CValue";
            this.CValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CValue.Width = 60;
            // 
            // txtEndpointUri
            // 
            this.txtEndpointUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndpointUri.Location = new System.Drawing.Point(5, 23);
            this.txtEndpointUri.MaxLength = 500;
            this.txtEndpointUri.Name = "txtEndpointUri";
            this.txtEndpointUri.Size = new System.Drawing.Size(683, 23);
            this.txtEndpointUri.TabIndex = 1;
            this.txtEndpointUri.TextChanged += new System.EventHandler(this.txtEndpointUri_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI da API:(Endpoint)";
            // 
            // tbConfigure
            // 
            this.tbConfigure.Controls.Add(this.btnAddHeader);
            this.tbConfigure.Controls.Add(this.btnRemoveHeader);
            this.tbConfigure.Controls.Add(this.label4);
            this.tbConfigure.Controls.Add(this.dtHeaderParameters);
            this.tbConfigure.Location = new System.Drawing.Point(4, 24);
            this.tbConfigure.Name = "tbConfigure";
            this.tbConfigure.Padding = new System.Windows.Forms.Padding(3);
            this.tbConfigure.Size = new System.Drawing.Size(696, 299);
            this.tbConfigure.TabIndex = 1;
            this.tbConfigure.Text = "Configurações";
            this.tbConfigure.UseVisualStyleBackColor = true;
            // 
            // btnAddHeader
            // 
            this.btnAddHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHeader.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHeader.Image")));
            this.btnAddHeader.Location = new System.Drawing.Point(636, 1);
            this.btnAddHeader.Name = "btnAddHeader";
            this.btnAddHeader.Size = new System.Drawing.Size(23, 23);
            this.btnAddHeader.TabIndex = 10;
            this.btnAddHeader.UseVisualStyleBackColor = true;
            this.btnAddHeader.Click += new System.EventHandler(this.btnAddHeader_Click);
            // 
            // btnRemoveHeader
            // 
            this.btnRemoveHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveHeader.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveHeader.Image")));
            this.btnRemoveHeader.Location = new System.Drawing.Point(665, 1);
            this.btnRemoveHeader.Name = "btnRemoveHeader";
            this.btnRemoveHeader.Size = new System.Drawing.Size(23, 23);
            this.btnRemoveHeader.TabIndex = 9;
            this.btnRemoveHeader.UseVisualStyleBackColor = true;
            this.btnRemoveHeader.Click += new System.EventHandler(this.btnRemoveHeader_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "HTTP Header Parameters:";
            // 
            // dtHeaderParameters
            // 
            this.dtHeaderParameters.AllowUserToAddRows = false;
            this.dtHeaderParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtHeaderParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtHeaderParameters.BackgroundColor = System.Drawing.Color.White;
            this.dtHeaderParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHeaderParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderName,
            this.HeaderValue});
            this.dtHeaderParameters.Location = new System.Drawing.Point(5, 25);
            this.dtHeaderParameters.Name = "dtHeaderParameters";
            this.dtHeaderParameters.RowTemplate.Height = 25;
            this.dtHeaderParameters.Size = new System.Drawing.Size(683, 268);
            this.dtHeaderParameters.TabIndex = 4;
            this.dtHeaderParameters.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHeaderParameters_CellLeave);
            this.dtHeaderParameters.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHeaderParameters_RowLeave);
            this.dtHeaderParameters.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtHeaderParameters_RowsAdded);
            this.dtHeaderParameters.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtHeaderParameters_RowsRemoved);
            // 
            // HeaderName
            // 
            this.HeaderName.HeaderText = "Header Name";
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.Width = 105;
            // 
            // HeaderValue
            // 
            this.HeaderValue.HeaderText = "Header Value";
            this.HeaderValue.Name = "HeaderValue";
            this.HeaderValue.Width = 101;
            // 
            // tbResultado
            // 
            this.tbResultado.Controls.Add(this.txtResult);
            this.tbResultado.Controls.Add(this.label5);
            this.tbResultado.Controls.Add(this.btnCopyResult);
            this.tbResultado.Location = new System.Drawing.Point(4, 24);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tbResultado.Size = new System.Drawing.Size(696, 299);
            this.tbResultado.TabIndex = 2;
            this.tbResultado.Text = "Resultado";
            this.tbResultado.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 34);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(690, 239);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(690, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Resultado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCopyResult.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyResult.Image")));
            this.btnCopyResult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyResult.Location = new System.Drawing.Point(3, 273);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(690, 23);
            this.btnCopyResult.TabIndex = 0;
            this.btnCopyResult.Text = "Copy";
            this.btnCopyResult.UseVisualStyleBackColor = true;
            this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);
            // 
            // BTNbUSCAaRQUIVO
            // 
            this.BTNbUSCAaRQUIVO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNbUSCAaRQUIVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNbUSCAaRQUIVO.Image")));
            this.BTNbUSCAaRQUIVO.Location = new System.Drawing.Point(677, 62);
            this.BTNbUSCAaRQUIVO.Name = "BTNbUSCAaRQUIVO";
            this.BTNbUSCAaRQUIVO.Size = new System.Drawing.Size(23, 23);
            this.BTNbUSCAaRQUIVO.TabIndex = 15;
            this.BTNbUSCAaRQUIVO.UseVisualStyleBackColor = true;
            this.BTNbUSCAaRQUIVO.Click += new System.EventHandler(this.BTNbUSCAaRQUIVO_Click);
            // 
            // txtEndpointUriResult
            // 
            this.txtEndpointUriResult.BackColor = System.Drawing.Color.White;
            this.txtEndpointUriResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEndpointUriResult.Location = new System.Drawing.Point(0, 24);
            this.txtEndpointUriResult.MaxLength = 500;
            this.txtEndpointUriResult.Name = "txtEndpointUriResult";
            this.txtEndpointUriResult.ReadOnly = true;
            this.txtEndpointUriResult.Size = new System.Drawing.Size(704, 23);
            this.txtEndpointUriResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result URI:(Endpoint)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(0, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nome da Conexão:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(0, 85);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(704, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNameConexao
            // 
            this.txtNameConexao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNameConexao.Location = new System.Drawing.Point(0, 62);
            this.txtNameConexao.MaxLength = 500;
            this.txtNameConexao.Name = "txtNameConexao";
            this.txtNameConexao.Size = new System.Drawing.Size(704, 23);
            this.txtNameConexao.TabIndex = 12;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExecutar.Image = ((System.Drawing.Image)(resources.GetObject("btnExecutar.Image")));
            this.btnExecutar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecutar.Location = new System.Drawing.Point(0, 108);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(704, 23);
            this.btnExecutar.TabIndex = 11;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNbUSCAaRQUIVO);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEndpointUriResult);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNameConexao);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 131);
            this.panel1.TabIndex = 3;
            // 
            // frmAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste API";
            this.Load += new System.EventHandler(this.frmAPI_Load);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbParametros.ResumeLayout(false);
            this.tbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtQueryParameters)).EndInit();
            this.tbConfigure.ResumeLayout(false);
            this.tbConfigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHeaderParameters)).EndInit();
            this.tbResultado.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private StatusStrip ssStatus;
        private TabControl tbcPrincipal;
        private TabPage tbParametros;
        private Button btnAddQuery;
        private Button btnRemoveQuery;
        private TextBox txtEndpointUriResult;
        private Label label3;
        private Label label2;
        private DataGridView dtQueryParameters;
        private TextBox txtEndpointUri;
        private Label label1;
        private TabPage tbConfigure;
        private Button btnAddHeader;
        private Button btnRemoveHeader;
        private Label label4;
        private DataGridView dtHeaderParameters;
        private TabPage tbResultado;
        private RichTextBox txtResult;
        private Label label5;
        private Button btnCopyResult;
        private Button btnExecutar;
        private DataGridViewTextBoxColumn HeaderName;
        private DataGridViewTextBoxColumn HeaderValue;
        private DataGridViewTextBoxColumn CName;
        private DataGridViewTextBoxColumn CValue;
        private Button btnSalvar;
        private TextBox txtNameConexao;
        private Button BTNbUSCAaRQUIVO;
        private Label label6;
        private OpenFileDialog opArquivo;
        private Panel panel1;
    }
}