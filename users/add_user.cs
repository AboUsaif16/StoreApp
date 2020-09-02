using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stote_App.users
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        private void vendor_CheckedChanged(object sender, EventArgs e)
        {
            if(vendor.Checked == true)
            {
                Addrtxt.Enabled = false;
                Addrtxt.Visible = false;
                Addrlb.Visible = false;
            }
            else
            {
                Addrtxt.Enabled = true;
                Addrtxt.Visible = true;
                Addrlb.Visible = true;
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_user_Load(object sender, EventArgs e)
        {
            user.Checked = true;
        }
    }
}
