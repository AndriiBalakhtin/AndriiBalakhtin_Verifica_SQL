namespace AndriiBalakhtin_Verifica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            Codice_Farnell = new DataGridViewTextBoxColumn();
            Descrizione = new DataGridViewTextBoxColumn();
            Produttore = new DataGridViewTextBoxColumn();
            Codice_produttore = new DataGridViewTextBoxColumn();
            Quantita = new DataGridViewTextBoxColumn();
            Prezzo_unitario = new DataGridViewTextBoxColumn();
            textBoxSearch = new TextBox();
            BoxSearch = new GroupBox();
            BoxElenco = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            BoxSearch.SuspendLayout();
            BoxElenco.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Codice_Farnell, Descrizione, Produttore, Codice_produttore, Quantita, Prezzo_unitario });
            dataGridView.Location = new Point(6, 22);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1040, 420);
            dataGridView.TabIndex = 0;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // Codice_Farnell
            // 
            Codice_Farnell.HeaderText = "Codice_Farnell";
            Codice_Farnell.Name = "Codice_Farnell";
            Codice_Farnell.Width = 90;
            // 
            // Descrizione
            // 
            Descrizione.HeaderText = "Descrizione";
            Descrizione.Name = "Descrizione";
            Descrizione.Width = 400;
            // 
            // Produttore
            // 
            Produttore.HeaderText = "Produttore";
            Produttore.Name = "Produttore";
            Produttore.Width = 150;
            // 
            // Codice_produttore
            // 
            Codice_produttore.HeaderText = "Codice_produttore";
            Codice_produttore.Name = "Codice_produttore";
            Codice_produttore.Width = 150;
            // 
            // Quantita
            // 
            Quantita.HeaderText = "Quantita";
            Quantita.Name = "Quantita";
            // 
            // Prezzo_unitario
            // 
            Prezzo_unitario.HeaderText = "Prezzo_unitario";
            Prezzo_unitario.Name = "Prezzo_unitario";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(6, 14);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(100, 23);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxCerca_TextChanged;
            // 
            // BoxSearch
            // 
            BoxSearch.Controls.Add(textBoxSearch);
            BoxSearch.Location = new Point(12, 12);
            BoxSearch.Name = "BoxSearch";
            BoxSearch.Size = new Size(114, 43);
            BoxSearch.TabIndex = 2;
            BoxSearch.TabStop = false;
            BoxSearch.Text = "Search";
            // 
            // BoxElenco
            // 
            BoxElenco.Controls.Add(dataGridView);
            BoxElenco.Location = new Point(12, 55);
            BoxElenco.Name = "BoxElenco";
            BoxElenco.Size = new Size(1052, 448);
            BoxElenco.TabIndex = 3;
            BoxElenco.TabStop = false;
            BoxElenco.Text = "Elenco";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1076, 515);
            Controls.Add(BoxElenco);
            Controls.Add(BoxSearch);
            Name = "Form1";
            Text = "Andrii Balakhtin Verifica ";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            BoxSearch.ResumeLayout(false);
            BoxSearch.PerformLayout();
            BoxElenco.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox TextBoxSearch;
        private TextBox textBoxSearch;
        private GroupBox BoxSearch;
        private GroupBox BoxElenco;
        private DataGridViewTextBoxColumn Codice_Farnell;
        private DataGridViewTextBoxColumn Descrizione;
        private DataGridViewTextBoxColumn Produttore;
        private DataGridViewTextBoxColumn Codice_produttore;
        private DataGridViewTextBoxColumn Quantita;
        private DataGridViewTextBoxColumn Prezzo_unitario;
    }
}