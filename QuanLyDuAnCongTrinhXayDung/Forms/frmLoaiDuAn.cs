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
    public partial class frmLoaiDuAn : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmLoaiDuAn()
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
            txtTenLoaiDuAn.Enabled = b;
            dataGridView.Enabled = !b;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenLoaiDuAn.Clear();
        }

        private void frmLoaiDuAn_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<LoaiDuAn> lda = new List<LoaiDuAn>();
            lda = context.LoaiDuAn.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lda;
            txtTenLoaiDuAn.DataBindings.Clear();
            txtTenLoaiDuAn.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Loại dự án này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                LoaiDuAn lda = context.LoaiDuAn.Find(id);
                if (lda != null)
                {
                    context.LoaiDuAn.Remove(lda);
                    context.SaveChanges();
                    MessageBox.Show("Xóa Loại dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenLoaiDuAn.Clear();
                    frmLoaiDuAn_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiDuAn.Text))
                MessageBox.Show("Vui lòng nhập tên loại dự án?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulyThem)
                {
                    LoaiDuAn lda = new LoaiDuAn();
                    lda.TenLoai = txtTenLoaiDuAn.Text;
                    context.LoaiDuAn.Add(lda);
                    context.SaveChanges();
                }
                else
                {
                    LoaiDuAn lda = context.LoaiDuAn.Find(id);
                    if (lda != null)
                    {
                        lda.TenLoai = txtTenLoaiDuAn.Text;
                        context.LoaiDuAn.Update(lda);
                        context.SaveChanges();
                    }
                }
                frmLoaiDuAn_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiDuAn_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtTenLoaiDuAn.Enabled = true;
            string tukhoa = txtTenLoaiDuAn.Text.Trim();
            if (!string.IsNullOrEmpty(tukhoa))
            {
                frmLoaiDuAn_Load(sender, e);
            }
            if (int.TryParse(tukhoa, out int tenCanTim))

            {
                var lda = context.LoaiDuAn.Find(tenCanTim);
                if (lda != null)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = new List<LoaiDuAn> { lda };
                    dataGridView.DataSource = bs;
                }
            }
            else { MessageBox.Show("Vui lòng nhập Tên loại cần tìm"); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách loại dự án ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "LoaiDuAn_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Tên Loại Dự Án", typeof(string));

                    // Lấy dữ liệu từ bảng LoaiDuAn
                    var danhSach = context.LoaiDuAn.Select(l => new
                    {
                        l.ID,
                        l.TenLoai
                    }).ToList();

                    foreach (var l in danhSach)
                    {
                        table.Rows.Add(l.ID, l.TenLoai);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "LoaiDuAn");
                        sheet.Columns().AdjustToContents(); // Tự động căn chỉnh độ rộng cột
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất dữ liệu loại dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            openFileDialog.Title = "Chọn file Excel loại dự án";
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
                            string tenLoai = row.Cell(1).Value.ToString(); // Lấy tên ở cột đầu tiên

                            if (!string.IsNullOrWhiteSpace(tenLoai))
                            {
                                // Kiểm tra tránh trùng tên đã có trong DB
                                if (!context.LoaiDuAn.Any(x => x.TenLoai == tenLoai))
                                {
                                    LoaiDuAn lda = new LoaiDuAn { TenLoai = tenLoai };
                                    context.LoaiDuAn.Add(lda);
                                    count++;
                                }
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {count} loại dự án mới.", "Thành công");
                        frmLoaiDuAn_Load(sender, e); // Load lại DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
