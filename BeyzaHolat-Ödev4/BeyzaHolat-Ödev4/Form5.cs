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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime suankiZaman = DateTime.Now;

            progressBarSaat.Value = suankiZaman.Hour;
            lblSaat.Text = suankiZaman.Hour.ToString("D2");

            progressBarDakika.Value = suankiZaman.Minute;
            lblDakika.Text = suankiZaman.Minute.ToString("D2");

            progressBarSaniye.Value = suankiZaman.Second;
            lblSaniye.Text = suankiZaman.Second.ToString("D2");
        }
    }
}
