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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double quiz1, quiz2, quiz3, quiz4, quiz5;
            quiz1 = Convert.ToDouble(txtquiz1.Text);
            quiz2 = Convert.ToDouble(txtquiz2.Text);
            quiz3 = Convert.ToDouble(txtquiz3.Text);
            quiz4 = Convert.ToDouble(txtquiz4.Text);
            quiz5 = Convert.ToDouble(txtquiz5.Text);

            double midterm, final;
            midterm = Convert.ToDouble(txtmidterm.Text);
            final = Convert.ToDouble(txtfinal.Text);

            double devampuanı;
            devampuanı = Convert.ToDouble(txtdevam.Text);

            double quiz = quiz1 + quiz2 + quiz3 + quiz4 + quiz5;
            double quizOrt = quiz / 5;
            double donemsonu = (quizOrt * 0.2) + (devampuanı * 0.1) + (midterm * 0.3) + (final * 0.4);

            lblsonuc.Text = ("DÖNEM SONU PUANI: " + donemsonu);
        }
    }
}
