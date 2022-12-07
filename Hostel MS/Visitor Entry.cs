using Hostel_MS.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS
{
    public partial class Visitor_Entry : Form
    {
        SqlData sqlData = new SqlData();
        public Visitor_Entry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlData.Opencon();
            sqlData.NonQuerryExecuter("Insert Querry");
            sqlData.Closecon();
        }
    }
}
