using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        string connectionString = null;
        public MainForm()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.OracleSysUser;
            SetDataGridViewStyle();
            GetAllUserProfiles();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void butCleanSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }
        private void butRefresh_Click(object sender, EventArgs e)
        {
            GetAllUserProfiles();
        }
        private void butSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = tbSearch.Text.ToUpper().Replace(' ', '_');
            if(rbByName.Checked ==true)
            {
                GetConstraintsUserName(tbSearch.Text);
            }


            if (rbByID.Checked == true)
            {
                GetConstraintsUserID(tbSearch.Text);
            }
        }
        private void butDropConstraint_Click(object sender, EventArgs e)
        {
            try
            {
                string targetUser = dgvProfiles.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult SaveOrNot = MessageBox.Show("Are you sure, you want to drop this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SaveOrNot == DialogResult.Yes)
                {
                    DropConstraint(targetUser);
                }
                if (SaveOrNot == DialogResult.No)
                {
                    string lucidMessage = "Dropping of user was discarded.";
                    MessageBox.Show(lucidMessage, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                string lucidMessage = "Please choose whole line in table to drop an user";
                MessageBox.Show(lucidMessage, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                


        }
        private void butBuildReport_Click(object sender, EventArgs e)
        {
            Program.reportForm = new ReportForm();
            this.Hide();
            Program.reportForm.Show();
        }

        private void SetDataGridViewStyle()
        {
            dgvProfiles.BorderStyle = BorderStyle.None;
            dgvProfiles.AlternatingRowsDefaultCellStyle.BackColor = ColorPalette.LightGray;
            dgvProfiles.RowsDefaultCellStyle.BackColor = Color.White;
            dgvProfiles.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvProfiles.DefaultCellStyle.SelectionBackColor = ColorPalette.Green;
            dgvProfiles.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProfiles.BackgroundColor = Color.White;

            dgvProfiles.EnableHeadersVisualStyles = false;
            dgvProfiles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProfiles.ColumnHeadersDefaultCellStyle.BackColor = ColorPalette.Blue;
            dgvProfiles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvProfiles.RowHeadersDefaultCellStyle.BackColor = ColorPalette.Blue;
            dgvProfiles.RowHeadersDefaultCellStyle.SelectionBackColor = ColorPalette.Green;

        }

        private void SelectConstraints(string connectionString, string sql)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(sql, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvProfiles.DataSource = ds.Tables[0];
                    }

                }
            }
            catch(Exception ex)
            {
                string lucidMessage = "Сan't access data or database. You can try to connect again." + Environment.NewLine + Environment.NewLine;
                MessageBox.Show(lucidMessage + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        private void GetAllUserProfiles()
        {
            string sql = "SELECT USER_ID, USERNAME, ACCOUNT_STATUS, " 
                       + "DEFAULT_TABLESPACE, TEMPORARY_TABLESPACE, "
                       + "CREATED, LAST_LOGIN FROM DBA_USERS";
            SelectConstraints(connectionString, sql);
        }
        private void GetConstraintsUserName(string searchRequest)
        {
            string sql = $"SELECT USER_ID, USERNAME, ACCOUNT_STATUS, "
                       + $"DEFAULT_TABLESPACE, TEMPORARY_TABLESPACE, "
                       + $"CREATED, LAST_LOGIN FROM DBA_USERS "
                       + $"WHERE USERNAME = '{searchRequest}'";
            SelectConstraints(connectionString, sql);

        }
        private void GetConstraintsUserID(string searchRequest)
        {
            string sql = $"SELECT USER_ID, USERNAME, ACCOUNT_STATUS, "
                       + $"DEFAULT_TABLESPACE, TEMPORARY_TABLESPACE, "
                       + $"CREATED, LAST_LOGIN FROM DBA_USERS "
                       + $"WHERE USER_ID = '{searchRequest}'";
            SelectConstraints(connectionString, sql);

        }
        private void DropConstraint(string user)
        {            
            try
            {
                string sqlExpression = $"DROP USER {user} CASCADE";
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(sqlExpression, connection))
                    {
                            command.ExecuteNonQuery();
                            string lucidMessage = "User was successfully dropped.";
                            MessageBox.Show(lucidMessage, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);                           
                    }



                }
            }
            catch(Exception ex)
            {
                string lucidMessage = "Dropping of user was aborted." + Environment.NewLine + Environment.NewLine;
                MessageBox.Show(lucidMessage + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void butAddUser_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Program.createUserForm = new CreateUserForm();
            Program.createUserForm.Show();
        }
    }
}
