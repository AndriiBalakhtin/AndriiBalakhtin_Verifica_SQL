using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AndriiBalakhtin_Verifica
{
    public partial class Form1 : Form
    {
        string connectionString = "server=127.0.0.1;database=magazzino;uid=root";
        public Form1()
        {
            InitializeComponent();
            PopolaTabella("");
        }


        public void PopolaTabella(string q)
        {
            dataGridView.Rows.Clear();
            MySqlConnection connessione = new MySqlConnection(connectionString);
            try
            {
                connessione.Open();
                string query = $"SELECT * FROM products WHERE Descrizione like '{q}%' OR Produttore like '{q}%' OR Codice_produttore like '{q}%'";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView.Rows.Add(
                        dr.GetInt32("Codice_Farnell").ToString(),
                        dr.GetString("Descrizione"),
                        dr.GetString("Produttore"),
                        dr.GetString("Codice_produttore"),
                        dr.GetInt32("Quantita"),
                        dr.GetDecimal("Prezzo_unitario")
                    );
                }

                connessione.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView.AutoResizeColumns();
        }


        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView.CurrentRow.Cells[0].Value.ToString();

            Form2 formModifica = new Form2(id);

            formModifica.ShowDialog();

            // aggiorno la tabella, una volta chiusa la form di modifica
            PopolaTabella("");

        }

        private void textBoxCerca_TextChanged(object sender, EventArgs e)
        {
            PopolaTabella(textBoxSearch.Text);
        }
    }
}

// Scorso codice

/*
string connectionString = "server=127.0.0.1;database=magazzino;uid=root";

public Form1()
{
    InitializeComponent();
    dataGridViewProducts.CellDoubleClick += new DataGridViewCellEventHandler(dataGridViewProducts_CellDoubleClick);
    LoadData("");
}

private void LoadData(string q)
{
    using (MySqlConnection connection = new MySqlConnection(connectionString))
    {
        connection.Open();

        string query = "SELECT * FROM products";
        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);

        dataGridViewProducts.DataSource = dataTable;
    }
}

private void textBoxSearch_TextChanged(object sender, EventArgs e)
{
    LoadData(textBoxSearch.Text);
    string searchText = textBoxSearch.Text;
    DataView dv = new DataView(((DataTable)dataGridViewProducts.DataSource));
    dv.RowFilter = $"Descrizione LIKE '{searchText}%'";
    dataGridViewProducts.DataSource = dv;
}

private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        string id = dataGridViewProducts.CurrentRow.Cells[0].Value.ToString();

        Form2 formModifica = new Form2(id);

        formModifica.ShowDialog();

        LoadData("");
    }
}
}
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
    dataGridView.DataSource = ds.Tables[0];
}

cnn.Close();
}
catch (Exception ex)
{
MessageBox.Show(ex.Message);
}
}

private void txtBoxSearch_TextChanged(object sender, EventArgs e)
{
try
{            
DataTable datatable = (dataGridView.DataSource as DataTable);
string SearcText = txtBoxSearch.Text;

string filterExpression = string.Format($"Descrizione LIKE '{SearcText}%' OR Produttore LIKE '{SearcText}%' OR Codice_produttore Like '{SearcText}%'", SearcText);
datatable.DefaultView.RowFilter = filterExpression;
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

private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
{
string id = dataGridView.CurrentRow.Cells[0].Value.ToString();

Form2 formModifica = new Form2(id);
formModifica.ShowDialog();
Connection();
}
*/
