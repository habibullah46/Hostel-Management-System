using Hostel_MS.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void chk_showpas_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_showpas.CheckState==CheckState.Checked)
            {
                txt_password.UseSystemPasswordChar = false;

            }
            else if(chk_showpas.CheckState==CheckState.Unchecked)
            {
                txt_password.UseSystemPasswordChar = true;
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * from tbl_login Where UserName ='" + txt_userName.Text + "'AND Password='" + txt_password + "'";
            SqlConnection con = new SqlConnection(SqlData.Constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);    
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                Message_box.Error ("Invalid Username or Password");
                txt_userName.Clear();
                txt_password.Clear();
                txt_userName.Focus();

            }
        }
    }
}
