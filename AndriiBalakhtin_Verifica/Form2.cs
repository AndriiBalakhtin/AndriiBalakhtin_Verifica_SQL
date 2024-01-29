using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace AndriiBalakhtin_Verifica
{
    public partial class Form2 : Form
    {
        public string id_utente;

        public Form2(string id)
        {
            InitializeComponent();
            id_utente = id;
            PopolaForm();
        }

        public void PopolaForm()
        {
            string ConnectionString = "server=127.0.0.1;database=magazzino;uid=root";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();

                string query = $"SELECT * FROM products WHERE Codice_Farnell = {id_utente}";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                LblCodiceFarnel.Text = $"Codice_Farnell: {dr.GetInt32(dr.GetOrdinal("Codice_Farnell"))}";

                dr.Close();

                connessione.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            {
                string ConnectionString = "server=127.0.0.1;database=magazzino;uid=root";
                MySqlConnection connessione = new MySqlConnection(ConnectionString);
                try
                {
                    connessione.Open();

                    string query = $"UPDATE products " +
                    $"SET " +
                    $"Descrizione = '{textBoxDescrizione.Text}', " +
                    $"Produttore = '{textBoxProduttore.Text}', " +
                    $"Codice_produttore = '{textBoxCodiceProduttore.Text}', " +
                    $"Quantita = '{textBoxQuantita.Text}', " +
                    $"Prezzo_unitario = '{textBoxPrezzoUnitario.Text}' " +
                    $"WHERE Codice_Farnell = {id_utente}";

                    MySqlCommand cmd = new MySqlCommand(query, connessione);
                    cmd.ExecuteNonQuery();

                    connessione.Close();
                }
                catch(Exception ex)
                {
                  MessageBox.Show (ex.Message);
                }

                this.Close();
            }
        }

        private void buttonDeny_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


// Scorso codice

/*
private void Connection()
{
    MySqlConnection cnn = new MySqlConnection(connectionString);

    try
    {
        cnn.Open();
        string query = "SELECT * FROM elenco";

        using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, cnn))
        {
            DataSet ds = new DataSet();
            adpt.Fill(ds);
        //    dataGridView.DataSource = ds.Tables[0];
        }

        cnn.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

private void BtnDeny_Click(object sender, EventArgs e)
{
    this.Close();
}

private void BtnSave_Click(object sender, EventArgs e)
{
    MySqlConnection connessione = new MySqlConnection(connectionString);
    try
    {
        connessione.Open();

        string query = $"UPDATE magazzino " +
            $"SET " +
            $"Descrizione = '{textBoxDescrizione.Text}', " +  
            $"WHERE  = {id_utente}";

        MySqlCommand cmd = new MySqlCommand(query, connessione);
        cmd.ExecuteNonQuery();

        connessione.Close();
    }
    catch
    {
        MessageBox.Show("Impossibile stabilire una connessione al DB");
    }

    this.Close();
}

*/
