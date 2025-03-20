using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_III
{
    public partial class Form2 : Form
    {
        Form1 pare;
        public Form2(Form1 par)
        {
            InitializeComponent();
            this.pare = par;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            pare.dodaj(textBox_imie.Text, textBox_nazwisko.Text, textBox_wiek.Text, textBox_stanowisko.Text);
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
