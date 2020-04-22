using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class FormKalkulator : Form
    {
        public FormKalkulator()
        {
            InitializeComponent();
        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }

        private void labelrownasie_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxliczba2_TextChanged(object sender, EventArgs e)
        {
            textBoxWynik.Text = "0";
        }

        private void textBoxWynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLiczenie_Click(object sender, EventArgs e)
        {
            int x, y, wynik = 0;

            try { x = Convert.ToInt32(textBoxliczba1.Text); }

            catch { x = 0; errorProvider1.SetError(textBoxliczba1, "Usterka"); MessageBox.Show("Error w polu pierwszym. Prosze wpisać liczbę naturalną.");
                textBoxliczba1.Text = "0";
                textBoxliczba2.Text = "0";
                textBoxWynik.Text = "0";
                radioButtondodawanie.Checked = true;

                errorProvider1.SetError(textBoxliczba1, "");
                errorProvider2.SetError(textBoxliczba2, "");
                }

            try { y = Convert.ToInt32(textBoxliczba2.Text); }

            catch { y = 0; errorProvider2.SetError(textBoxliczba2, "0"); 
                    MessageBox.Show("Error w polu drugim. Prosze wpisać liczbę naturalną.");
                textBoxliczba1.Text = "0";
                textBoxliczba2.Text = "0";
                textBoxWynik.Text = "0";
                radioButtondodawanie.Checked = true;

                errorProvider1.SetError(textBoxliczba1, "");
                errorProvider2.SetError(textBoxliczba2, "");
            }

            if (radioButtondodawanie.Checked) wynik = x + y;
            if (radioButtonodejmowanie.Checked) wynik = x - y;
            if (radioButtonMnozenie.Checked) wynik = x * y;
            if (radioButtondzielenie.Checked)
            {
                try { wynik = x / y; }
                catch { wynik = 0;  }
            }

            textBoxWynik.Text = Convert.ToString(wynik);

            if ((radioButtondzielenie.Checked) && (y == 0))
            {
                MessageBox.Show("Nie można podzielić przez 0!!!");
                textBoxliczba1.Text = "0";
                textBoxliczba2.Text = "0";
                textBoxWynik.Text = "0";
                radioButtondodawanie.Checked = true;

                errorProvider1.SetError(textBoxliczba1, "");
                errorProvider2.SetError(textBoxliczba2, "");
                wynik = 0;
            }
        }

        private void radioButtonmnozenie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxliczba1_TextChanged(object sender, EventArgs e)
        {
            textBoxWynik.Text = "0";
        }

        private void zerujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxliczba1.Text = "0";
            textBoxliczba2.Text = "0";
            textBoxWynik.Text = "0";
            radioButtondodawanie.Checked = true;

            errorProvider1.SetError(textBoxliczba1, "");
            errorProvider2.SetError(textBoxliczba2, "");
        }

        private void zamknijAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Bartlomiej Modliszewski");
        }
    }
}
