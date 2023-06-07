using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeyzaHolat_Ödev4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private bool KontrolUyumu(string kelime)
        {
            string[] buyukUnluler = { "A", "I", "O", "U", "İ" };
            string[] kucukUnluler = { "a", "ı", "o", "u", "i" };

            bool buyukUyumu = false;
            bool kucukUyumu = false;

            foreach (char karakter in kelime)
            {
                if (buyukUnluler.Contains(karakter.ToString()))
                {
                    buyukUyumu = true;
                }
                else if (kucukUnluler.Contains(karakter.ToString()))
                {
                    kucukUyumu = true;
                }
            }

            return buyukUyumu && kucukUyumu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = txtBxKelime.Text;
            bool uyumlu = KontrolUyumu(kelime);

            if (uyumlu)
            {
                MessageBox.Show("Kelime büyük küçük ünlü uyumuna uyar.");
            }
            else
            {
                MessageBox.Show("Kelime büyük küçük ünlü uyumuna uymaz.");
            }
        }
    }
}
