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

namespace BTapNhom
{
    public partial class FrmClass : Form
    {
        ConnectDatabase kn = new ConnectDatabase();
        public FrmClass()
        {
            InitializeComponent();
        }
        private void HienThi_DuLieu()
        {
            string sql = "SELECT * FROM LOP";
            dataGridView1.DataSource = kn.GetData(sql);
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            HienThi_DuLieu();
        }
    }
}
