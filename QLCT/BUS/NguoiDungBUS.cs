using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NguoiDungBUS
    {
        private NguoiDungDAO dao;
        public NguoiDungBUS() => dao = new NguoiDungDAO();

        public bool KiemTraDangNhap(string username, string password)
        {
            return dao.KiemTraDangNhap(username, password);
        }

        public NguoiDung LayThongTin(string username)
        {
            return dao.LayThongTin(username);
        }

        public bool KiemTraMaNguoiDung(string maNguoiDung) 
            => dao.KiemTraMaNguoiDung(maNguoiDung);

        public bool KiemTraTenDangNhap(string usernam) 
            => dao.KiemTraTenDangNhap(usernam);

        public void ThemNguoiDung(NguoiDungDTO nguoiDungDTO)
            => dao.ThemNguoiDung(nguoiDungDTO);

        public void SuaNguoiDung(NguoiDung nguoiDung) => dao.SuaNguoiDung(nguoiDung);

        public void XoaNguoiDung(string maNguoiDung) => dao.XoaNguoiDung(maNguoiDung);
    }
}
