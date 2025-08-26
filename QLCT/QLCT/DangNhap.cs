using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCT
{
    public partial class FormDangNhap : Form
    {
        private NguoiDungBUS nguoiDungBUS;
        public FormDangNhap()
        {
            InitializeComponent();
            nguoiDungBUS = new NguoiDungBUS(); //tạo một đối tượng NguoiDungBUS để sử dụng
        }

        //khi mà click vào nút Đăng nhập
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (nguoiDungBUS.KiemTraDangNhap(textBoxTenDangNhap.Text, textBoxMatKhau.Text))
            {
                Form formQLCT = new QLCT(textBoxTenDangNhap.Text);  //truyền thêm cái Tên đăng nhập để sử dụng cho form QLCT
                formQLCT.ShowDialog(); //chặn các form còn lại thay vì dùng show
            }
            else MessageBox.Show("không tồn tại tài khoản này");
        }

        //khi mà click vào nút Quay lại
        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            Form formGioiThieu = new GioiThieu();
            this.Hide();
            formGioiThieu.ShowDialog();
        }
    }
}
