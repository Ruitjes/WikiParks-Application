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
    public partial class WikiParks : Form
    {
        public WikiParks()
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
                txbParkImage.Text = dataGridView_USERS.CurrentRow.Cells[1].Value.ToString();
                txbParkNaam.Text = dataGridView_USERS.CurrentRow.Cells[2].Value.ToString();
                txbLocatie.Text = dataGridView_USERS.CurrentRow.Cells[3].Value.ToString();
                txbParkLat.Text = dataGridView_USERS.CurrentRow.Cells[4].Value.ToString();
                txbParkLon.Text = dataGridView_USERS.CurrentRow.Cells[5].Value.ToString();
                txbParkProvincie.Text = dataGridView_USERS.CurrentRow.Cells[6].Value.ToString();
                txbOpeningsDagen.Text = dataGridView_USERS.CurrentRow.Cells[7].Value.ToString();
                txbOpeningsTijden.Text = dataGridView_USERS.CurrentRow.Cells[8].Value.ToString();
                txbPrijzen.Text = dataGridView_USERS.CurrentRow.Cells[9].Value.ToString();
                txbParkNavigatiePrijzen.Text = dataGridView_USERS.CurrentRow.Cells[10].Value.ToString();
                txbLeeftijden.Text = dataGridView_USERS.CurrentRow.Cells[11].Value.ToString();
                txbTags.Text = dataGridView_USERS.CurrentRow.Cells[12].Value.ToString();
                txbParkWebsite.Text = dataGridView_USERS.CurrentRow.Cells[13].Value.ToString();
                rtbKorteBeschrijving.Text = dataGridView_USERS.CurrentRow.Cells[14].Value.ToString();
                rtbBeschrijving.Text = dataGridView_USERS.CurrentRow.Cells[15].Value.ToString();
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
            string insertQuery = "INSERT INTO park(ParkImage ,ParkNaam, ParkLocatie, ParkLat, ParkLon, ParkProvincie, ParkOpeningsDagen, ParkOpeningsTijden, ParkPrijzen, ParkNavigatiePrijzen, ParkLeeftijden, ParkTags, ParkWebsite, ParkKorteBeschrijving, ParkLangeBeschrijving) VALUES('" + txbParkImage.Text + "','" + txbParkNaam.Text + "','" + txbLocatie.Text + "','" + txbParkLat.Text + "','" + txbParkLon.Text + "','" + txbParkProvincie.Text + "','" + txbOpeningsDagen.Text + "','" + txbOpeningsTijden.Text + "','" + txbPrijzen.Text + "','" + txbParkNavigatiePrijzen.Text + "','" + txbLeeftijden.Text + "','" + txbTags.Text + "','" + txbParkWebsite.Text + "','" + rtbKorteBeschrijving.Text + "','" + rtbBeschrijving.Text + "')";
            executeMyQuery(insertQuery);
            populateDGV();
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE park SET ParkImage='" + txbParkImage.Text + "',ParkNaam='" + txbParkNaam.Text + "',ParkLocatie='" + txbLocatie.Text + "',ParkLat='" + txbParkLat.Text + "',ParkLon='" + txbParkLon.Text + "', ParkProvincie='" + txbParkProvincie.Text + "',ParkOpeningsDagen='" + txbOpeningsDagen.Text + "',ParkOpeningsTijden='" + txbOpeningsTijden.Text + "',ParkPrijzen='" + txbPrijzen.Text + "',ParkNavigatiePrijzen='" + txbParkNavigatiePrijzen.Text + "',Parkleeftijden='" + txbLeeftijden.Text + "',ParkTags='" + txbTags.Text + "',ParkWebsite='" + txbParkWebsite.Text + "',ParkKorteBeschrijving='" + rtbKorteBeschrijving.Text + "',ParkLangeBeschrijving='" + rtbBeschrijving.Text + "' WHERE ParkID =" + int.Parse(txbParkID.Text);
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

    
