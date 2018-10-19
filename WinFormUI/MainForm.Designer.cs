namespace WinFormUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.butDropUser = new System.Windows.Forms.Button();
            this.butBuildReport = new System.Windows.Forms.Button();
            this.rbByID = new System.Windows.Forms.RadioButton();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.panDataGrid = new System.Windows.Forms.Panel();
            this.butAddUser = new System.Windows.Forms.Button();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.butRefresh = new System.Windows.Forms.Button();
            this.butCleanSearch = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.panDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(454, 31);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(458, 73);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(524, 29);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butDropUser
            // 
            this.butDropUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butDropUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.butDropUser.FlatAppearance.BorderSize = 0;
            this.butDropUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDropUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butDropUser.Location = new System.Drawing.Point(755, 487);
            this.butDropUser.Name = "butDropUser";
            this.butDropUser.Size = new System.Drawing.Size(215, 55);
            this.butDropUser.TabIndex = 9;
            this.butDropUser.Text = "Drop";
            this.butDropUser.UseVisualStyleBackColor = false;
            this.butDropUser.Click += new System.EventHandler(this.butDropConstraint_Click);
            // 
            // butBuildReport
            // 
            this.butBuildReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butBuildReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.butBuildReport.FlatAppearance.BorderSize = 0;
            this.butBuildReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBuildReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butBuildReport.Location = new System.Drawing.Point(313, 487);
            this.butBuildReport.Name = "butBuildReport";
            this.butBuildReport.Size = new System.Drawing.Size(215, 56);
            this.butBuildReport.TabIndex = 10;
            this.butBuildReport.Text = "Report";
            this.butBuildReport.UseVisualStyleBackColor = false;
            this.butBuildReport.Click += new System.EventHandler(this.butBuildReport_Click);
            // 
            // rbByID
            // 
            this.rbByID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByID.AutoSize = true;
            this.rbByID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbByID.Location = new System.Drawing.Point(625, 108);
            this.rbByID.Name = "rbByID";
            this.rbByID.Size = new System.Drawing.Size(128, 28);
            this.rbByID.TabIndex = 2;
            this.rbByID.TabStop = true;
            this.rbByID.Text = "By Profile ID";
            this.rbByID.UseVisualStyleBackColor = true;
            // 
            // rbByName
            // 
            this.rbByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByName.AutoSize = true;
            this.rbByName.Checked = true;
            this.rbByName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbByName.Location = new System.Drawing.Point(458, 108);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(162, 28);
            this.rbByName.TabIndex = 1;
            this.rbByName.TabStop = true;
            this.rbByName.Text = "By Profile Name";
            this.rbByName.UseVisualStyleBackColor = true;
            // 
            // panDataGrid
            // 
            this.panDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(84)))), ((int)(((byte)(89)))));
            this.panDataGrid.Controls.Add(this.butAddUser);
            this.panDataGrid.Controls.Add(this.dgvProfiles);
            this.panDataGrid.Controls.Add(this.butDropUser);
            this.panDataGrid.Controls.Add(this.butBuildReport);
            this.panDataGrid.Location = new System.Drawing.Point(12, 164);
            this.panDataGrid.Name = "panDataGrid";
            this.panDataGrid.Size = new System.Drawing.Size(984, 553);
            this.panDataGrid.TabIndex = 12;
            // 
            // butAddUser
            // 
            this.butAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.butAddUser.FlatAppearance.BorderSize = 0;
            this.butAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butAddUser.Location = new System.Drawing.Point(534, 487);
            this.butAddUser.Name = "butAddUser";
            this.butAddUser.Size = new System.Drawing.Size(215, 55);
            this.butAddUser.TabIndex = 11;
            this.butAddUser.Text = "Create";
            this.butAddUser.UseVisualStyleBackColor = false;
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Location = new System.Drawing.Point(13, 71);
            this.dgvProfiles.MultiSelect = false;
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.Size = new System.Drawing.Size(957, 405);
            this.dgvProfiles.TabIndex = 8;
            // 
            // butRefresh
            // 
            this.butRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRefresh.BackgroundImage = global::WinFormUI.Properties.Resources.butRefresh;
            this.butRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butRefresh.FlatAppearance.BorderSize = 0;
            this.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRefresh.Location = new System.Drawing.Point(886, 22);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(45, 45);
            this.butRefresh.TabIndex = 7;
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butCleanSearch
            // 
            this.butCleanSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butCleanSearch.BackgroundImage = global::WinFormUI.Properties.Resources.butClear;
            this.butCleanSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butCleanSearch.FlatAppearance.BorderSize = 0;
            this.butCleanSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCleanSearch.Location = new System.Drawing.Point(937, 22);
            this.butCleanSearch.Name = "butCleanSearch";
            this.butCleanSearch.Size = new System.Drawing.Size(45, 45);
            this.butCleanSearch.TabIndex = 5;
            this.butCleanSearch.UseVisualStyleBackColor = true;
            this.butCleanSearch.Click += new System.EventHandler(this.butCleanSearch_Click);
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.BackgroundImage = global::WinFormUI.Properties.Resources.butSearchUser;
            this.butSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butSearch.FlatAppearance.BorderSize = 0;
            this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSearch.Location = new System.Drawing.Point(835, 21);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(45, 45);
            this.butSearch.TabIndex = 6;
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panDataGrid);
            this.Controls.Add(this.rbByID);
            this.Controls.Add(this.rbByName);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butCleanSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle Profile Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button butCleanSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.Button butDropUser;
        private System.Windows.Forms.Button butBuildReport;
        private System.Windows.Forms.RadioButton rbByID;
        private System.Windows.Forms.RadioButton rbByName;
        private System.Windows.Forms.Panel panDataGrid;
        private System.Windows.Forms.Button butAddUser;
        private System.Windows.Forms.DataGridView dgvProfiles;
    }
}