using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sotrudniki sot = new sotrudniki();
            sot.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zadachi zad = new zadachi();
            zad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            otdel otd = new otdel();
            otd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proekt pro = new proekt();
            pro.ShowDialog();
        }
    }
}
