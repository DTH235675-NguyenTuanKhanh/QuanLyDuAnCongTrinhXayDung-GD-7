using Microsoft.EntityFrameworkCore;
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

namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    public partial class frmPhanPhoiChiTiet : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        BindingList<DanhSachPhanPhoiChiTiet> phanPhoiChiTiet = new BindingList<DanhSachPhanPhoiChiTiet>();
        public frmPhanPhoiChiTiet(int maPhanPhoi)
        {
            InitializeComponent();
            id = maPhanPhoi;
        }
        public void LayDuAnVaoComboBox()
        {
            cboDuAn.DataSource = context.DuAn.ToList();
            cboDuAn.ValueMember = "ID";
            cboDuAn.DisplayMember = "TenDuAn";
            cboDuAn.SelectedIndex = -1;
        }
        public void LayVatTuVaoComboBox()
        {
            cboVatTu.DataSource = context.VatTu.ToList();
            cboVatTu.ValueMember = "ID";
            cboVatTu.DisplayMember = "TenVatTu";
            cboVatTu.SelectedIndex = -1;
        }
        public void BatTatChucNang()
        {
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void TinhTongChiPhiHienThoi()
        {
            decimal tongDong = numSoLuong.Value * numDonGia.Value;
            txtTongChiPhi.Text = tongDong.ToString("#,##0");
        }

        private void frmPhanPhoiChiTiet_Load(object sender, EventArgs e)
        {
            LayVatTuVaoComboBox();
            LayDuAnVaoComboBox();
            dataGridView.AutoGenerateColumns = false;

            if (id != 0)
            {
                var phieu = context.PhanPhoi.FirstOrDefault(p => p.ID == id);
                if (phieu != null)
                {
                    txtGhiChu.Text = phieu.GhiChu;
                }
                // Sử dụng Include để nạp các bảng liên quan (VatTu và PhanPhoi -> DuAn)
                var query = context.PhanPhoiChiTiet
                    .Include(r => r.VatTu)
                    .Include(r => r.PhanPhoi)
                        .ThenInclude(p => p.DuAn)
                    .Where(r => r.PhanPhoiID == id)
                    .Select(r => new DanhSachPhanPhoiChiTiet
                    {
                        ID = r.ID,
                        PhanPhoiID = r.PhanPhoiID,
                        VatTuID = r.VatTuID,
                        TenVatTu = r.VatTu != null ? r.VatTu.TenVatTu : "Không xác định",
                        // Kiểm tra Null cho Dự án để tránh lỗi trắng bảng
                        DuAnID = r.PhanPhoi.DuAnID,
                        TenDuAn = (r.PhanPhoi != null && r.PhanPhoi.DuAn != null)
                                  ? r.PhanPhoi.DuAn.TenDuAn
                                  : "Chưa gán dự án",
                        SoLuong = r.SoLuong,
                        DonGia = r.VatTu.DonGia,
                        TongChiPhi = r.VatTu.DonGia * r.SoLuong
                    }).ToList();

                phanPhoiChiTiet = new BindingList<DanhSachPhanPhoiChiTiet>(query);
            }
            else
            {
                phanPhoiChiTiet = new BindingList<DanhSachPhanPhoiChiTiet>();
            }

            // Làm mới Grid
            dataGridView.DataSource = null;
            dataGridView.DataSource = phanPhoiChiTiet;

            BatTatChucNang();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra cả Vật tư và Dự án
            if (cboVatTu.SelectedValue == null || cboDuAn.SelectedValue == null || numSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn Dự án, Vật tư và nhập Số lượng!", "Thông báo");
                return;
            }

            int maVatTu = Convert.ToInt32(cboVatTu.SelectedValue);
            int maDuAn = Convert.ToInt32(cboDuAn.SelectedValue);

            // Tìm xem vật tư này đã tồn tại trong danh sách tạm chưa
            var chiTiet = phanPhoiChiTiet.FirstOrDefault(x => x.VatTuID == maVatTu);

            if (chiTiet != null)
            {
                // Cập nhật dòng đã tồn tại
                chiTiet.SoLuong = (int)numSoLuong.Value;
                chiTiet.DonGia = numDonGia.Value;
                chiTiet.TongChiPhi = numSoLuong.Value * numDonGia.Value;
                chiTiet.DuAnID = maDuAn;
                chiTiet.TenDuAn = cboDuAn.Text; // Cập nhật tên dự án nếu có thay đổi

                phanPhoiChiTiet.ResetBindings();
            }
            else
            {
                // Thêm dòng mới vào Grid
                phanPhoiChiTiet.Add(new DanhSachPhanPhoiChiTiet
                {
                    ID = 0,
                    PhanPhoiID = id,
                    VatTuID = maVatTu,
                    TenVatTu = cboVatTu.Text,
                    DuAnID = maDuAn,
                    TenDuAn = cboDuAn.Text,
                    SoLuong = (int)numSoLuong.Value,
                    DonGia = numDonGia.Value,
                    TongChiPhi = numSoLuong.Value * numDonGia.Value
                });
            }
            BatTatChucNang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && MessageBox.Show("Xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Lấy mã vật tư từ dòng đang chọn để xóa trong BindingList
                // Lưu ý: Đảm bảo DataPropertyName của cột ID Vật tư là "VatTuID"
                int maVT = Convert.ToInt32(dataGridView.CurrentRow.Cells["colVatTuID"].Value);
                var item = phanPhoiChiTiet.FirstOrDefault(x => x.VatTuID == maVT);

                if (item != null)
                {
                    phanPhoiChiTiet.Remove(item);
                }
                BatTatChucNang();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboDuAn.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Dự án trước khi lưu!", "Thông báo");
                return;
            }

            try
            {
                int maDuAnChon = Convert.ToInt32(cboDuAn.SelectedValue);

                if (id == 0) // Thêm phiếu mới
                {
                    PhanPhoi ppNew = new PhanPhoi
                    {
                        NgayLap = DateTime.Now,
                        DuAnID = maDuAnChon, // Gán ID dự án từ ComboBox vào đây
                        GhiChu = txtGhiChu.Text
                    };
                    context.PhanPhoi.Add(ppNew);
                    context.SaveChanges();
                    id = ppNew.ID;
                }
                else // Cập nhật phiếu cũ
                {
                    var ppUpdate = context.PhanPhoi.Find(id);
                    if (ppUpdate != null)
                    {
                        ppUpdate.DuAnID = maDuAnChon; // Cập nhật lại dự án nếu người dùng thay đổi
                        ppUpdate.GhiChu = txtGhiChu.Text;
                    }

                    // Xóa chi tiết cũ để lưu lại chi tiết mới
                    var oldDetails = context.PhanPhoiChiTiet.Where(r => r.PhanPhoiID == id).ToList();
                    context.PhanPhoiChiTiet.RemoveRange(oldDetails);
                }

                // Lưu danh sách chi tiết vật tư
                foreach (var item in phanPhoiChiTiet)
                {
                    context.PhanPhoiChiTiet.Add(new PhanPhoiChiTiet
                    {
                        PhanPhoiID = id,
                        VatTuID = item.VatTuID,
                        SoLuong = item.SoLuong,
                        DonGia = item.DonGia,
                        TongChiPhi = item.TongChiPhi
                    });
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {
                var message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi hệ thống: " + message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmPhanPhoiChiTiet_Load(sender, e); // Tải lại dữ liệu ban đầu từ CSDL
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVatTu.SelectedItem is VatTu vt)
            {
                // 2. Gán trực tiếp DonGia từ đối tượng vào NumericUpDown
                numDonGia.Value = vt.DonGia;

                // 3. Tính toán lại tổng chi phí
                TinhTongChiPhiHienThoi();
            }
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhTongChiPhiHienThoi();
        }
    }
}
