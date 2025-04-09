using System.Data;
using System.Text.Json;
using System.Windows.Forms;

namespace lab_III
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        public void dodaj(string Imie, string Nazwisko, string Wiek, string Stanowisko)
        {
            dataGridView1.Rows.Add(new object[] { Imie, Nazwisko, Wiek, Stanowisko });
        }
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            Form2 cos = new Form2(this);
            cos.Show();
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
        private void zapisz(string path)
        {
            string csvContent = "Imie,Nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Pomijaj wiersze niemieszcz¹ce siê w DataGridView (np. wiersz zaznaczania)
                if (!row.IsNewRow)
                {
                    // Dodaj kolejne wartoœci w wierszu, oddzielone przecinkami
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            // Zapisanie zawartoœci do pliku CSV
            File.WriteAllText(path, csvContent);
        }
        private void zapytaj_o_path()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizacjê zapisu pliku CSV";
            saveFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze lokalizacjê i zatwierdzi, zapisz plik CSV
            if (saveFileDialog1.FileName != "")
            {
                // U¿yj metody ExportToCSV i podaj obiekt DataGridView oraz œcie¿kê do pliku CSV
                zapisz(saveFileDialog1.FileName);
            }
        }
        private void wczytaj(string cos)
        {
            if (!File.Exists(cos))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Odczytaj zawartoœæ pliku CSV
            string[] lines = File.ReadAllLines(cos);
            // Tworzenie tabeli danych
            // Dodanie kolumn na podstawie nag³ówka
            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                //dataTable.Columns.Add(header);
            }
            // Dodawanie wierszy do tabeli danych
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                dataGridView1.Rows.Add(values);
            }
            // Przypisanie tabeli danych do DataGridView
        }
        public class Osoba
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string Wiek { get; set; }
            public string Stanowisko { get; set; }
            public Osoba(string Im, string Naz, string Wie, string Stano)
            {
                Imie = Im;
                Nazwisko = Naz;
                Wiek = Wie;
                Stanowisko = Stano;
            }
            public Osoba()
            {

            }
        }
            private void button_zapisz_Click(object sender, EventArgs e)
        {
            zapytaj_o_path();
        }

        private void button_wczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywo³anie funkcji wczytuj¹cej dane z pliku CSV
                wczytaj(openFileDialog1.FileName);
            }
        }
        private void button_save_json_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizacjê zapisu pliku CSV";
            saveFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze lokalizacjê i zatwierdzi, zapisz plik CSV
            if (saveFileDialog1.FileName != "")
            {
                // U¿yj metody ExportToCSV i podaj obiekt DataGridView oraz œcie¿kê do pliku CSV
                zapisz_jn(saveFileDialog1.FileName);
            }
        }
        private void zapisz_jn(string path)
        {
            string do_zapisu_json = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                {
                    continue;
                }
                //Osoba nowa = new Osoba(dataGridView1.Rows[i].Cells[0].ToString(), dataGridView1.Rows[i].Cells[1].ToString(), dataGridView1.Rows[i].Cells[2].ToString(), dataGridView1.Rows[i].Cells[3].ToString());
                string pierwszy = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string drugi = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string trzeci = dataGridView1.Rows[i].Cells[2].Value.ToString();
                string czwarty = dataGridView1.Rows[i].Cells[3].Value.ToString();
                Osoba nowa = new Osoba(pierwszy, drugi, trzeci, czwarty);
                do_zapisu_json += JsonSerializer.Serialize(nowa);
                do_zapisu_json += "\n";
            }
            File.WriteAllText(path, do_zapisu_json);
        }
        private void button_wczytaj_j_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik JSON do wczytania";
            openFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze lokalizacjê i zatwierdzi, zapisz plik CSV
            if (openFileDialog1.FileName != "")
            {
                // U¿yj metody ExportToCSV i podaj obiekt DataGridView oraz œcie¿kê do pliku CSV
                wczytaj_js(openFileDialog1.FileName);
            }
        }
        private void wczytaj_js(string path)
        {
            StreamReader file = new StreamReader(path);
            string line = file.ReadLine();
            while (line != null)
            {
                Osoba nowa = JsonSerializer.Deserialize<Osoba>(line);
                dodaj(nowa.Imie, nowa.Nazwisko, nowa.Wiek, nowa.Stanowisko);
                line = file.ReadLine();
            }
        }
    }
}
