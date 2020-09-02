using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stote_App
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            @lock lck = new @lock();
            lck.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            products.add_product add_N = new products.add_product();
            add_N.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            users.add_user add_N = new users.add_user();
            add_N.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.pay pay = new users.pay();
            pay.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
