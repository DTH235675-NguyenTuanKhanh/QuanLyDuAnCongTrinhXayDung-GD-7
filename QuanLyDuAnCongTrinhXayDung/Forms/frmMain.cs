using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAnCongTrinhXayDung.Data;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    public partial class frmMain : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        frmDuAn duAn = null;
        frmCongViec congViec = null;
        frmLoaiDuAn loaiDuAn = null;
        frmBangLuong bangLuong = null;
        frmNhatKyCongTrinh nhatKy = null;
        frmPhanCong phanCong = null;
        frmKhachHang khachHang = null;
        frmNhanVien nhanVien = null;
        frmNhaDauTu nhaDauTu = null;
        frmVatTu vatTu = null;
        frmPhanPhoi phanPhoi = null;
        frmDangNhap dangNhap = null;
        string hoVaTenNhanVien = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuDuAn_Click(object sender, EventArgs e)
        {
            if (duAn == null || duAn.IsDisposed)
            {
                duAn = new frmDuAn();
                duAn.MdiParent = this;
                duAn.Show();
            }
            else
                duAn.Activate();
        }

        private void mnuCongViec_Click(object sender, EventArgs e)
        {
            if (congViec == null || congViec.IsDisposed)
            {
                congViec = new frmCongViec();
                congViec.MdiParent = this;
                congViec.Show();
            }
            else
                congViec.Activate();
        }

        private void mnuLoaiDuAn_Click(object sender, EventArgs e)
        {
            if (loaiDuAn == null || loaiDuAn.IsDisposed)
            {
                loaiDuAn = new frmLoaiDuAn();
                loaiDuAn.MdiParent = this;
                loaiDuAn.Show();
            }
            else
                loaiDuAn.Activate();
        }

        private void mnuNhatKyCongTrinh_Click(object sender, EventArgs e)
        {
            if (nhatKy == null || nhatKy.IsDisposed)
            {
                nhatKy = new frmNhatKyCongTrinh();
                nhatKy.MdiParent = this;
                nhatKy.Show();
            }
            else
                nhatKy.Activate();
        }

        private void mnuPhanCong_Click(object sender, EventArgs e)
        {
            if (phanCong == null || phanCong.IsDisposed)
            {
                phanCong = new frmPhanCong();
                phanCong.MdiParent = this;
                phanCong.Show();
            }
            else
                phanCong.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnuNhaDauTu_Click(object sender, EventArgs e)
        {
            if (nhaDauTu == null || nhaDauTu.IsDisposed)
            {
                nhaDauTu = new frmNhaDauTu();
                nhaDauTu.MdiParent = this;
                nhaDauTu.Show();
            }
            else
                nhaDauTu.Activate();
        }

        private void mnuVatTu_Click(object sender, EventArgs e)
        {
            if (vatTu == null || vatTu.IsDisposed)
            {
                vatTu = new frmVatTu();
                vatTu.MdiParent = this;
                vatTu.Show();
            }
            else
                vatTu.Activate();
        }

        private void mnuPhanPhoi_Click(object sender, EventArgs e)
        {
            if (phanPhoi == null || phanPhoi.IsDisposed)
            {
                phanPhoi = new frmPhanPhoi();
                phanPhoi.MdiParent = this;
                phanPhoi.Show();
            }
            else
                phanPhoi.Activate();
        }

        private void mnuBangLuong_Click(object sender, EventArgs e)
        {
            if (bangLuong == null || bangLuong.IsDisposed)
            {
                bangLuong = new frmBangLuong();
                bangLuong.MdiParent = this;
                bangLuong.Show();
            }
            else
                bangLuong.Activate();
        }
        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, nhanVien.MatKhau))
                        {
                            hoVaTenNhanVien = nhanVien.HoVaTen;
                            if (nhanVien.QuyenHan == true)
                                QuyenQuanLy();
                            else if (nhanVien.QuyenHan == false)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }
        public void QuyenQuanLy()
        {
            mnuDuAn.Enabled = true;
            mnuCongViec.Enabled = true;
            mnuLoaiDuAn.Enabled = true;
            mnuNhatKyCongTrinh.Enabled = true;
            mnuPhanCong.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuNhaDauTu.Enabled = true;
            mnuVatTu.Enabled = true;
            mnuPhanPhoi.Enabled = true;
            mnuBangLuong.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }
        public void QuyenNhanVien()
        {
            mnuDuAn.Enabled = true;
            mnuCongViec.Enabled = true;
            mnuLoaiDuAn.Enabled = true;
            mnuNhatKyCongTrinh.Enabled = true;
            mnuPhanCong.Enabled = false;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = false;
            mnuNhaDauTu.Enabled = false;
            mnuVatTu.Enabled = false;
            mnuPhanPhoi.Enabled = false;
            mnuBangLuong.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;

        }
        public void ChuaDangNhap()
        {
            mnuDuAn.Enabled = false;
            mnuCongViec.Enabled = false;
            mnuLoaiDuAn.Enabled = false;
            mnuNhatKyCongTrinh.Enabled = false;
            mnuPhanCong.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuNhaDauTu.Enabled = false;
            mnuVatTu.Enabled = false;
            mnuPhanPhoi.Enabled = false;
            mnuBangLuong.Enabled = false;
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }
    }
}
