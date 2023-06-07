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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnbeyaz_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btnmor_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void btnsari_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnturkuaz_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }
    }
}
