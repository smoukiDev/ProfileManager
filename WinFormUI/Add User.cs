using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WinFormUI
{
    
    public partial class CreateUserForm : Form
    {
        private string connectionString = null;
        private bool success = false;
        public CreateUserForm()
        {
            connectionString = Properties.Settings.Default.OracleSysUser;
            InitializeComponent();
        }

        private void butAddUser_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == tbPasswordConfirm.Text)
            {
                CreateUser(tbUserName.Text, tbPassword.Text);
                this.success = true;
            }
            else
            {
                this.success = false;
                string lucidMessage = "Confirm your password correctly.";
                MessageBox.Show(lucidMessage, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            if(success)
            {
                this.Close();
            }
        }

        private void CreateUser(string name, string identificator)
        {
            try
            {
                string sqlCreateUser = $"CREATE USER {name} IDENTIFIED BY {identificator}";
                string sqlGrantUser  = $"GRANT CONNECT TO {name} IDENTIFIED BY {identificator}";
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand commandOne = new OracleCommand(sqlCreateUser, connection))
                    {
                        commandOne.ExecuteNonQuery();
                        using (OracleCommand commandTwo = new OracleCommand(sqlGrantUser, connection))
                        {
                            commandTwo.ExecuteNonQuery();
                        }
                        string lucidMessage = "User was successfully added.";
                        MessageBox.Show(lucidMessage, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                }
            }
            catch (Exception ex)
            {
                string lucidMessage = "Creation of user was aborted." + Environment.NewLine + Environment.NewLine;
                MessageBox.Show(lucidMessage + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainForm.Enabled = true;
        }

        private void butMakePasswordVisible_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '⦁')
            {
                tbPassword.PasswordChar = '\0';
                tbPasswordConfirm.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '⦁';
                tbPasswordConfirm.PasswordChar = '⦁';
            }

        }


    }
}
