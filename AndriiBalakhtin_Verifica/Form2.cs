using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MySqlConnection connessione = new MySqlConnection(connectionString);
            try
            {
                connessione.Open();
                //string query = "SELECT * FROM utenti WHERE id = '" + id + "'";
                string query = $"SELECT * FROM utenti WHERE id = '{id_utente}'";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                textBoxNome.Text = dr.GetString("Nome");
                textBoxCognome.Text = dr.GetString("Cognome");
                dateTimePicker1.Value = dr.GetDateTime("DataNascita");
            }

         }

        private void BtnDeny_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            

    

           
        }

        
    }
}
