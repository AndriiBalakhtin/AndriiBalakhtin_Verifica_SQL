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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.BoxSearch = new System.Windows.Forms.GroupBox();
            this.BoxElenco = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.BoxSearch.SuspendLayout();
            this.BoxElenco.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(689, 267);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(6, 14);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSearch.TabIndex = 1;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // BoxSearch
            // 
            this.BoxSearch.Controls.Add(this.txtBoxSearch);
            this.BoxSearch.Location = new System.Drawing.Point(12, 83);
            this.BoxSearch.Name = "BoxSearch";
            this.BoxSearch.Size = new System.Drawing.Size(114, 43);
            this.BoxSearch.TabIndex = 2;
            this.BoxSearch.TabStop = false;
            this.BoxSearch.Text = "Search";
            // 
            // BoxElenco
            // 
            this.BoxElenco.Controls.Add(this.dataGridView);
            this.BoxElenco.Location = new System.Drawing.Point(12, 132);
            this.BoxElenco.Name = "BoxElenco";
            this.BoxElenco.Size = new System.Drawing.Size(702, 295);
            this.BoxElenco.TabIndex = 3;
            this.BoxElenco.TabStop = false;
            this.BoxElenco.Text = "Elenco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(719, 433);
            this.Controls.Add(this.BoxElenco);
            this.Controls.Add(this.BoxSearch);
            this.Name = "Form1";
            this.Text = "Andrii Balakhtin Verifica ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.BoxSearch.ResumeLayout(false);
            this.BoxSearch.PerformLayout();
            this.BoxElenco.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView;
        private TextBox TextBoxSearch;
        private TextBox txtBoxSearch;
        private GroupBox BoxSearch;
        private GroupBox BoxElenco;
    }
}