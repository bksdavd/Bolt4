using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bolt4
{
    public partial class Form1 : Form
    {
        List<Termek> termekek = new List<Termek>();
        public Form1()
        {
            InitializeComponent();
            Beolvas();
        }

        private void Beolvas()
        {
            if (File.Exists("Termekek.txt"))
            {
                StreamReader r = new StreamReader("Termekek.txt");
                while (!r.EndOfStream)
                {
                    Termek t;
                    string[] s = r.ReadLine().Split(';');
                    if (s.Length == 4)
                    {
                        t = new Termek(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToBoolean(s[3]));
                    }
                    else
                    {
                        t = new Tejtermek(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToBoolean(s[3]), Convert.ToInt32(s[4]));
                    }
                    termekek.Add(t);
                    lbKosar.Items.Add(t.Nev);
                }
                r.Close();
            }
        }

        private void újElemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UjTermek uj = new UjTermek();
            if (uj.ShowDialog() == DialogResult.OK)
            {
                termekek.Add(uj.T);
                lbKosar.Items.Add(uj.T.Nev);
            }
        }

        private void lbKosar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kiir();
        }

        private void Kiir()
        {
            if (lbKosar.SelectedIndex >= 0)
            {
                tbNev.Text = termekek[lbKosar.SelectedIndex].Nev;
                tbKod.Text = termekek[lbKosar.SelectedIndex].Kod;
                tbAr.Text = termekek[lbKosar.SelectedIndex].Ar.ToString();
                if (termekek[lbKosar.SelectedIndex] is Tejtermek)
                {
                    label5.Visible = true;
                    tbLFJ.Visible = true;
                    Tejtermek t = termekek[lbKosar.SelectedIndex] as Tejtermek;
                    tbLFJ.Text = t.Lfj.ToString();
                }
                else
                {
                    label5.Visible = false;
                    tbLFJ.Visible = false;
                }
                if (termekek[lbKosar.SelectedIndex].Laktoz)
                {
                    labLak.Visible = true;
                }
                else
                {
                    labLak.Visible = false;
                }

            }
        }
    }
}
