using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata;
using QuanLyDuAnCongTrinhXayDung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using System.IO;

namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    public partial class frmKhachHang : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;

        public frmKhachHang()
        {
            InitializeComponent();
            dgvKhachHang.RowHeadersVisible = false;
        }
        private void BatTatChucNang(bool b)
        {
            btnThem.Enabled = !b;
            btnSua.Enabled = !b;
            btnXoa.Enabled = !b;
            btnLuu.Enabled = b;
            btnHuyBo.Enabled = b;
            dgvKhachHang.Enabled = b;
            txtTenCongTy.Enabled = b;
            txtDiaChi.Enabled = b;
            txtDienThoai.Enabled = b;
            btnTimKiem.Enabled = !b;
            btnThoat.Enabled = !b;
            btnNhap.Enabled = !b;
            btnXuat.Enabled = !b;
            txtDiaChi.Enabled = b;
            txtMaSoThue.Enabled = b;
            txtNguoiDaiDien.Enabled = b;


        }
        private void ClearText()
        {
            txtTenCongTy.DataBindings.Clear();
            txtNguoiDaiDien.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtMaSoThue.DataBindings.Clear();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvKhachHang.AutoGenerateColumns = false;

            //Hien thi du lieu
            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;
            // Gán BindingSource cho DataGridView
            ClearText();
            txtTenCongTy.DataBindings.Add("Text", bindingSource, "TenCongTy", false, DataSourceUpdateMode.Never);
            txtNguoiDaiDien.DataBindings.Add("Text", bindingSource, "NguoiDaiDien", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);
            txtMaSoThue.DataBindings.Add("Text", bindingSource, "MaSoThue", false, DataSourceUpdateMode.Never);
            dgvKhachHang.DataSource = bindingSource;
            dgvKhachHang.DataSource = context.KhachHang.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenCongTy.Focus();
            ClearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenCongTy.Text) || string.IsNullOrEmpty(txtMaSoThue.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (xulyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.TenCongTy = txtTenCongTy.Text;
                    kh.MaSoThue = txtMaSoThue.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.SoDienThoai = txtDienThoai.Text;
                    kh.NguoiDaiDien = txtNguoiDaiDien.Text;
                    context.KhachHang.Add(kh);
                    context.SaveChanges();
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.TenCongTy = txtTenCongTy.Text;
                        kh.MaSoThue = txtMaSoThue.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        kh.SoDienThoai = txtDienThoai.Text;
                        kh.NguoiDaiDien = txtNguoiDaiDien.Text;
                        context.KhachHang.Update(kh);
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                frmKhachHang_Load(sender, e);
                BatTatChucNang(false);
                ClearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value);
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmKhachHang_Load(sender, e);
                    ClearText();
                }

            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                frmKhachHang_Load(sender, e);
            }
            if (int.TryParse(tukhoa, out int idCanTim))

            {
                var kh = context.KhachHang.Find(idCanTim);
                if (kh != null)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = new List<KhachHang> { kh };
                    dgvKhachHang.DataSource = bs;
                }
            }
            else { MessageBox.Show("Vui lòng nhập ID Khách Hàng cần tìm"); }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.FileName = "DanhSachKhachHang.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    var ws = p.Workbook.Worksheets.Add("KhachHang");

                    // 1. Xuất tiêu đề cột
                    for (int i = 1; i <= dgvKhachHang.Columns.Count; i++)
                    {
                        ws.Cells[1, i].Value = dgvKhachHang.Columns[i - 1].HeaderText;
                    }

                    // 2. Xuất dữ liệu hàng
                    for (int i = 0; i < dgvKhachHang.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvKhachHang.Columns.Count; j++)
                        {
                            ws.Cells[i + 2, j + 1].Value = dgvKhachHang.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(sfd.FileName, bin);
                }
                MessageBox.Show("Xuất file Excel thành công!");
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage p = new ExcelPackage(new FileInfo(ofd.FileName)))
                {
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];
                    int rowCount = ws.Dimension.End.Row;

                    // Chạy từ dòng 2 (bỏ qua tiêu đề)
                    for (int row = 2; row <= rowCount; row++)
                    {
                        KhachHang kh = new KhachHang
                        {
                            TenCongTy = ws.Cells[row, 2].Value?.ToString(),
                            MaSoThue = ws.Cells[row, 3].Value?.ToString(),
                            DiaChi = ws.Cells[row, 4].Value?.ToString(),
                            SoDienThoai = ws.Cells[row, 5].Value?.ToString(),
                            NguoiDaiDien = ws.Cells[row, 6].Value?.ToString()
                        };
                    }
                    context.SaveChanges();
                    frmKhachHang_Load(sender, e); // Tải lại lưới dữ liệu
                    MessageBox.Show("Nhập dữ liệu từ Excel thành công!");
                }
            }
        }
    }
}
