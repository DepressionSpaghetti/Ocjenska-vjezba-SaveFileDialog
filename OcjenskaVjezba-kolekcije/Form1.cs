using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcjenskaVjezba_kolekcije
{
    public partial class Form1 : Form
    {
        List<Osoba> osobe = new List<Osoba>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {

            try
            {
                Osoba osoba = new Osoba(txtIme.Text, txtPrezime.Text, Convert.ToChar(cmboSpol.SelectedItem),
                    Convert.ToInt32(txtRod.Text));

                txtIme.Clear();
                txtPrezime.Clear();
                txtRod.Clear();

                osobe.Add(osoba);


            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogresan unos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();

            txtIspis.Text = "Ime" + "\t\tPrezime" + "\t\tGodina rodenja" + "\t\tSpol" + "\t\tBrkovi" + "\n";

            foreach (Osoba osoba in osobe)
            {
                txtIspis.AppendText("\n\n" + osoba.ToString());
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(osobe);
                }
            }
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
    }
}
