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
    public partial class frmVatTu : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        string hinhAnhTam = "";
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Images");
        public frmVatTu()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenVatTu.Enabled = giaTri;
            txtDonViTinh.Enabled = giaTri;
            numDonGia.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnDoiAnh.Enabled = giaTri; // Chỉ cho đổi ảnh khi đang Thêm/Sửa
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            // Lấy danh sách vật tư từ DB
            var danhSach = context.VatTu.ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = danhSach;

            // Data Binding cho các controls
            txtTenVatTu.DataBindings.Clear();
            txtTenVatTu.DataBindings.Add("Text", bs, "TenVatTu", false, DataSourceUpdateMode.Never);

            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("Text", bs, "DonViTinh", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bs, "DonGia", false, DataSourceUpdateMode.Never);

            ptbHinhAnh.DataBindings.Clear();
            Binding bindingAnh = new Binding("ImageLocation", bs, "HinhAnh", true);
            bindingAnh.Format += (s, e) =>
            {
                if (e.Value != null) e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            ptbHinhAnh.DataBindings.Add(bindingAnh);

            dataGridView.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenVatTu.DataBindings.Clear();
            txtDonViTinh.DataBindings.Clear();
            numDonGia.DataBindings.Clear();
            ptbHinhAnh.DataBindings.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra đầu vào (Validation)
                if (string.IsNullOrWhiteSpace(txtTenVatTu.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên vật tư!");
                    return;
                }

                decimal gia = 0;
                decimal.TryParse(numDonGia.Text, out gia);

                // 2. Thực hiện Lưu
                if (xulyThem) // Chế độ Thêm mới
                {
                    VatTu vt = new VatTu
                    {
                        TenVatTu = txtTenVatTu.Text,
                        DonGia = gia,
                        DonViTinh = txtDonViTinh.Text,
                        // HinhAnh = mảng byte của ảnh (nếu có)
                    };
                    context.VatTu.Add(vt);
                    MessageBox.Show("Thêm vật tư mới thành công!");
                }
                else // Chế độ Sửa
                {
                    // 'id' là biến toàn cục lưu ID dòng đang chọn khi nhấn nút 'Sửa'
                    var vtEdit = context.VatTu.Find(id);
                    if (vtEdit != null)
                    {
                        vtEdit.TenVatTu = txtTenVatTu.Text;
                        vtEdit.DonGia = gia;
                        vtEdit.DonViTinh = txtDonViTinh.Text;
                        // vtEdit.HinhAnh = ...
                    }
                    MessageBox.Show("Cập nhật vật tư thành công!");
                }

                // 3. Lưu thay đổi vào Database và tải lại Grid
                context.SaveChanges();
                frmVatTu_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy ID từ dòng đang chọn trên DataGridView
                if (dataGridView.CurrentRow == null) return;
                int idXoa = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                // 2. Hỏi xác nhận
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // 3. Tìm và xóa
                    var vtDelete = context.VatTu.Find(idXoa);
                    if (vtDelete != null)
                    {
                        context.VatTu.Remove(vtDelete);
                        context.SaveChanges();

                        MessageBox.Show("Xóa thành công!");
                        frmVatTu_Load(sender, e); // Tải lại dữ liệu sau khi xóa
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmVatTu_Load(sender, e); // Tải lại dữ liệu để hủy bỏ mọi thay đổi
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           // Kiểm tra tên cột(phải khớp với Name bạn đặt trong Design là "HinhAnh")
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh" && e.RowIndex >= 0)
            {
                var vt = dataGridView.Rows[e.RowIndex].DataBoundItem as VatTu; // Đổi thành class đúng của bạn

                if (vt != null && !string.IsNullOrEmpty(vt.HinhAnh))
                {
                    string fullPath = Path.Combine(imagesFolder, vt.HinhAnh);
                    if (File.Exists(fullPath))
                    {
                        using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            // Quan trọng: Phải Clone hoặc tạo Bitmap mới vì FileStream sẽ bị đóng ngay sau đó
                            e.Value = new Bitmap(fs);
                        }
                    }
                    else
                    {
                        e.Value = null; // Hoặc 1 tấm ảnh mặc định "No Image"
                    }
                    e.FormattingApplied = true; // Báo cho hệ thống biết đã xử lý xong định dạng ô này
                }
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
                VatTu sp = context.VatTu.Find(id); sp.HinhAnh = fileName + ext;
                context.VatTu.Update(sp);
                context.SaveChanges();
                frmVatTu_Load(sender, e);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Workbook|*.xlsx" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RowsUsed().Skip(1); // Bỏ qua tiêu đề
                        int count = 0;

                        foreach (var row in rows)
                        {
                            string ten = row.Cell(1).Value.ToString();

                            // Kiểm tra tránh trùng lặp vật tư
                            if (!context.VatTu.Any(x => x.TenVatTu == ten))
                            {
                                VatTu vt = new VatTu
                                {
                                    TenVatTu = ten,
                                    DonViTinh = row.Cell(2).Value.ToString(),
                                    DonGia = decimal.Parse(row.Cell(3).Value.ToString()) // Cột 3 là Đơn giá
                                };
                                context.VatTu.Add(vt);
                                count++;
                            }
                        }
                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {count} vật tư mới!", "Thành công");
                        frmVatTu_Load(sender, e); // Load lại DataGridView
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi định dạng file hoặc dữ liệu: " + ex.Message); }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = "DanhSachVatTu_" + DateTime.Now.ToString("dd_MM_yyyy")
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã vật tư", typeof(int));
                    table.Columns.Add("Tên Vật Tư", typeof(string));
                    table.Columns.Add("Đơn Vị Tính", typeof(string));
                    table.Columns.Add("Đơn Giá", typeof(decimal));

                    // Lấy dữ liệu từ bảng VatTu
                    var ds = context.VatTu.Select(v => new { v.ID, v.TenVatTu, v.DonViTinh, v.DonGia }).ToList();
                    foreach (var v in ds) table.Rows.Add(v.ID, v.TenVatTu, v.DonViTinh, v.DonGia);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add(table, "Danh_Muc_Vat_Tu");

                        // Định dạng hiển thị tiền tệ cho cột Đơn Giá
                        ws.Column(4).Style.NumberFormat.Format = "#,##0";
                        ws.Columns().AdjustToContents();

                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất danh sách vật tư thành công!", "Thông báo");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên vật tư cần tìm:", "Tìm kiếm vật tư", "");

            if (!string.IsNullOrEmpty(input))
            {
                // Tìm kiếm gần đúng theo tên vật tư
                var ketQua = context.VatTu
                    .Where(v => v.TenVatTu.ToLower().Contains(input.ToLower()))
                    .ToList();

                if (ketQua.Count > 0)
                {
                    dataGridView.DataSource = ketQua;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vật tư nào khớp với từ khóa!", "Thông báo");
                    frmVatTu_Load(sender, e); // Quay lại danh sách gốc
                }
            }
            else
            {
                frmVatTu_Load(sender, e);
            }
        }
        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Lệnh này sẽ "khóa mõm" cái bảng lỗi Format ný đang gặp
            e.ThrowException = false;
        }
    }
}
