using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeyzaHolat_Ödev2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string kullaniciAdi = "student", sifre = "yasar20";

        private void txtbxad_TextChanged(object sender, EventArgs e)
        {
            if (txtbxad.Text == kullaniciAdi && txtbxsifre.Text == sifre)
            {
                button1.Enabled = true;
            }
        }

        private void txtbxsifre_TextChanged(object sender, EventArgs e)
        {
            if (txtbxad.Text == kullaniciAdi && txtbxsifre.Text == sifre)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbxad.Text == kullaniciAdi && txtbxsifre.Text == sifre)
            {
                Form5 frm = new Form5();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreyi hatalı girdiniz.Lütfen Tekrar Deneyin.");
                txtbxad.Clear();
                txtbxsifre.Clear();
            }
        }
    }
}
