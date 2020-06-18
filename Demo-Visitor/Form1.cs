using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Visitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var BanhMi = new BanhMi();
            var Sua = new Sua();
            var Xoi = new Xoi();

            textBox1.Text = "Gia banh mi là" + BanhMi.COST;
        }
    }
}
