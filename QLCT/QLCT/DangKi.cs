using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLCT
{
    public partial class FormDangKi : Form
    {
        private NguoiDungBUS nguoiDungBUS;
        public FormDangKi()
        {
            InitializeComponent();
            nguoiDungBUS = new NguoiDungBUS();
        }

        //Khi mà click nút Quay lại
        private void buttonQuayLai_Click(object sender, EventArgs e) => this.Close();


        //khi mà click nút Đăng kí
        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            if(textBoxNhapLaiMatKhau.Text != textBoxMatKhau.Text)   //kiểm tra mật khẩu trước
                MessageBox.Show("Nhập lại mật khẩu không khớp");
            else 
                if (nguoiDungBUS.KiemTraMaNguoiDung(textBoxMaNguoiDung.Text))   //kiểm tra thử có tồn tại Mã người dùng chưa
                    if (nguoiDungBUS.KiemTraTenDangNhap(textBoxTenDangNhap.Text))   //kiểm tra thử có tồn tại Tên đăng nhập chưa
                        if (Int32.TryParse(textBoxTuoi.Text, out int tuoi))
                        {
                            NguoiDungDTO dto = new NguoiDungDTO();

                            dto.MaNguoiDung = textBoxMaNguoiDung.Text;
                            dto.TenDangNhap = textBoxTenDangNhap.Text;
                            dto.MatKhau = textBoxMatKhau.Text;
                            dto.HoTen = textBoxHoVaTen.Text;
                            dto.Tuoi = tuoi;

                            nguoiDungBUS.ThemNguoiDung(dto);
                            MessageBox.Show("Đăng kí thành công. Giờ hãy đăng nhập");
                            this.Close();
                        }
                        else MessageBox.Show("Nhập tuổi không hợp lệ");
                    else MessageBox.Show("Tên đăng nhập đã tồn tại");
                else MessageBox.Show("Mã người dùng đã tồn tại");
        }

        private void FormDangKi_Load(object sender, EventArgs e)
        {

        }
    }
}
