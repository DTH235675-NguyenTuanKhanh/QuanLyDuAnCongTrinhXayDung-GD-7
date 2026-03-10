using ClosedXML.Excel;
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
    public partial class frmNhaDauTu : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmNhaDauTu()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool b)
        {
            btnThem.Enabled = !b;
            btnSua.Enabled = !b;
            btnXoa.Enabled = !b;
            btnLuu.Enabled = b;
            btnHuyBo.Enabled = b;
            btnTimKiem.Enabled = !b;
            btnThoat.Enabled = !b;
            btnNhap.Enabled = !b;
            btnXuat.Enabled = !b;
            txtTenNhaDauTu.Enabled = b;
            txtDiaChi.Enabled = b;
            txtSoDienThoai.Enabled = b;
            txtMaSoThue.Enabled = b;
            dataGridView.Enabled = !b;
        }
        private void ClearText()
        {
            txtTenNhaDauTu.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Clear();
            txtMaSoThue.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            ClearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa NĐT này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                NhaDauTu ndt = context.NhaDauTu.Find(id);
                if (ndt != null)
                {
                    context.NhaDauTu.Remove(ndt);
                    context.SaveChanges();
                    MessageBox.Show("Xóa Loại dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                    frmNhaDauTu_Load(sender, e);
                }
            }
        }

        private void frmNhaDauTu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            ClearText();
            List<NhaDauTu> ndt = new List<NhaDauTu>();
            ndt = context.NhaDauTu.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ndt;
            txtTenNhaDauTu.DataBindings.Add("Text", bindingSource, "TenNhaDauTu", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtSoDienThoai.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);
            txtMaSoThue.DataBindings.Add("Text", bindingSource, "MaSoThue", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaDauTu.Text))
                MessageBox.Show("Vui lòng nhập nhà đàu tư?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulyThem)
                {
                    NhaDauTu ndt = new NhaDauTu();
                    ndt.TenNhaDauTu = txtTenNhaDauTu.Text;
                    context.NhaDauTu.Add(ndt);
                    context.SaveChanges();
                }
                else
                {
                    NhaDauTu ndt = context.NhaDauTu.Find(id);
                    if (ndt != null)
                    {
                        ndt.TenNhaDauTu = txtTenNhaDauTu.Text;
                        context.NhaDauTu.Update(ndt);
                        context.SaveChanges();
                    }
                }
                frmNhaDauTu_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhaDauTu_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách nhà đầu tư ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "DanhSachNhaDauTu_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Tên Nhà Đầu Tư", typeof(string));
                    table.Columns.Add("Mã Số Thuế", typeof(string));
                    table.Columns.Add("Địa Chỉ", typeof(string));
                    table.Columns.Add("Số Điện Thoại", typeof(string));

                    // Lấy dữ liệu từ bảng NhaDauTu
                    var danhSach = context.NhaDauTu.Select(n => new
                    {
                        n.ID,
                        n.TenNhaDauTu,
                        n.MaSoThue,
                        n.DiaChi,
                        n.SoDienThoai
                    }).ToList();

                    foreach (var n in danhSach)
                    {
                        table.Rows.Add(n.ID, n.TenNhaDauTu, n.MaSoThue, n.DiaChi, n.SoDienThoai);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhaDauTu");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất dữ liệu nhà đầu tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file Excel nhà đầu tư";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RowsUsed().Skip(1); // Bỏ qua tiêu đề

                        int count = 0;
                        foreach (var row in rows)
                        {
                            NhaDauTu ndt = new NhaDauTu();
                            // Thứ tự cột Excel: Tên NĐT(1), MST(2), Địa chỉ(3), SĐT(4)
                            ndt.TenNhaDauTu = row.Cell(1).Value.ToString();
                            ndt.MaSoThue = row.Cell(2).Value.ToString();
                            ndt.DiaChi = row.Cell(3).Value.ToString();
                            ndt.SoDienThoai = row.Cell(4).Value.ToString();

                            context.NhaDauTu.Add(ndt);
                            count++;
                        }

                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {count} nhà đầu tư.", "Thành công");
                        frmNhaDauTu_Load(sender, e); // Load lại DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên nhà đầu tư hoặc mã số thuế cần tìm:", "Tìm kiếm", "");

            if (!string.IsNullOrEmpty(input))
            {
                var dsGoc = context.NhaDauTu.ToList();

                // Lọc gần đúng theo Tên hoặc MST
                var ketQua = dsGoc.Where(x => x.TenNhaDauTu.ToLower().Contains(input.ToLower())
                                           || (x.MaSoThue != null && x.MaSoThue.Contains(input))).ToList();

                if (ketQua.Count > 0)
                {
                    dataGridView.DataSource = ketQua;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà đầu tư nào khớp với từ khóa!", "Thông báo");
                    dataGridView.DataSource = dsGoc;
                }
            }
            else
            {
                frmNhaDauTu_Load(sender, e);
            }
        }
    }
}
