using Hostel_MS.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS
{
    public partial class tbl_Student_Registration : Form
    {
        SqlData sqlData = new SqlData();
       
        public tbl_Student_Registration()
        {
            InitializeComponent();
        }

        private void Student_Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Query = "INSERT INTO tbl_Student Values('" + txt_CNIC.Text + "','" + txt_name.Text + "','" + txt_fathername.Text + "','" + txt_address.Text + "','" + txt_mobile.Text + "','" + txt_Edu_institute.Text + "','" + txt_class.Text + "','" + cmb_DateofRegistration.Text + "','" + txt_dateofbirth.Text + "','" + txt_bloodgroup.Text + "','" +txt_Gnumber.Text+ "','" + txt_Gname.Text+ "')";
            sqlData.Opencon();
            sqlData.NonQuerryExecuter(Query);
            sqlData.Closecon();
            Message_box.Error("Room");
        }
    }
}
