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

    public partial class frmCongViec : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmCongViec()
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
            txtTenCongViec.Enabled = b;
            dataGridView.Enabled = !b;
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<CongViec> cv = new List<CongViec>();
            cv = context.CongViec.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = cv;
            txtTenCongViec.DataBindings.Clear();
            txtTenCongViec.DataBindings.Add("Text", bindingSource, "TenCongViec", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenCongViec.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa công việc này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                CongViec cv = context.CongViec.Find(id);
                if (cv != null)
                {
                    context.CongViec.Remove(cv);
                    context.SaveChanges();
                    MessageBox.Show("Xóa công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenCongViec.Clear();
                    frmCongViec_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenCongViec.Text))
                MessageBox.Show("Vui lòng nhập tên công việc?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulyThem)
                {
                    CongViec cv = new CongViec();
                    cv.TenCongViec = txtTenCongViec.Text;
                    context.CongViec.Add(cv);
                    context.SaveChanges();
                }
                else
                {
                    LoaiDuAn lda = context.LoaiDuAn.Find(id);
                    if (lda != null)
                    {
                        lda.TenLoai = txtTenCongViec.Text;
                        context.LoaiDuAn.Update(lda);
                        context.SaveChanges();
                    }
                }
                frmCongViec_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmCongViec_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file Excel công việc";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RowsUsed().Skip(1); // Bỏ qua dòng tiêu đề

                        int count = 0;
                        foreach (var row in rows)
                        {
                            string tenCV = row.Cell(1).Value.ToString(); // Giả sử cột 1 là tên công việc

                            if (!string.IsNullOrWhiteSpace(tenCV))
                            {
                                CongViec cv = new CongViec { TenCongViec = tenCV };
                                context.CongViec.Add(cv);
                                count++;
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {count} công việc.", "Thành công");
                        frmCongViec_Load(sender, e); // Load lại bảng của ný
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách công việc ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "DanhSachCongViec_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Tên Công Việc", typeof(string));

                    // Lấy dữ liệu từ bảng CongViec
                    var danhSach = context.CongViec.Select(c => new
                    {
                        c.ID,
                        c.TenCongViec
                    }).ToList();

                    foreach (var c in danhSach)
                    {
                        table.Rows.Add(c.ID, c.TenCongViec);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "CongViec");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất dữ liệu công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên công việc cần tìm:", "Tìm kiếm", "");

            if (!string.IsNullOrEmpty(input))
            {
                // Lấy danh sách từ CSDL
                var dsGoc = context.CongViec.ToList();

                // Lọc theo từ khóa
                var ketQua = dsGoc.Where(x => x.TenCongViec.ToLower().Contains(input.ToLower())).ToList();

                if (ketQua.Count > 0)
                {
                    dataGridView.DataSource = ketQua;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy công việc nào khớp với từ khóa!", "Thông báo");
                    dataGridView.DataSource = dsGoc;
                }
            }
            else
            {
                frmCongViec_Load(sender, e); // Hiển thị lại tất cả
            }
        }
    }
}
