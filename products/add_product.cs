using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stote_App.products
{
    public partial class add_product : Form
    {

        string type_ = "";
        public add_product()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ChkInput()) 
            {
                AddPrd();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_product_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ChkInput()
        {
            if (txtName.Text == "" || txtBuy.Text == "0" || txtSell.Text == "0" || txtAmount.Text == "0" || type_ == "" )
            {
                MessageBox.Show("الؤجاء التأكد من صحه البيانات", "خطأ");
                return false;
            }
            return true;
        }

        private void AddPrd()
        {
            MessageBox.Show("تم إضافة صنف جديد", "عملية ناجحه");
        }

        private void type1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
