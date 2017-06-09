using MySql.Data.MySqlClient;
using MySql.Data;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // MySqlConnection connection = new MySqlConnection("");
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='users';username=root;password=");
        MySqlCommand command;

        private void Form1_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        public void populateDGV()
        {
            // open connection here.
            openConnection();
            // populate the datagridview
            string selectQuery = "SELECT * FROM park";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView_USERS.DataSource = table;
        }

        private void dataGridView_USERS_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txbParkID.Text = dataGridView_USERS.CurrentRow.Cells[0].Value.ToString();
                txbParkNaam.Text = dataGridView_USERS.CurrentRow.Cells[1].Value.ToString();
                txbLocatie.Text = dataGridView_USERS.CurrentRow.Cells[2].Value.ToString();
                txbOpeningsDagen.Text = dataGridView_USERS.CurrentRow.Cells[3].Value.ToString();
                txbParkLat.Text = dataGridView_USERS.CurrentRow.Cells[4].Value.ToString();
                txbParkLon.Text = dataGridView_USERS.CurrentRow.Cells[5].Value.ToString();
                txbPrijzen.Text = dataGridView_USERS.CurrentRow.Cells[6].Value.ToString();
                txbLeeftijden.Text = dataGridView_USERS.CurrentRow.Cells[7].Value.ToString();
                txbTags.Text = dataGridView_USERS.CurrentRow.Cells[8].Value.ToString();
                txbParkWebsite.Text = dataGridView_USERS.CurrentRow.Cells[9].Value.ToString();
                rtbKorteBeschrijving.Text = dataGridView_USERS.CurrentRow.Cells[10].Value.ToString();
                rtbBeschrijving.Text = dataGridView_USERS.CurrentRow.Cells[11].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No cell selected.");
            }

        }

        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query,connection);

                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Query Not Executed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                closeConnection();
            }
        }

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO park(ParkNaam, ParkLocatie, ParkLat, ParkLon, ParkOpeningsDagen, ParkOpeningsTijden, ParkPrijzen, ParkLeeftijden, ParkWebsite, ParkTags, ParkKorteBeschrijving, ParkVolleBeschrijving) VALUES('" +txbParkNaam.Text+ "','" +txbLocatie.Text+ "','" +txbParkLat.Text+ "','" + txbParkLon.Text + "','"+txbOpeningsDagen.Text + "','" +txbOpeningsTijden.Text+ "','" +txbPrijzen.Text+ "','" +txbLeeftijden.Text+ "','" + txbParkWebsite.Text + "','" + txbTags.Text + "','" +rtbKorteBeschrijving.Text+ "','" +rtbBeschrijving.Text+ "')";
            executeMyQuery(insertQuery);
            populateDGV();
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE park SET ParkNaam='" + txbParkNaam.Text + "',ParkLocatie='" + txbLocatie.Text + "',ParkLat='" + txbParkLat.Text + "',ParkLon='" + txbParkLon.Text + "',ParkOpeningsDagen='" + txbOpeningsDagen.Text + "',ParkOpeningsTijden='" + txbOpeningsTijden.Text + "',ParkPrijzen='" + txbPrijzen.Text + "',Parkleeftijden='" + txbLeeftijden.Text + "',ParkWebsite='" + ParkWebsite.Text + "',ParkTags='" + txbTags.Text + "',ParkKorteBeschrijving='" + rtbKorteBeschrijving.Text + "',ParkVolleBeschrijving='" + rtbBeschrijving.Text + "' WHERE ParkID =" + int.Parse(txbParkID.Text);
            executeMyQuery(updateQuery);
            populateDGV();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM park WHERE ParkID = " + int.Parse(txbParkID.Text);
            executeMyQuery(deleteQuery);
            populateDGV();
        } 
    }
}

    
