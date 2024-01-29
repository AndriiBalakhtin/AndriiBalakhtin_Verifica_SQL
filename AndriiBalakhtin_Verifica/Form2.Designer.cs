namespace AndriiBalakhtin_Verifica
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBoxDescrizione = new TextBox();
            label4 = new Label();
            textBoxProduttore = new TextBox();
            label3 = new Label();
            textBoxCodiceProduttore = new TextBox();
            label2 = new Label();
            textBoxQuantita = new TextBox();
            label1 = new Label();
            textBoxPrezzoUnitario = new TextBox();
            LblCodiceFarnel = new Label();
            buttonDeny = new Button();
            buttonSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxDescrizione);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxProduttore);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxCodiceProduttore);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxQuantita);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxPrezzoUnitario);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 72);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modifica";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 25);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 10;
            label5.Text = "Prezzo_Unitario";
            // 
            // textBoxDescrizione
            // 
            textBoxDescrizione.Location = new Point(6, 43);
            textBoxDescrizione.Name = "textBoxDescrizione";
            textBoxDescrizione.Size = new Size(100, 23);
            textBoxDescrizione.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 25);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "Quantità";
            // 
            // textBoxProduttore
            // 
            textBoxProduttore.Location = new Point(112, 43);
            textBoxProduttore.Name = "textBoxProduttore";
            textBoxProduttore.Size = new Size(100, 23);
            textBoxProduttore.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 25);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 8;
            label3.Text = "Codice_Produttore";
            // 
            // textBoxCodiceProduttore
            // 
            textBoxCodiceProduttore.Location = new Point(218, 43);
            textBoxCodiceProduttore.Name = "textBoxCodiceProduttore";
            textBoxCodiceProduttore.Size = new Size(100, 23);
            textBoxCodiceProduttore.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 25);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 7;
            label2.Text = "Produttore";
            // 
            // textBoxQuantita
            // 
            textBoxQuantita.Location = new Point(324, 43);
            textBoxQuantita.Name = "textBoxQuantita";
            textBoxQuantita.Size = new Size(100, 23);
            textBoxQuantita.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Descrizione";
            // 
            // textBoxPrezzoUnitario
            // 
            textBoxPrezzoUnitario.Location = new Point(430, 43);
            textBoxPrezzoUnitario.Name = "textBoxPrezzoUnitario";
            textBoxPrezzoUnitario.Size = new Size(100, 23);
            textBoxPrezzoUnitario.TabIndex = 5;
            // 
            // LblCodiceFarnel
            // 
            LblCodiceFarnel.AutoSize = true;
            LblCodiceFarnel.Location = new Point(18, 111);
            LblCodiceFarnel.Name = "LblCodiceFarnel";
            LblCodiceFarnel.Size = new Size(84, 15);
            LblCodiceFarnel.TabIndex = 3;
            LblCodiceFarnel.Text = "Codice_Farnel:";
            // 
            // buttonDeny
            // 
            buttonDeny.Location = new Point(392, 107);
            buttonDeny.Name = "buttonDeny";
            buttonDeny.Size = new Size(75, 23);
            buttonDeny.TabIndex = 4;
            buttonDeny.Text = "Deny";
            buttonDeny.UseVisualStyleBackColor = true;
            buttonDeny.Click += buttonDeny_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(473, 107);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 135);
            Controls.Add(buttonSave);
            Controls.Add(buttonDeny);
            Controls.Add(LblCodiceFarnel);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Editor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBoxDescrizione;
        private Label label4;
        private TextBox textBoxProduttore;
        private Label label3;
        private TextBox textBoxCodiceProduttore;
        private Label label2;
        private TextBox textBoxQuantita;
        private Label label1;
        private TextBox textBoxPrezzoUnitario;
        private Label LblCodiceFarnel;
        private Button buttonDeny;
        private Button buttonSave;
    }
}