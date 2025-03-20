namespace lab_III
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
            button_zapisz = new Button();
            button_wczytaj = new Button();
            button_usun = new Button();
            button_dodaj = new Button();
            dataGridView1 = new DataGridView();
            Imie = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            Wiek = new DataGridViewTextBoxColumn();
            Stanowisko = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_zapisz
            // 
            button_zapisz.Location = new Point(41, 359);
            button_zapisz.Name = "button_zapisz";
            button_zapisz.Size = new Size(95, 23);
            button_zapisz.TabIndex = 0;
            button_zapisz.Text = "zapisz do csv";
            button_zapisz.UseVisualStyleBackColor = true;
            button_zapisz.Click += button_zapisz_Click;
            // 
            // button_wczytaj
            // 
            button_wczytaj.Location = new Point(276, 359);
            button_wczytaj.Name = "button_wczytaj";
            button_wczytaj.Size = new Size(75, 23);
            button_wczytaj.TabIndex = 1;
            button_wczytaj.Text = "wczytaj csv";
            button_wczytaj.UseVisualStyleBackColor = true;
            button_wczytaj.Click += button_wczytaj_Click;
            // 
            // button_usun
            // 
            button_usun.Location = new Point(479, 165);
            button_usun.Name = "button_usun";
            button_usun.Size = new Size(75, 23);
            button_usun.TabIndex = 2;
            button_usun.Text = "Usun";
            button_usun.UseVisualStyleBackColor = true;
            button_usun.Click += button_usun_Click;
            // 
            // button_dodaj
            // 
            button_dodaj.Location = new Point(479, 45);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(75, 23);
            button_dodaj.TabIndex = 3;
            button_dodaj.Text = "Dodaj";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Imie, Nazwisko, Wiek, Stanowisko });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 278);
            dataGridView1.TabIndex = 4;
            // 
            // Imie
            // 
            Imie.HeaderText = "Imie";
            Imie.Name = "Imie";
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.Name = "Nazwisko";
            // 
            // Wiek
            // 
            Wiek.HeaderText = "Wiek";
            Wiek.Name = "Wiek";
            // 
            // Stanowisko
            // 
            Stanowisko.HeaderText = "Stanowisko";
            Stanowisko.Name = "Stanowisko";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button_dodaj);
            Controls.Add(button_usun);
            Controls.Add(button_wczytaj);
            Controls.Add(button_zapisz);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_zapisz;
        private Button button_wczytaj;
        private Button button_usun;
        private Button button_dodaj;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Imie;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn Wiek;
        private DataGridViewTextBoxColumn Stanowisko;
    }
}
