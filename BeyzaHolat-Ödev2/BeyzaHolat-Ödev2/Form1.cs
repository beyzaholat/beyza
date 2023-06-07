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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntmzle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnelemanekle_Click(object sender, EventArgs e)
        {
            string yeniEleman = txtbxelemanekle.Text;
            listBox1.Items.Add(yeniEleman);

            txtbxelemanekle.Clear();
        }

        private void btnsirala_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void btnelemangoster_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem !=null)
            {
                txtbxelemangoster.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void btnsay_Click(object sender, EventArgs e)
        {
            int elemanSayısı = listBox1.Items.Count;
            MessageBox.Show("Listedeki Eleman Sayısı: " + elemanSayısı);
        }
    }
}
