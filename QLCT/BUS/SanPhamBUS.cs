using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAO dao;

        public SanPhamBUS()
        {
            dao = new SanPhamDAO();
        }
        public List<SanPham> LayDanhSachSanPham() => dao.LayDanhSachSanPham();

        public bool KiemTraMaSanPham(string maSP) => dao.KiemTraMaSanPham(maSP);

        public void ThemSanPham(string masp, string tensp)
        {
            SanPhamDTO sanPhamDTO = new SanPhamDTO
            {
                MaSanPham = masp,
                TenSanPham = tensp
            };
            dao.ThemSanPham(sanPhamDTO);
        } 
        
        public void SuaSanPham(SanPham sanPham) => dao.SuaSanPham(sanPham);

        public List<SanPham> TimSP(string tensp, string masp) => dao.TimSP(tensp,masp);

    }
}
