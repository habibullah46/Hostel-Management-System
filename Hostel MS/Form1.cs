using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl_Student_Registration student = new tbl_Student_Registration();
            student.MdiParent = this;
            student.Show();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_New_Staff staff = new Register_New_Staff();
            staff.MdiParent = this;
            staff.Show();
        }

        private void registerRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.MdiParent = this;  
            room.Show();
        }

        private void addVisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visitor_Entry visitor = new Visitor_Entry();    
            visitor.MdiParent = this;   
            visitor.Show(); 
        }

        private void assignRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign_Room Aroom = new Assign_Room();
            Aroom.MdiParent = this;
            Aroom.Show();   
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Assign_Room Aroom = new Assign_Room();
            Aroom.MdiParent = this;
            Aroom.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Visitor_Entry visitor = new Visitor_Entry();
            visitor.MdiParent = this;
            visitor.Show();
        }
    }
}
