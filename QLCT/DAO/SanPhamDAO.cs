using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        private DataQLCTDataContext _db;
        public SanPhamDAO()
        {
            _db = new DataQLCTDataContext();
        }
        //lấy toàn bộ sản phẩm hiện có
        public List<SanPham> LayDanhSachSanPham()
        {
            return _db.SanPhams.ToList();
        }

        //kiểm tra mã sản phẩm 
        public bool KiemTraMaSanPham(string maSanPham) 
            => _db.SanPhams.SingleOrDefault(p => p.MaSanPham == maSanPham)==null;
        
        //thêm sản phẩm mới
        public void ThemSanPham(SanPhamDTO sanPhamDTO)
        {
            SanPham sanPham = new SanPham
            {
                MaSanPham = sanPhamDTO.MaSanPham,
                TenSanPham = sanPhamDTO.TenSanPham
            };
            _db.SanPhams.InsertOnSubmit(sanPham);
            _db.SubmitChanges();
        }

        //sửa sản phẩm
        public void SuaSanPham(SanPham sanPham)
        { 
            _db.SanPhams.Single(p => p.MaSanPham==sanPham.MaSanPham).TenSanPham = sanPham.TenSanPham;
        }

        //tìm sản phẩm
        public List<SanPham> TimSP(string tensp, string masp)
        {
            return _db.SanPhams.Where(p => p.TenSanPham.Contains(tensp) && p.MaSanPham.Contains(masp)).ToList();
        }
    }
}
