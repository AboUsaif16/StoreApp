using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stote_App.users
{
    public partial class pay : Form
    {
        readonly string connectionString;
        SqlConnection connection;
        public pay()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Stote_App.Properties.Settings.DBConnectionString"].ConnectionString;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pay_Load(object sender, EventArgs e)
        {
            
            Select_type.SelectedItem = null;
            Select_type.SelectedText = "--إختر--";
            search_bx.Enabled = false;
            
            //Viewusers();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string message = "هل تريد طباعة إيصال دفـع؟";
            string title = "إيصال";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //Print Payment 
            }
            else
            {
                
                this.Close();
            }
        }

        private void Viewusers()
        {
            String quary = "select Id,name from users order by name";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(quary, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable users_info = new DataTable();
                adapter.Fill(users_info);
                list.DataSource = users_info;
                list.ValueMember = "id";
                list.DisplayMember = "name";
                
            }

        }
        private void ViewVendors()
        {
            String quary = "select vendor_id,v_name from vendors order by v_name";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(quary, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable vendors_info = new DataTable();
                adapter.Fill(vendors_info);
                list.DataSource = vendors_info;
                list.ValueMember = "vendor_id";
                list.DisplayMember = "v_name";
                
            }

        }

        private void user_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void search_bx_Enter(object sender, EventArgs e)
        {
            search_bx.Text = null;
        }

        private void Select_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_bx.Enabled = true;
            if (Select_type.SelectedIndex == 0)
            {
                Viewusers();
            }
            else
            {
                ViewVendors();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
