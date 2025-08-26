using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLCT
{
    public partial class QLCT : Form
    {
        private SanPhamBUS sanPhamBUS;
        private DuDinhBUS duDinhBUS;
        private GiaoDichDuDinhBUS giaoDichDuDinhBUS;
        private NguoiDungBUS nguoiDungBUS;

        private string userName;    //lưu useName từ form Đăng nhập để dùng ở mục Thông tin
        private string maNguoiDung;     //lưu lại mã người dùng để sử dụng ở mục Dự định

        public QLCT(string userName)    //truyền kèm theo cái userName từ form Đăng nhập
        {
            InitializeComponent();
            nguoiDungBUS = new NguoiDungBUS();
            sanPhamBUS = new SanPhamBUS();
            duDinhBUS = new DuDinhBUS();
            giaoDichDuDinhBUS = new GiaoDichDuDinhBUS();
            this.userName = userName;
        }
    //nút thoát
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    //ngay khi form load lên thì thực hiện ngay cái điều kiện đã chọn mục Thông tin
        private void QLCT_Load(object sender, EventArgs e)
        {
            tabControlMain_Selected(tabControlMain, new TabControlEventArgs(tabPageThongTin, 0, TabControlAction.Selected));
        }

    //khi mà chọn tabpage thì
        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            TabPage selectedTabPage = tabControlMain.SelectedTab;

    //nếu chọn mục thông tin
            if (selectedTabPage == tabPageThongTin)
            {
                maNguoiDung = textBoxMaNguoiDung.Text = nguoiDungBUS.LayThongTin(userName).MaNguoiDung;
                textBoxHoVaTen.Text = nguoiDungBUS.LayThongTin(userName).HoTen;
                textBoxTuoi.Text = nguoiDungBUS.LayThongTin(userName).Tuoi.ToString();
            }

    //nếu chọn mục sản phẩm
            if (selectedTabPage == tabPageSanPham)
            {
                List<SanPham> sanPhamDTOs = sanPhamBUS.LayDanhSachSanPham();
                dataGridViewSanPham.DataSource = sanPhamDTOs;
            }

    //nếu chọn mục Dự định
            if (selectedTabPage == tabPageDuDinh)
            {
                textBoxMaNguoiDungDD.Text = maNguoiDung;
                if (textBoxMaDuDinh.Text == "")
                {
                    textBoxThoiGianDuDinh.Text = "tháng/ngày/năm";
                }
                List<DuDinhDTO> duDinhDTOs = duDinhBUS.LayDuDinhBUS(maNguoiDung);
                dataGridViewDuDinh.DataSource = duDinhDTOs;
            }

    //nếu chọn mục Giao Dịch dự định
            if (selectedTabPage == tabPageGiaoDichDuDinh)
            {
                dataGridViewGiaoDichDuDinh.DataSource = layGiaoDichDuDinh();
            }
        }

    //tạo cái hàm layGiaoDichDuDinh(), tại vì cần dùng cái hàm này nhiều lần nên viết riêng ra :))
        private List<GiaoDichDuDinhDTO> layGiaoDichDuDinh()
        {
            List<DuDinhDTO> duDinhDTOs = duDinhBUS.LayDuDinhBUS(maNguoiDung);
            //tạo một cái list lưu những cái mã dự định của người dùng
            List<string> dsMaDuDinh = new List<string>();
            duDinhDTOs.ForEach(p => dsMaDuDinh.Add(p.MaDuDinh));
            //tạo thêm một cái list lớn để lưu các giao dịch
            List<GiaoDichDuDinhDTO> giaoDichDuDinhDTOs = new List<GiaoDichDuDinhDTO>();
            foreach (string ma in dsMaDuDinh)
            {
                //list này để lưu các giao dịch theo từng mã dự định
                List<GiaoDichDuDinhDTO> giaoDichDuDinhDTOs1 = giaoDichDuDinhBUS.LayGiaoDichDuDinhBUS(ma);
                giaoDichDuDinhDTOs.AddRange(giaoDichDuDinhDTOs1);
            }
            return giaoDichDuDinhDTOs;
        }

    
        //khi mà click nút Thêm mới
        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageThongTin)   //Thêm mới ở tab Thông tin
            {
                MessageBox.Show("Vui lòng đăng kí để tạo tài khoản mới");
            }

            if (tabControlMain.SelectedTab == tabPageSanPham) //Thêm mới ở tab Sản phẩm
            {
                if (textBoxMaSanPham.Text != "")
                {
                    if (sanPhamBUS.KiemTraMaSanPham(textBoxMaSanPham.Text))
                    {
                        sanPhamBUS.ThemSanPham(textBoxMaSanPham.Text, textBoxTenSanPham.Text);
                        MessageBox.Show("Đã thêm sản phẩm thành công");
                        dataGridViewSanPham.DataSource = sanPhamBUS.LayDanhSachSanPham();
                    }
                    else MessageBox.Show("Mã sản phẩm này đã tồn tại");
                }
                else MessageBox.Show("Vui lòng nhập mã sản phẩm");
            }

            if (tabControlMain.SelectedTab == tabPageDuDinh)     //Thêm mới ở tab Dự định
            {
                string maDuDinh = textBoxMaDuDinh.Text;
                string tenDuDinh = textBoxTenDuDinh.Text;
                string tgDuDinh = textBoxThoiGianDuDinh.Text;
                string tien = textBoxTienDuDinh.Text;
                string themdd = duDinhBUS.ThemDuDinh(maDuDinh, maNguoiDung, tenDuDinh, tgDuDinh, tien);
                MessageBox.Show(themdd);
                dataGridViewDuDinh.DataSource = duDinhBUS.LayDuDinhBUS(maNguoiDung);
            }
            if (tabControlMain.SelectedTab == tabPageGiaoDichDuDinh)     //thêm mới ở tab Giao dịch
            {
                string maGiaoDich = textBoxMaGiaoDichDuDinh.Text;
                string maSpGD = textBoxMaSanPhamGDDD.Text;
                string maDuDinhGD = textBoxMaDuDinhGDDD.Text;
                string gia = textBoxGia.Text;
                string soLuong = textBoxSoLuong.Text;

                string themgd = giaoDichDuDinhBUS.ThemGiaoDich(maGiaoDich, maSpGD, maDuDinhGD, gia, soLuong, maNguoiDung);
                MessageBox.Show(themgd);
                dataGridViewGiaoDichDuDinh.DataSource = layGiaoDichDuDinh();
            }
        }

    
    //khi chọn vào một ô bất kì trong dataview
    //Giao dịch
        private void dataGridViewGiaoDichDuDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewGiaoDichDuDinh.CurrentCell.RowIndex;    //Current: hiện tại -> CurrentCell: ô hiện tại
            textBoxMaGiaoDichDuDinh.Text = dataGridViewGiaoDichDuDinh.Rows[i].Cells[0].Value.ToString();
            textBoxMaDuDinhGDDD.Text = dataGridViewGiaoDichDuDinh.Rows[i].Cells[1].Value.ToString();
            textBoxMaSanPhamGDDD.Text = dataGridViewGiaoDichDuDinh.Rows[i].Cells[2].Value.ToString();
            textBoxSoLuong.Text = dataGridViewGiaoDichDuDinh.Rows[i].Cells[3].Value.ToString();
            textBoxGia.Text = dataGridViewGiaoDichDuDinh.Rows[i].Cells[4].Value.ToString();
        }
    //chọn vào một ô ở tab Dự định
        private void dataGridViewDuDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewDuDinh.CurrentCell.RowIndex;    //Current: hiện tại -> CurrentCell: ô hiện tại
            textBoxMaDuDinh.Text = dataGridViewDuDinh.Rows[i].Cells[0].Value.ToString();
            textBoxMaNguoiDungDD.Text = dataGridViewDuDinh.Rows[i].Cells[1].Value.ToString();
            textBoxTenDuDinh.Text = dataGridViewDuDinh.Rows[i].Cells[2].Value.ToString();
            textBoxTienDuDinh.Text = dataGridViewDuDinh.Rows[i].Cells[3].Value.ToString();
            textBoxThoiGianDuDinh.Text = dataGridViewDuDinh.Rows[i].Cells[4].Value.ToString();
            textBoxSoDu.Text = (int.Parse(dataGridViewDuDinh.Rows[i].Cells[3].Value.ToString())
                                - giaoDichDuDinhBUS.LayTongTien(dataGridViewDuDinh.Rows[i].Cells[0].Value.ToString())).ToString() ;
        }
    //chọn vào một ô ở tab Sản phẩm
        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewSanPham.CurrentCell.RowIndex;    //Current: hiện tại -> CurrentCell: ô hiện tại
            textBoxMaSanPham.Text = dataGridViewSanPham.Rows[i].Cells[0].Value.ToString();
            textBoxTenSanPham.Text = dataGridViewSanPham.Rows[i].Cells[1].Value.ToString();
        }

    //khi mà click thay đổi (sửa)
        private void buttonThayDoi_Click(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageGiaoDichDuDinh)
            {
                string maGiaoDich = textBoxMaGiaoDichDuDinh.Text;
                string maSpGD = textBoxMaSanPhamGDDD.Text;
                string maDuDinhGD = textBoxMaDuDinhGDDD.Text;
                string gia = textBoxGia.Text;
                string soLuong = textBoxSoLuong.Text;
                string suagd = giaoDichDuDinhBUS.SuaGiaoDich(maGiaoDich, maSpGD, maDuDinhGD, gia, soLuong, maNguoiDung);
                MessageBox.Show(suagd);
                dataGridViewGiaoDichDuDinh.DataSource = layGiaoDichDuDinh();
            }
                
    //sửa ở tab dự định
            if (tabControlMain.SelectedTab == tabPageDuDinh)
            {
                string maDuDinh = textBoxMaDuDinh.Text;
                string tenDuDinh = textBoxTenDuDinh.Text;
                string tgDuDinh = textBoxThoiGianDuDinh.Text;
                string tien = textBoxTienDuDinh.Text;
                string suadd = duDinhBUS.SuaDuDinh(maDuDinh, maNguoiDung, tenDuDinh, tgDuDinh, tien);
                MessageBox.Show(suadd);
                dataGridViewDuDinh.DataSource = duDinhBUS.LayDuDinhBUS(maNguoiDung);
            }

            //sửa ở tab sản phẩm
            if (tabControlMain.SelectedTab == tabPageSanPham)
            {
                if (!sanPhamBUS.KiemTraMaSanPham(textBoxMaSanPham.Text))
                {
                    SanPham sanPham = new SanPham
                    {
                        MaSanPham = textBoxMaSanPham.Text,
                        TenSanPham = textBoxTenSanPham.Text
                    };
                    sanPhamBUS.SuaSanPham(sanPham);
                    MessageBox.Show("Đã thay đổi sản phẩm thành công");
                    dataGridViewSanPham.DataSource = sanPhamBUS.LayDanhSachSanPham();
                }
                else MessageBox.Show("Không thể thay đổi mã sản phẩm");
            }
    //sửa ở tab thông tin
            if (tabControlMain.SelectedTab == tabPageThongTin)
            {
                if (int.TryParse(textBoxTuoi.Text, out int tuoi))
                {
                    nguoiDungBUS.SuaNguoiDung(new NguoiDung
                    {
                         MaNguoiDung = textBoxMaNguoiDung.Text,
                         HoTen = textBoxHoVaTen.Text,
                         Tuoi = int.Parse(textBoxTuoi.Text)
                    });
                    MessageBox.Show("Đã thay đổi thông tin thành công");
                }
                else MessageBox.Show("Nhập tuổi không hợp lệ");
            }
        }

    //khi mà click nút Xoá
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageGiaoDichDuDinh)
            {

                if (!giaoDichDuDinhBUS.KiemTraMaGiaoDich(textBoxMaGiaoDichDuDinh.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá giao dịch này?",
                        "Cảnh báo", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        giaoDichDuDinhBUS.XoaGiaoDichTheoMaGD(textBoxMaGiaoDichDuDinh.Text);
                        dataGridViewGiaoDichDuDinh.DataSource = layGiaoDichDuDinh();
                    }
                }
                else MessageBox.Show("Không tồn tại giao dịch này");
            }
            if (tabControlMain.SelectedTab == tabPageDuDinh)
            {

                if (!duDinhBUS.KiemTraMaDuDinh(textBoxMaDuDinh.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá dự định này?\n" +
                        "Tất cả các giao dịch của dự định sẽ bị xoá", "Cảnh báo", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        giaoDichDuDinhBUS.XoaGiaoDichTheoMaDD(textBoxMaDuDinh.Text);
                        duDinhBUS.XoaDuDinhTheoMaDD(textBoxMaDuDinh.Text);
                        dataGridViewDuDinh.DataSource = duDinhBUS.LayDuDinhBUS(maNguoiDung);
                    }
                }
                else MessageBox.Show("Không tồn tại dự định này");

            }
            if (tabControlMain.SelectedTab == tabPageSanPham)
            {
                MessageBox.Show("Không thể xoá sản phẩm");
            }
            if (tabControlMain.SelectedTab == tabPageThongTin)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn thật sự muốn xoá tài khoản?\n" +
                    "Tất cả dự định và giao dịch dự định cũng sẽ bị xoá", "Cảnh báo", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    List<DuDinhDTO> duDinhDTOs = duDinhBUS.LayDuDinhBUS(maNguoiDung);
                    List<string> dsMaDuDinh = new List<string>();
                    duDinhDTOs.ForEach(p => dsMaDuDinh.Add(p.MaDuDinh));
                    foreach (string ma in dsMaDuDinh)
                    {
                        giaoDichDuDinhBUS.XoaGiaoDichTheoMaDD(ma);
                    }

                    duDinhBUS.XoaDuDinhTheoMaND(textBoxMaNguoiDung.Text);

                    nguoiDungBUS.XoaNguoiDung(textBoxMaNguoiDung.Text);
                    this.Close();
                }
            }
        }
    //nút tìm kiếm
        private void buttonTim_Click(object sender, EventArgs e)
        {
            
            if (tabControlMain.SelectedTab == tabPageThongTin)
            {
                MessageBox.Show("Không khả thi");
            }
            if (tabControlMain.SelectedTab == tabPageSanPham)
            {
                dataGridViewSanPham.DataSource = sanPhamBUS.TimSP(textBoxTenSanPham.Text, textBoxMaSanPham.Text);
            }
            if (tabControlMain.SelectedTab == tabPageDuDinh)
            {
                int tien = 0;
                DateTime time = new DateTime(1, 1, 1);
                if (DateTime.TryParse(textBoxThoiGianDuDinh.Text, out DateTime time1)) time = time1;
                if (int.TryParse(textBoxTienDuDinh.Text, out int tien1)) tien = tien1;
                dataGridViewDuDinh.DataSource = duDinhBUS
                    .TimDD(textBoxMaDuDinh.Text,textBoxTenDuDinh.Text, tien, time)
                    .Intersect(duDinhBUS.LayDuDinhBUS(maNguoiDung)).ToList();
            }
            if (tabControlMain.SelectedTab == tabPageGiaoDichDuDinh)
            {
                int gia = 0;
                int soLuong = 0;
                if (int.TryParse(textBoxGia.Text, out int gia1)) gia = gia1;
                if (int.TryParse(textBoxSoLuong.Text, out int soLuong1)) soLuong = soLuong1;
                dataGridViewGiaoDichDuDinh.DataSource = giaoDichDuDinhBUS
                    .TimGD(textBoxMaGiaoDichDuDinh.Text, textBoxMaDuDinhGDDD.Text, textBoxMaSanPhamGDDD.Text, gia, soLuong)
                    .Intersect(layGiaoDichDuDinh()).ToList();
            }
        }
    //nút làm mới
        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            if(tabControlMain.SelectedTab == tabPageDuDinh)
            {
                textBoxMaDuDinh.Clear();
                textBoxTenDuDinh.Clear();
                textBoxTienDuDinh.Clear();
                textBoxThoiGianDuDinh.Text = "tháng/ngày/năm";
            }
            if(tabControlMain.SelectedTab == tabPageSanPham)
            {
                textBoxMaSanPham.Clear();
                textBoxTenSanPham.Clear();
            }
            if(tabControlMain.SelectedTab == tabPageGiaoDichDuDinh)
            {
                textBoxMaGiaoDichDuDinh.Clear();
                textBoxMaDuDinhGDDD.Clear();
                textBoxGia.Clear();
                textBoxSoLuong.Clear();
                textBoxMaSanPhamGDDD.Clear();
            }
        }

        private void textBoxThoiGianDuDinh_Click(object sender, EventArgs e)
        {
            if(textBoxThoiGianDuDinh.Text == "tháng/ngày/năm")
                textBoxThoiGianDuDinh.Clear();
        }
    }
}
