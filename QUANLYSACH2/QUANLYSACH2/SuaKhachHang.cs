using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace QUANLYSACH2
{
    public partial class SuaKhachHang : Form
    {
        string cnStr;
        SqlConnection cn;
        public SuaKhachHang()
        {
            InitializeComponent();
        }

        private void SuaKhachHang_Load(object sender, EventArgs e)
        {

            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString; // mo add reference truoc khi nhap duoc configuration.manager
            cn = new SqlConnection(cnStr);
            dataGridView1.DataSource = GetcustomerTable();


        }
        private DataTable GetcustomerTable()
        {
            string sql = @"Select *from KhachHang";
            DataTable dt = new DataTable();
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            return dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi chương trình không?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }
    }
}
