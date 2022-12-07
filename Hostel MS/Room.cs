using Hostel_MS.helpers;
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

namespace Hostel_MS
{
    public partial class Room : Form
    {SqlData sqlData = new SqlData();

        public Room()
        {
            InitializeComponent();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string Query = "INSERT INTO tbl_Room VALUES('"+txt_Rnumber.Text+"','"+txt_floor.Text+"','"+cbm_type.Text+"','"+cbm_AttachWashroom.Text+"','"+txt_perSeatRent.Text+"','"+txt_Availableseat.Text+"') ";
            sqlData.Opencon();
            sqlData.NonQuerryExecuter(Query);
            sqlData.Closecon();
            Message_box.Error("Room");
        }
    }
}
