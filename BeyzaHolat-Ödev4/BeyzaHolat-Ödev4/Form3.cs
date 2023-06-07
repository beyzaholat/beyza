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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtBxSayi_TextChanged(object sender, EventArgs e)
        {
            string girilenSayilar = txtBxSayi.Text.Replace(",", ""); 
            string sonuc = "";

            for (int i = 0; i < girilenSayilar.Length; i++)
            {
                sonuc += girilenSayilar[i];
                if ((i + 1) % 3 == 0 && i != girilenSayilar.Length - 1)
                {
                    sonuc += ",";
                }
            }

            txtBxSayi.Text = sonuc; 
            txtBxSayi.SelectionStart = txtBxSayi.Text.Length;
        }
    }
}
