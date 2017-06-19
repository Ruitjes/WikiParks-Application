using DevOne.Security.Cryptography.BCrypt;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='users';username=root;password=");

        MySqlDataAdapter myAdapter = new MySqlDataAdapter();

        DataTable table = new DataTable();

        private void Login_Load(object sender, EventArgs e)
        {
            connection.Open();
            txbPassword.UseSystemPasswordChar = true;

            using (MySqlCommand command = new MySqlCommand("INSERT INTO `Login` (`Username`, `Password`) VALUES ('admin', '" + BCryptHelper.HashPassword("admin123", BCryptHelper.GenerateSalt()) + "');", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using(MySqlCommand command = new MySqlCommand("SELECT `Username`, `Password` FROM `Login` WHERE `Username` = '" + txbUsername.Text + "';", connection))
            {
                using(MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (BCryptHelper.CheckPassword(txbPassword.Text, reader.GetString("Password")))
                        {
                            label3.Text = "Username and Password are valid!";
                            label3.ForeColor = Color.Green;

                            this.Hide();
                            WikiParks f = new WikiParks();
                            f.Show();
                        }
                    }
                    else
                    {
                        label3.ForeColor = Color.Red;
                        label3.Text = "Username Or Password are Invalid";
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
