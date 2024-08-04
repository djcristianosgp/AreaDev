namespace area_27_dashboard.Views
{
    partial class FrmDashboardView
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
            components = new System.ComponentModel.Container();
            dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dashboardViewer1).BeginInit();
            SuspendLayout();
            // 
            // dashboardViewer1
            // 
            dashboardViewer1.Appearance.BackColor = Color.FromArgb(210, 210, 210);
            dashboardViewer1.Appearance.Options.UseBackColor = true;
            dashboardViewer1.AsyncMode = true;
            dashboardViewer1.Dock = DockStyle.Fill;
            dashboardViewer1.Location = new Point(0, 57);
            dashboardViewer1.Name = "dashboardViewer1";
            dashboardViewer1.Size = new Size(1017, 480);
            dashboardViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 57);
            panel1.TabIndex = 1;
            // 
            // FrmDashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 537);
            Controls.Add(dashboardViewer1);
            Controls.Add(panel1);
            Name = "FrmDashboardView";
            Text = "FrmDashboardView";
            Load += FrmDashboardView_Load;
            ((System.ComponentModel.ISupportInitialize)dashboardViewer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
        private Panel panel1;
    }
}