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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            for (int i = 0; i < 20; i++)
            {
                int sayi = rnd.Next(150);

                if (sayi < 10)
                {
                    listBox1.Items.Add(sayi);
                }
                else if (sayi < 100)
                {
                    listBox2.Items.Add(sayi);
                }
                else
                {
                    listBox3.Items.Add(sayi);
                }
            }
        }
    }
}
