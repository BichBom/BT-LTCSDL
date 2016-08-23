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
    public partial class XoaKhachHang : Form
    {
        string cnStr;
        SqlConnection cn;

        public XoaKhachHang()
        {
            InitializeComponent();
        }

        private void XoaKhachHang_Load(object sender, EventArgs e)
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

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi chương trình không?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
           
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn thật sự muốn xóa nhân viên " + txtmaKH.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            cn.Open();
            string sql = @"DELETE NhanVien WHERE MaNV = '" + txtmaKH.Text + "'";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
               
            
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btluu_Click_1(object sender, EventArgs e)
        {
            
        }

    }
}
