using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NguoiDungDAO
    {
        private DataQLCTDataContext _DataContext;

        public NguoiDungDAO() 
            => _DataContext = new DataQLCTDataContext();

        //kiểm tra đăng nhập
        public bool KiemTraDangNhap(string username, string pass)
        {
            return _DataContext.NguoiDungs.SingleOrDefault(p =>
            p.TenDangNhap==username && p.MatKhau==pass)!=null;
        }

        //lấy thông tin
        public NguoiDung LayThongTin(string username)
        {
            return _DataContext.NguoiDungs.Single(p=>p.TenDangNhap==username);
        }

        //thêm người dùng mới 
        public void ThemNguoiDung(NguoiDungDTO nguoiDungDTO)
        {
            NguoiDung nguoiDung = new NguoiDung();
            nguoiDung.MaNguoiDung = nguoiDungDTO.MaNguoiDung;
            nguoiDung.TenDangNhap = nguoiDungDTO.TenDangNhap;
            nguoiDung.MatKhau = nguoiDungDTO.MatKhau;
            nguoiDung.HoTen = nguoiDungDTO.HoTen;
            nguoiDung.Tuoi = nguoiDungDTO.Tuoi;
            _DataContext.NguoiDungs.InsertOnSubmit(nguoiDung);
            _DataContext.SubmitChanges();
        }

        //kiểm tra mã người dùng có tồn tại hay chưa
        public bool KiemTraMaNguoiDung(string maNguoiDung)
            => _DataContext.NguoiDungs
            .SingleOrDefault(p => p.MaNguoiDung == maNguoiDung) == null;

        //kiểm tra tên đăng nhập đã tồn tại hay chưa
        public bool KiemTraTenDangNhap(string username)
            => _DataContext.NguoiDungs
            .SingleOrDefault(p => p.TenDangNhap == username) == null;

        //sửa thông tin người dùng
        public void SuaNguoiDung(NguoiDung nguoiDung)
        {
            NguoiDung nd = _DataContext.NguoiDungs.Single(p => p.MaNguoiDung == nguoiDung.MaNguoiDung);
            nd.HoTen = nguoiDung.HoTen;
            nd.Tuoi = nguoiDung.Tuoi;
            //nd.TenDangNhap = nguoiDung.TenDangNhap;
            //nd.MatKhau = nguoiDung.MatKhau;
            _DataContext.SubmitChanges();
        }

        //Xoá người dùng
        public void XoaNguoiDung(string maNguoiDung)
        {
            _DataContext.NguoiDungs.DeleteOnSubmit(_DataContext.NguoiDungs.Single(p => p.MaNguoiDung == maNguoiDung));
            _DataContext.SubmitChanges();
        }
    }
}
