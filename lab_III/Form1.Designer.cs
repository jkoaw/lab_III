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
            button_save_json = new Button();
            button_wczytaj_j = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_zapisz
            // 
            button_zapisz.Location = new Point(47, 479);
            button_zapisz.Margin = new Padding(3, 4, 3, 4);
            button_zapisz.Name = "button_zapisz";
            button_zapisz.Size = new Size(109, 31);
            button_zapisz.TabIndex = 0;
            button_zapisz.Text = "zapisz do csv";
            button_zapisz.UseVisualStyleBackColor = true;
            button_zapisz.Click += button_zapisz_Click;
            // 
            // button_wczytaj
            // 
            button_wczytaj.Location = new Point(315, 479);
            button_wczytaj.Margin = new Padding(3, 4, 3, 4);
            button_wczytaj.Name = "button_wczytaj";
            button_wczytaj.Size = new Size(86, 31);
            button_wczytaj.TabIndex = 1;
            button_wczytaj.Text = "wczytaj csv";
            button_wczytaj.UseVisualStyleBackColor = true;
            button_wczytaj.Click += button_wczytaj_Click;
            // 
            // button_usun
            // 
            button_usun.Location = new Point(547, 220);
            button_usun.Margin = new Padding(3, 4, 3, 4);
            button_usun.Name = "button_usun";
            button_usun.Size = new Size(86, 31);
            button_usun.TabIndex = 2;
            button_usun.Text = "Usun";
            button_usun.UseVisualStyleBackColor = true;
            button_usun.Click += button_usun_Click;
            // 
            // button_dodaj
            // 
            button_dodaj.Location = new Point(547, 60);
            button_dodaj.Margin = new Padding(3, 4, 3, 4);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(86, 31);
            button_dodaj.TabIndex = 3;
            button_dodaj.Text = "Dodaj";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Imie, Nazwisko, Wiek, Stanowisko });
            dataGridView1.Location = new Point(14, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(527, 371);
            dataGridView1.TabIndex = 4;
            // 
            // Imie
            // 
            Imie.HeaderText = "Imie";
            Imie.MinimumWidth = 6;
            Imie.Name = "Imie";
            Imie.Width = 125;
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.MinimumWidth = 6;
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Width = 125;
            // 
            // Wiek
            // 
            Wiek.HeaderText = "Wiek";
            Wiek.MinimumWidth = 6;
            Wiek.Name = "Wiek";
            Wiek.Width = 125;
            // 
            // Stanowisko
            // 
            Stanowisko.HeaderText = "Stanowisko";
            Stanowisko.MinimumWidth = 6;
            Stanowisko.Name = "Stanowisko";
            Stanowisko.Width = 125;
            // 
            // button_save_json
            // 
            button_save_json.Location = new Point(162, 479);
            button_save_json.Name = "button_save_json";
            button_save_json.Size = new Size(121, 29);
            button_save_json.TabIndex = 5;
            button_save_json.Text = "zapisz do json";
            button_save_json.UseVisualStyleBackColor = true;
            button_save_json.Click += button_save_json_Click;
            // 
            // button_wczytaj_j
            // 
            button_wczytaj_j.Location = new Point(407, 481);
            button_wczytaj_j.Name = "button_wczytaj_j";
            button_wczytaj_j.Size = new Size(134, 29);
            button_wczytaj_j.TabIndex = 6;
            button_wczytaj_j.Text = "wczytaj json";
            button_wczytaj_j.UseVisualStyleBackColor = true;
            button_wczytaj_j.Click += button_wczytaj_j_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button_wczytaj_j);
            Controls.Add(button_save_json);
            Controls.Add(dataGridView1);
            Controls.Add(button_dodaj);
            Controls.Add(button_usun);
            Controls.Add(button_wczytaj);
            Controls.Add(button_zapisz);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button_save_json;
        private Button button_wczytaj_j;
    }
}
