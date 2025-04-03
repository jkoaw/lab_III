using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;

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
        [Serializable]
        public class Osoba
        {
            public string Imie;
            public string Nazwisko;
            public string Wiek;
            public string Stanowisko;
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
            public void Serializuj(string fileName)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Osoba));
                using (TextWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, this);
                }
            }
            public static Osoba Deserialize(string fileName)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Osoba));
                using (TextReader reader = new StreamReader(fileName))
                {
                    Osoba osoba = (Osoba)serializer.Deserialize(reader);
                    return osoba;
                }
            }
        }

        private void button_Xml_zapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizacjê zapisu pliku Xml";
            saveFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze lokalizacjê i zatwierdzi, zapisz plik CSV
            if (saveFileDialog1.FileName != "")
            {
                // U¿yj metody ExportToCSV i podaj obiekt DataGridView oraz œcie¿kê do pliku CSV
                zapisz_xml(saveFileDialog1.FileName);
            }
        }
        private void zapisz_xml(string path)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                {
                    continue;
                }
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    //Osoba nowa = new Osoba(dataGridView1.Rows[i].Cells[0].ToString(), dataGridView1.Rows[i].Cells[1].ToString(), dataGridView1.Rows[i].Cells[2].ToString(), dataGridView1.Rows[i].Cells[3].ToString());
                    string pierwszy = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string drugi = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string trzeci = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string czwarty = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    Osoba nowa = new Osoba(pierwszy, drugi, trzeci, czwarty);
                    nowa.Serializuj(path);
                }
            }
        }

        private void button_wczytaj_xml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywo³anie funkcji wczytuj¹cej dane z pliku CSV
                wczytaj_xml(openFileDialog1.FileName);
            }
        }
        public void wczytaj_xml(string path)
        {
            Osoba nowa = Osoba.Deserialize(path);
            dataGridView1.Rows.Add(new object[] { nowa.Imie, nowa.Nazwisko, nowa.Wiek, nowa.Stanowisko });
        }
    }
}
