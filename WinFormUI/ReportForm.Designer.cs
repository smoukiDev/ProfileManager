namespace WinFormUI
{
    partial class ReportForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.reportViwer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsOracleSysUser = new WinFormUI.dsOracleSysUser();
            this.DBA_USERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBA_USERSTableAdapter = new WinFormUI.dsOracleSysUserTableAdapters.DBA_USERSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsOracleSysUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBA_USERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViwer
            // 
            this.reportViwer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsUserInfo";
            reportDataSource1.Value = this.DBA_USERSBindingSource;
            this.reportViwer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViwer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.UsersInfoReport.rdlc";
            this.reportViwer.Location = new System.Drawing.Point(12, 12);
            this.reportViwer.Name = "reportViwer";
            this.reportViwer.Size = new System.Drawing.Size(984, 705);
            this.reportViwer.TabIndex = 0;
            this.reportViwer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // dsOracleSysUser
            // 
            this.dsOracleSysUser.DataSetName = "dsOracleSysUser";
            this.dsOracleSysUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DBA_USERSBindingSource
            // 
            this.DBA_USERSBindingSource.DataMember = "DBA_USERS";
            this.DBA_USERSBindingSource.DataSource = this.dsOracleSysUser;
            // 
            // DBA_USERSTableAdapter
            // 
            this.DBA_USERSTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.reportViwer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportForm_FormClosing);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsOracleSysUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBA_USERSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViwer;
        private System.Windows.Forms.BindingSource DBA_USERSBindingSource;
        private dsOracleSysUser dsOracleSysUser;
        private dsOracleSysUserTableAdapters.DBA_USERSTableAdapter DBA_USERSTableAdapter;
    }
}