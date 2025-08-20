using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

namespace HotelManagementProject
{
    public partial class frmBillStatistics : Form
    {
        ThongKeDatPhongBLL tkdpbll;
        DatPhongBLL dpbll;
        TaiKhoanBLL tkbll;
        public frmBillStatistics()
        {
            InitializeComponent();
            tkdpbll = new ThongKeDatPhongBLL();
            dpbll = new DatPhongBLL();
            tkbll = new TaiKhoanBLL();
            cboLuaChon.SelectedIndex = 0;
            cboThang.SelectedIndex = 0;
            cboQuy.SelectedIndex = 0;
            cboNam.SelectedIndex = 0;
            LoadTableHoaDonDatPhong();
            LoadComboxboxNam();
        }
        public void LoadTableHoaDonDatPhong()
        {
            tblDatPhong.DataSource = tkdpbll.GetHoaDonList();
            tblDatPhong.Columns[0].HeaderText = "Mã Hóa Đơn";
            tblDatPhong.Columns[1].HeaderText = "Mã Nhân Viên";
            tblDatPhong.Columns[2].HeaderText = "Mã Khách Hàng";
            tblDatPhong.Columns[3].HeaderText = "Mã Phòng";
            tblDatPhong.Columns[4].HeaderText = "Check-In";
            tblDatPhong.Columns[5].HeaderText = "Check-Out";
            tblDatPhong.Columns[6].HeaderText = "Tiền Đặt Cọc";
            tblDatPhong.Columns[7].HeaderText = "Tiền Phòng";
            tblDatPhong.Columns[8].HeaderText = "Phụ Thu Check-In";
            tblDatPhong.Columns[9].HeaderText = "Phụ Thu Check-Out";
            tblDatPhong.Columns[10].HeaderText = "Tổng Tiền Dịch Vụ";
            tblDatPhong.Columns[11].HeaderText = "Tổng Tiền Thiết Bị";
            tblDatPhong.Columns[12].HeaderText = "Tổng Tiền Hóa Đơn";
            tblDatPhong.Columns[13].HeaderText = "Tiền Thanh Toán";
            tblDatPhong.Columns[14].HeaderText = "Số Người Ở";
            tblDatPhong.Columns[15].HeaderText = "Loại Thuê";
            tblDatPhong.Columns[16].HeaderText = "Trạng Thái";
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboThang.SelectedIndex)
            {
                case 0:
                    label6.Text = "Tổng số hóa đơn trong tháng?";
                    label7.Text = "Tổng doanh thu trong tháng?";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng?";
                    label9.Text = "0 đơn";
                    label8.Text = "0 đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 1:
                    label6.Text = "Tổng số hóa đơn trong tháng 1";
                    label7.Text = "Tổng doanh thu trong tháng 1";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 1";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 2:
                    label6.Text = "Tổng số hóa đơn trong tháng 2";
                    label7.Text = "Tổng doanh thu trong tháng 2";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 2";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 3:
                    label6.Text = "Tổng số hóa đơn trong tháng 3";
                    label7.Text = "Tổng doanh thu trong tháng 3";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 3";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 4:
                    label6.Text = "Tổng số hóa đơn trong tháng 4";
                    label7.Text = "Tổng doanh thu trong tháng 4";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 4";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 5:
                    label6.Text = "Tổng số hóa đơn trong tháng 5";
                    label7.Text = "Tổng doanh thu trong tháng 5";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 5";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 6:
                    label6.Text = "Tổng số hóa đơn trong tháng 6";
                    label7.Text = "Tổng doanh thu trong tháng 6";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 6";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 7:
                    label6.Text = "Tổng số hóa đơn trong tháng 7";
                    label7.Text = "Tổng doanh thu trong tháng 7";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 7";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 8:
                    label6.Text = "Tổng số hóa đơn trong tháng 8";
                    label7.Text = "Tổng doanh thu trong tháng 8";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 8";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 9:
                    label6.Text = "Tổng số hóa đơn trong tháng 9";
                    label7.Text = "Tổng doanh thu trong tháng 9";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 9";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 10:
                    label6.Text = "Tổng số hóa đơn trong tháng 10";
                    label7.Text = "Tổng doanh thu trong tháng 10";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 10";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 11:
                    label6.Text = "Tổng số hóa đơn trong tháng 11";
                    label7.Text = "Tổng doanh thu trong tháng 11";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 11";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 12:
                    label6.Text = "Tổng số hóa đơn trong tháng 12";
                    label7.Text = "Tổng doanh thu trong tháng 12";
                    label10.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong tháng 12";
                    label9.Text = tkdpbll.SoLuongHoaDonTheoThang(cboThang.SelectedIndex).ToString() + " đơn";
                    label8.Text = tkdpbll.TongTienTheoThang(cboThang.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoThang.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    tblSoPhongTheoThang.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoThang.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
            }
        }

        private void cboQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboQuy.SelectedIndex)
            {
                case 0:
                    label15.Text = "Tổng số hóa đơn trong quý?";
                    label14.Text = "Tổng doanh thu trong quý?";
                    label11.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong quý?";
                    label13.Text = "0 đơn";
                    label12.Text = "0 đ";
                    tblSoPhongTheoQuy.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboQuy.SelectedIndex);
                    tblSoPhongTheoQuy.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoQuy.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 1:
                    label15.Text = "Tổng số hóa đơn trong quý 1";
                    label14.Text = "Tổng doanh thu trong quý 1";
                    label11.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong quý 1";
                    label13.Text = tkdpbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tkdpbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoQuy.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoQuy(cboQuy.SelectedIndex);
                    tblSoPhongTheoQuy.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoQuy.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 2:
                    label15.Text = "Tổng số hóa đơn trong quý 2";
                    label14.Text = "Tổng doanh thu trong quý 2";
                    label11.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong quý 2";
                    label13.Text = tkdpbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tkdpbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoQuy.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoQuy(cboQuy.SelectedIndex);
                    tblSoPhongTheoQuy.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoQuy.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 3:
                    label15.Text = "Tổng số hóa đơn trong quý 3";
                    label14.Text = "Tổng doanh thu trong quý 3";
                    label11.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong quý 3";
                    label13.Text = tkdpbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tkdpbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoQuy.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoQuy(cboQuy.SelectedIndex);
                    tblSoPhongTheoQuy.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoQuy.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
                case 4:
                    label15.Text = "Tổng số hóa đơn trong quý 4";
                    label14.Text = "Tổng doanh thu trong quý 4";
                    label11.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong quý 4";
                    label13.Text = tkdpbll.SoLuongHoaDonTheoQuy(cboQuy.SelectedIndex).ToString() + " đơn";
                    label12.Text = tkdpbll.TongTienTheoQuy(cboQuy.SelectedIndex).ToString("N0") + " đ";
                    tblSoPhongTheoQuy.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoQuy(cboQuy.SelectedIndex);
                    tblSoPhongTheoQuy.Columns[0].HeaderText = "Mã Phòng";
                    tblSoPhongTheoQuy.Columns[1].HeaderText = "Số Lần Đặt";
                    break;
            }
        }

        public void LoadComboxboxNam()
        {
            int namhientai = DateTime.Now.Year;
            for (int year = namhientai; year >= 1900; year--)
                cboNam.Items.Add(year);
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNam.SelectedIndex == 0)
            {
                label20.Text = "Tổng số hóa đơn trong năm?";
                label19.Text = "Tổng doanh thu trong năm?";
                label16.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong năm?";
                label18.Text = "0 đơn";
                label17.Text = "0 đ";
                tblSoPhongTheoNam.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoNam(0);
                tblSoPhongTheoNam.Columns[0].HeaderText = "Mã Phòng";
                tblSoPhongTheoNam.Columns[1].HeaderText = "Số Lần Đặt";
            }
            else
            {
                label20.Text = "Tổng số hóa đơn trong năm " + cboNam.Text;
                label19.Text = "Tổng doanh thu trong năm " + cboNam.Text;
                label16.Text = "Danh sách số phòng đặt nhiều hơn 1 lần trong năm " + cboNam.Text;
                label18.Text = tkdpbll.SoLuongHoaDonTheoNam(int.Parse(cboNam.Text)).ToString() + " đơn";
                label17.Text = tkdpbll.TongTienTheoNam(int.Parse(cboNam.Text)).ToString("N0") + " đ";
                tblSoPhongTheoNam.DataSource = tkdpbll.LayPhongDuocDatNhieuHon1TheoNam(int.Parse(cboNam.Text));
                tblSoPhongTheoNam.Columns[0].HeaderText = "Mã Phòng";
                tblSoPhongTheoNam.Columns[1].HeaderText = "Số Lần Đặt";
            }
        }

        private void cboLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboLuaChon.SelectedIndex)
            {
                case 0:
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    break;
                case 1:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel1.Enabled = true;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    break;
                case 2:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel1.Enabled = false;
                    panel2.Enabled = true;
                    panel3.Enabled = false;
                    break;
                case 3:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = true;
                    break;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemDuLieuVaoFileWord(DateTime.Now.ToString("dd/MM/yyyy HH:MM:ss"),
                FrmMain.tennvfrmMain,
                cboThang.Text,
                label9.Text,
                label8.Text,
                cboLuaChon.Text);
            MoTepWordTuDuongDanTuongDoi();
        }
        private void MoTepWordTuDuongDanTuongDoi()
        {
            string duongDanUngDung = AppDomain.CurrentDomain.BaseDirectory;
            string duongDanTepWord = Path.Combine(duongDanUngDung, @"Bill\DocThongKeCNPM.docx");

            if (File.Exists(duongDanTepWord))
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(duongDanTepWord, ReadOnly: true);

            }
            else
                MessageBox.Show("Tệp Word không tồn tại.");
        }

        private void ThemDuLieuVaoFileWord(string ngaylaphd, string tennv, string thoigian, string tonghoadon,
            string doanhthu, string loaithongke)
        {
            string duongDanUngDung = AppDomain.CurrentDomain.BaseDirectory;
            string duongDanTepWord = Path.Combine(duongDanUngDung, @"Bill\DocThongKeCNPM.docx");
            if (File.Exists(duongDanTepWord))
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document doc = wordApp.Documents.Open(duongDanTepWord, ReadOnly: true);
                ThayDoiGiaTriTruong(doc, "NgayLapHoaDon", ngaylaphd);
                ThayDoiGiaTriTruong(doc, "TenNhanVien", tennv);


                var datPhongList = dpbll.GetListDatPhongDaThanhToan();
                if (datPhongList.Any())
                {
                    var dplist = dpbll.GetListDatPhongDaThanhToan();

                    Range endRange = doc.Range();
                    endRange.Find.Execute("Danh sách các hóa đơn đặt phòng: ", Forward: false);
                    Range endOfTenNhanVien = endRange.Duplicate;
                    endOfTenNhanVien.MoveEnd(WdUnits.wdParagraph, 1);
                    int endPosition = endOfTenNhanVien.End;

                    Table table = doc.Tables.Add(doc.Range(endPosition), 1, 6);
                    table.Borders.Enable = 1;
                    table.Cell(1, 1).Range.Text = "Mã Hóa Đơn";
                    table.Cell(1, 2).Range.Text = "Mã Nhân Viên";
                    table.Cell(1, 3).Range.Text = "Mã Khách Hàng";
                    table.Cell(1, 4).Range.Text = "Mã Phòng";
                    table.Cell(1, 5).Range.Text = "Tổng Tiền";
                    table.Cell(1, 6).Range.Text = "Trạng Thái";
                    table.Range.Font.Size = 10;

                    int rowIndex = 2;
                    foreach (var dp in dplist)
                    {
                        table.Rows.Add();
                        table.Cell(rowIndex, 1).Range.Text = dp.id_datphong;
                        table.Cell(rowIndex, 2).Range.Text = dp.id_nhanvien;
                        table.Cell(rowIndex, 3).Range.Text = dp.id_khachhang;
                        table.Cell(rowIndex, 4).Range.Text = dp.id_phong;
                        table.Cell(rowIndex, 5).Range.Text = double.Parse(dp.tong_tien_hoa_don.ToString()).ToString("N0") + "đ";
                        table.Cell(rowIndex, 6).Range.Text = dp.trang_thai;
                        rowIndex++;
                    }
                }

                doc.Paragraphs.Add();
                Paragraph text1 = doc.Paragraphs.Add();
                text1.Range.Text = "THỐNG KÊ HÓA ĐƠN " + thoigian.ToUpper() + "\n";
                text1.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                text1.Range.Font.Bold = 0;
                text1.Range.Font.Size = 13;
                Paragraph text2 = doc.Paragraphs.Add();
                text2.Range.Text = "Tổng hóa đơn có trong " + thoigian + " là: " + tonghoadon + "\n";
                text2.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                text2.Range.Font.Bold = 0;
                text2.Range.Font.Size = 13;
                Paragraph text3 = doc.Paragraphs.Add();
                text3.Range.Text = "Tổng doanh thu trong " + thoigian + " là: " + doanhthu + "\n";
                text3.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                text3.Range.Font.Bold = 0;
                text3.Range.Font.Size = 13;
                Paragraph text4 = doc.Paragraphs.Add();
                text4.Range.Text = "Danh sách các phòng được đặt nhiều hơn 1 lần là:\n";
                text4.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                text4.Range.Font.Bold = 0;
                text4.Range.Font.Size = 13;

                if (loaithongke.Equals("theo tháng"))
                {
                    var lstdp = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                    if (lstdp.Any())
                    {
                        var dplist = tkdpbll.LayPhongDuocDatNhieuHon1TheoThang(cboThang.SelectedIndex);
                        Range endRange = doc.Range();
                        endRange.Find.Execute("Danh sách các phòng được đặt nhiều hơn 1 lần là:", Forward: false);
                        Range endOfTenNhanVien = endRange.Duplicate;
                        endOfTenNhanVien.MoveEnd(WdUnits.wdParagraph, 1);
                        int endPosition = endOfTenNhanVien.End;

                        Table table = doc.Tables.Add(doc.Range(endPosition), 1, 2);
                        table.Borders.Enable = 1;
                        table.Cell(1, 1).Range.Text = "Mã Phòng";
                        table.Cell(1, 2).Range.Text = "Số Lần Được Đặt";
                        table.Range.Font.Size = 10;

                        int rowIndex = 2;
                        foreach (var dp in dplist)
                        {
                            table.Rows.Add();
                            table.Cell(rowIndex, 1).Range.Text = dp.RoomId;
                            table.Cell(rowIndex, 2).Range.Text = dp.TotalBookings.ToString();
                            rowIndex++;
                        }
                    }
                }
                if (loaithongke.Equals("theo quý"))
                {
                    var lstdp = tkdpbll.LayPhongDuocDatNhieuHon1TheoQuy(cboQuy.SelectedIndex);
                    if (lstdp.Any())
                    {
                        var dplist = tkdpbll.LayPhongDuocDatNhieuHon1TheoQuy(cboQuy.SelectedIndex);
                        Range endRange = doc.Range();
                        endRange.Find.Execute("Danh sách các phòng được đặt nhiều hơn 1 lần là:", Forward: false);
                        Range endOfTenNhanVien = endRange.Duplicate;
                        endOfTenNhanVien.MoveEnd(WdUnits.wdParagraph, 1);
                        int endPosition = endOfTenNhanVien.End;

                        Table table = doc.Tables.Add(doc.Range(endPosition), 1, 2);
                        table.Borders.Enable = 1;
                        table.Cell(1, 1).Range.Text = "Mã Phòng";
                        table.Cell(1, 2).Range.Text = "Số Lần Được Đặt";
                        table.Range.Font.Size = 10;

                        int rowIndex = 2;
                        foreach (var dp in dplist)
                        {
                            table.Rows.Add();
                            table.Cell(rowIndex, 1).Range.Text = dp.RoomId;
                            table.Cell(rowIndex, 2).Range.Text = dp.TotalBookings.ToString();
                            rowIndex++;
                        }
                    }
                }
                if (loaithongke.Equals("theo năm"))
                {
                    var lstdp = tkdpbll.LayPhongDuocDatNhieuHon1TheoNam(int.Parse(cboNam.Text));
                    if (lstdp.Any())
                    {
                        var dplist = tkdpbll.LayPhongDuocDatNhieuHon1TheoNam(int.Parse(cboNam.Text));
                        Range endRange = doc.Range();
                        endRange.Find.Execute("Danh sách các phòng được đặt nhiều hơn 1 lần là:", Forward: false);
                        Range endOfTenNhanVien = endRange.Duplicate;
                        endOfTenNhanVien.MoveEnd(WdUnits.wdParagraph, 1);
                        int endPosition = endOfTenNhanVien.End;

                        Table table = doc.Tables.Add(doc.Range(endPosition), 1, 2);
                        table.Borders.Enable = 1;
                        table.Cell(1, 1).Range.Text = "Mã Phòng";
                        table.Cell(1, 2).Range.Text = "Số Lần Được Đặt";
                        table.Range.Font.Size = 10;

                        int rowIndex = 2;
                        foreach (var dp in dplist)
                        {
                            table.Rows.Add();
                            table.Cell(rowIndex, 1).Range.Text = dp.RoomId;
                            table.Cell(rowIndex, 2).Range.Text = dp.TotalBookings.ToString();
                            rowIndex++;
                        }
                    }
                }


                wordApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Tệp Word không tồn tại.");
            }
        }

        private void ThayDoiGiaTriTruong(Microsoft.Office.Interop.Word.Document doc, string tenTruong, string giaTriMoi)
        {
            foreach (Microsoft.Office.Interop.Word.Field field in doc.Fields)
            {
                if (field.Code.Text.Contains(tenTruong))
                {
                    field.Select();
                    Microsoft.Office.Interop.Word.Selection selection = doc.Application.Selection;
                    selection.Range.InsertAfter(giaTriMoi);
                    selection.TypeBackspace();
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemDuLieuVaoFileWord(DateTime.Now.ToString("dd/MM/yyyy HH:MM:ss"),
                            FrmMain.tennvfrmMain,
                            cboQuy.Text,
                            label13.Text,
                            label12.Text,
                            cboLuaChon.Text);
            MoTepWordTuDuongDanTuongDoi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemDuLieuVaoFileWord(DateTime.Now.ToString("dd/MM/yyyy HH:MM:ss"),
                            FrmMain.tennvfrmMain,
                            cboNam.Text,
                            label18.Text,
                            label17.Text,
                            cboLuaChon.Text);
            MoTepWordTuDuongDanTuongDoi();
        }
    }
}
