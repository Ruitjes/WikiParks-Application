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

        MySqlConnection connection = new MySqlConnection("datasource=sql11.freesqldatabase.com;port=3306;Initial Catalog='sql11174958';username=sql11174958;password=1QjPTHLY95");

         MySqlDataAdapter myAdapter = new MySqlDataAdapter();

        DataTable table = new DataTable();

        private void Login_Load(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            myAdapter = new MySqlDataAdapter("SELECT `Username`, `Password` FROM `Login` WHERE `username` = '" + txbUsername.Text + "' AND `password` = '" + txbPassword.Text + "'", connection);
            myAdapter.Fill(table);

            if (table.Rows.Count <=0)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Username Or Password are Invalid";
            }
            else
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Username and Password are valid!";

                this.Hide();
                Form1 f = new Form1();
                f.Show();
               
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
