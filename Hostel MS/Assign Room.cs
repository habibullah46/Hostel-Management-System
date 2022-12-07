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
    public partial class Assign_Room : Form
    {
        public Assign_Room()
        {
            InitializeComponent();
        }

        private void Assign_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDbDataSet9.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter.Fill(this.hostelDbDataSet9.tbl_Room);
            // TODO: This line of code loads data into the 'hostelDbDataSet8.tbl_Student' table. You can move, or remove it, as needed.
            this.tbl_StudentTableAdapter.Fill(this.hostelDbDataSet8.tbl_Student);

        }

        private void cbm_CNIC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_Student Where CNIC='" + cbm_CNIC.Text + "'";
            SqlConnection con = new SqlConnection(SqlData.Constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_StudentName.Text = dr["Name"].ToString();
            }

        }

        private void cbm_RoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {



            string Query = " SELECT * FROM  tbl_Room Where RoomNumber='" + cbm_RoomNo.Text + "'";
            SqlConnection con = new SqlConnection(SqlData.Constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_avaibseat.Text = dr["AvailableSeat"].ToString();


            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int NumberOfSeats=0;
            string Query = "INSERT INTO tbl_AssignRoom Values('" + cbm_CNIC.Text + "','" + txt_StudentName.Text + "','" + cbm_RoomNo.Text + "')";
            //string UpdateQuery = "UPDATE tbl_Room SET AvailableSeat='" + NumberOfSeats + "'Where RoomNumber='" + cbm_RoomNo.Text + "'";
            SqlData sql = new SqlData();
            sql.Opencon();
            sql.NonQuerryExecuter(Query);
            NumberOfSeats=Convert.ToInt32(txt_avaibseat.Text);
            NumberOfSeats = NumberOfSeats - 1;
            sql.NonQuerryExecuter("UPDATE tbl_Room SET AvailableSeat='" + NumberOfSeats + "'Where RoomNumber='" + cbm_RoomNo.Text + "'");
            sql.Closecon();

        }
    }
}
