using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace alprogggg
{
    public partial class Form1 : Form
    {
        string conString = "server=127.0.0.1;port=3306;database=testap;user=root;password=";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and Password required!");
                return;
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(conString);
                    using(conn)
                    {
                        conn.Open();
                        string query = "SELECT username, password FROM users WHERE username=@uname AND password=@password LIMIT 1";
                        MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
                        ada.SelectCommand.Parameters.AddWithValue("@uname",username);
                        ada.SelectCommand.Parameters.AddWithValue("password",password);

                        DataTable table = new DataTable();
                        ada.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show("Logged in succesfully!");
                            conn.Close();
                            new frmDashboard().Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Invalid details!");
                            conn.Close();
                            return;
                        }
                    }
                    // TODO: logic login here
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }


        }

        private void xhkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(xhkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }
    }
}