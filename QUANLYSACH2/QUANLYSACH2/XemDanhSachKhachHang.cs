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
    public partial class XemDanhSachKhachHang : Form
    {
        string cnStr;
        SqlConnection cn;

        public XemDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void XemDanhSachKhachHang_Load(object sender, EventArgs e)
        {

            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString; 
            cn = new SqlConnection(cnStr);
            dataGridView1.DataSource = GetProducts();

        }
        private void Connect()
        {
            if (cn != null && cn.State == ConnectionState.Closed)
            {
                try
                {
                    cn.Open();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Loi :" + ex.Message + "\n\n" + ex.Errors);
                }
                finally
                {
                    cn.Close();
                }
            }

        }

        private void Disconnect()
        {

            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();

        }
        private List<khachhang1> GetProducts()
        {
            cn.Open();
            string sql = "SELECT * FROM KhachHang";

            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            List<khachhang1> listKH = new List<khachhang1>();
            string maKH, tenKH, diachi, sodienthoai;
            while (dr.Read())
            {
                maKH = dr.GetString(0);
                tenKH = dr.GetString(1); 
                diachi = dr.GetString(2);
                sodienthoai = dr.GetString(3);
                khachhang1 kh = new khachhang1(maKH, tenKH, diachi, sodienthoai);
                listKH.Add(kh);
            }
            dr.Close();
          
            Disconnect();
            return listKH;

        }


        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi chương trình không?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }


    }
}
