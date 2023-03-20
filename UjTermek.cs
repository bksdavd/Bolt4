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
    public partial class UjTermek : Form
    {
        Termek t;

        internal Termek T { get => t; set => t = value; }

        public UjTermek()
        {
            InitializeComponent();
        }

        private void UjTermek_Load(object sender, EventArgs e){}

        private void btnMent_Click(object sender, EventArgs e)
        {
            if (tbNev.Text != "" && tbKod.Text != "")
            {
                if (rbTermek.Checked)
                {
                    T = new Termek(tbNev.Text, tbKod.Text, Convert.ToInt32(nudAr.Value), Convert.ToBoolean(cbLaktoz.Checked));
                }
                else
                {
                    T = new Tejtermek(tbNev.Text, tbKod.Text, Convert.ToInt32(nudAr.Value), Convert.ToBoolean(cbLaktoz.Checked), Convert.ToInt32(nudLFJ.Value));
                }
                StreamWriter w = new StreamWriter("Termekek.txt", true);
                w.WriteLine(T.ToString());
                w.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nem adta meg a termék nevét/kódját !");
            }
        }

        private void rbTejtermek_CheckedChanged(object sender, EventArgs e)
        {
            cbLaktoz.Visible = !cbLaktoz.Visible;
            nudLFJ.Visible = !nudLFJ.Visible;
            label4.Visible = !label4.Visible;
        }
    }
}
