using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grslprogodev
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random r = new Random();
            int i = 1, toplam = 0;
            while(i <= 10)
            {
                int sayi = r.Next(1, 101);

                if (listBox1.Items.IndexOf(sayi) == -1)
                {
                    listBox1.Items.Add(sayi);
                    i++;
                    toplam += i;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedIndex == 0)
            {
                int toplam = 0;
                double ortalama = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    toplam = toplam + Convert.ToInt32(listBox1.Items[i]);
                    ortalama = toplam / listBox1.Items.Count;
                }
                MessageBox.Show("Ortalama: " + ortalama.ToString());
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                int buyuk;
                buyuk = Convert.ToInt32(listBox1.Items[0]);
                int sayi;

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sayi = Convert.ToInt32(listBox1.Items[i]);
                    if (buyuk < sayi)
                    {
                        buyuk = sayi;
                    }
                }
                MessageBox.Show("Max Değer: " + buyuk.ToString());
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                int kucuk;
                kucuk = Convert.ToInt32(listBox1.Items[0]);
                int sayi;

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sayi = Convert.ToInt32(listBox1.Items[i]);
                    if (kucuk > sayi)
                    {
                        kucuk = sayi;
                    }
                }
                MessageBox.Show("Min Değer: " + kucuk.ToString());
            }
        }
    }
}
