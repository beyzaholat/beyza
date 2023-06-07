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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int paraMiktarı = Convert.ToInt32(txtbxPara.Text);

            int ikiYuzTl = paraMiktarı / 200;
            paraMiktarı %= 200;

            int yuzTl = paraMiktarı / 100;
            paraMiktarı %= 100;

            int elliTl = paraMiktarı / 50;
            paraMiktarı %= 50;

            int yirmiTl = paraMiktarı / 20;
            paraMiktarı %= 20;

            int onTl = paraMiktarı / 10;
            paraMiktarı %= 10;

            int besTl = paraMiktarı / 5;
            paraMiktarı %= 5;

            int birTl = paraMiktarı;

            listBox1.Items.Clear();
            listBox1.Items.Add("200 TL:" + ikiYuzTl.ToString());
            listBox1.Items.Add("100 TL:" + yuzTl.ToString());
            listBox1.Items.Add("50 TL:" + elliTl.ToString());
            listBox1.Items.Add("20 TL:" + yirmiTl.ToString());
            listBox1.Items.Add("10 TL:" + onTl.ToString());
            listBox1.Items.Add("5 TL:" + besTl.ToString());
            listBox1.Items.Add("1 TL:" + birTl.ToString());
        }
    }
}
