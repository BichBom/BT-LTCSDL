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
    public partial class ThemKhachHang : Form
    {
        string cnStr;
        SqlConnection cn;

        public ThemKhachHang()
        {
            InitializeComponent();
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
        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi chương trình không?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            string sql = @"INSERT INTO KhachHang(MaKH, TenKH, DiaChi, SoDienThoai)VALUES (N'" + txtma.Text + "', N'" + txtten.Text + "',N'" + txtdiachi.Text + "'," + txtsodienthoai.Text + ")";

            Connect();
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                int count = cmd.ExecuteNonQuery();
                MessageBox.Show("So dong da them : " + count.ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }

        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString; // mo add reference truoc khi nhap duoc configuration.manager
            cn = new SqlConnection(cnStr);

        }

        private void btthembangthutuc_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("uspThemKhachHang", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("maKH", txtma.Text));
                cmd.Parameters.Add(new SqlParameter("tenKH", txtten.Text));
                cmd.Parameters.Add(new SqlParameter("diachi", txtdiachi.Text));
                cmd.Parameters.Add(new SqlParameter("sodienthoai", txtsodienthoai.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("da them khach hang moi");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();

            }

        }
    }
}
