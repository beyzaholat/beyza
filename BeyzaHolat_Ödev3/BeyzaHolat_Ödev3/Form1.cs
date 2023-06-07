using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeyzaHolat_Ödev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adSoyad = txtbxAdsoyad.Text;
            string ogrenciNo = txtbxNo.Text;

            if (!string.IsNullOrEmpty(adSoyad) && !string.IsNullOrEmpty(ogrenciNo))
            {
                ListboxOgrenciAdiSoyadi.Items.Add(adSoyad);
                ListboxOgrenciNo.Items.Add(ogrenciNo);

                txtbxAdsoyad.Clear();
                txtbxNo.Clear();

                lblToplamKayit.Text = "Toplam Kayıt:" + ListboxOgrenciAdiSoyadi.Items.Count;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliOgrenci = ListboxOgrenciAdiSoyadi.SelectedIndex;

            if (seciliOgrenci != -1)
            {
                ListboxOgrenciAdiSoyadi.Items.RemoveAt(seciliOgrenci);
                ListboxOgrenciNo.Items.RemoveAt(seciliOgrenci);

                txtbxAdsoyad.Clear();
                txtbxNo.Clear();

                lblToplamKayit.Text = "Toplam Kayıt:" + ListboxOgrenciAdiSoyadi.Items.Count;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ListboxOgrenciAdiSoyadi.Items.Clear();
            ListboxOgrenciNo.Items.Clear();


            txtbxAdsoyad.Clear();
            txtbxNo.Clear();

            lblToplamKayit.Text = "Toplam Kayıt:0";
        }

        private void ListboxOgrenciAdiSoyadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliOgrenci = ListboxOgrenciAdiSoyadi.SelectedIndex;

            if (seciliOgrenci != -1)
            {
                txtbxAdsoyad.Text = ListboxOgrenciAdiSoyadi.Items[seciliOgrenci].ToString();
                txtbxNo.Text = ListboxOgrenciNo.Items[seciliOgrenci].ToString();
            }
        }
    }
}