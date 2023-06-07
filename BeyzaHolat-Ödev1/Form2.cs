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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilk = Convert.ToInt16(txtbaslangic.Text);
            int son = Convert.ToInt16(txtbitis.Text);
            int toplam = 0;

            if (rdbtntumu.Checked)
            {
                for (int i = ilk; i <= son; i++)
                {
                    toplam += i;
                }
            }
            else if (rdbtntek.Checked)
            {
                for (int i = ilk; i <= son; i++)
                {
                    if (i % 2 == 1)
                    {
                        toplam += i;
                    }
                }
            }
            else if (rdbtncift.Checked) 
            {
                for (int i = ilk; i <= son; i++)
                {
                    if (i % 2 == 0)
                    {
                        toplam += i;
                    }
                }
            }
            lblsonuc.Text = ("SONUÇ: " + toplam.ToString());
        }
    }
}
