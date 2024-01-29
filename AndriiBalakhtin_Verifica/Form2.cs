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
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AndriiBalakhtin_Verifica
{
    public partial class Form2 : Form
    {
        public string id_utente;
        string connectionString = "server=127.0.0.1;database=magazzino;uid=root";

        public Form2(string id)
        {
            InitializeComponent();
            id_utente = id;
        }
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


    }
}
