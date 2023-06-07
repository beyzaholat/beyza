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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
        private void btnpanter_Click(object sender, EventArgs e)
        {
            pctrpanter.Visible = true;
            rchtxtbxpanter.Visible = true;
        }

        private void btnjaguar_Click(object sender, EventArgs e)
        {
            pctrjaguar.Visible = true;
            rchtxtbxjaguar.Visible = true;
        }

        private void btnleopar_Click(object sender, EventArgs e)
        {
            pctrleopar.Visible = true;
            rchtxtbxleopar.Visible = true;
        }
    }
}
