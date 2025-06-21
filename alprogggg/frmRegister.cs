using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace alprogggg
{
    public partial class frmRegister : Form
    {
        string conString = "server=127.0.0.1;port=3306;database=testap;user=root;password=";

        public frmRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConifrmPassword.Text.Trim();

            if (firstName == "" || lastName == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            else
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(conString))
                    {
                        conn.Open();
                        string query = "INSERT INTO users (username, password, fist_name, Last_name) VALUES (@uname, @password, @fname, @lname)";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@uname", firstName.ToLower());
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@fname", firstName);
                        cmd.Parameters.AddWithValue("@lname", lastName);

                        int status = cmd.ExecuteNonQuery();

                        if (status > 0)
                        {
                            MessageBox.Show("Account Created Successfully!");
                            new Form1().Show();
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
