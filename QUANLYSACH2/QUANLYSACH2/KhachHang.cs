using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYSACH2
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void XemDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            XemDanhSachKhachHang xds = new XemDanhSachKhachHang();
            xds.ShowDialog();
        }

        private void ThemKhachHang_Click(object sender, EventArgs e)
        {
            ThemKhachHang tkh = new ThemKhachHang();
            tkh.ShowDialog();
        }

        private void XoaKhachHang_Click(object sender, EventArgs e)
        {
            XoaKhachHang xkh = new XoaKhachHang();
            xkh.ShowDialog();
        }

        private void SuaKhachHang_Click(object sender, EventArgs e)
        {
            SuaKhachHang skh = new SuaKhachHang();
            skh.ShowDialog();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có thực sự muốn thoát khỏi chương trình không?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }
    }
}
