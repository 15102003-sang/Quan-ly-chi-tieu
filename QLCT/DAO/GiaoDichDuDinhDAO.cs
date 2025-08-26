using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaoDichDuDinhDAO
    {
        private DataQLCTDataContext _db;

        public GiaoDichDuDinhDAO()
        {
            _db = new DataQLCTDataContext();
        }
        //lấy list giao dịch
        public List<GiaoDichDuDinhDTO> LayDanhSachGiaoDichDuDinh(string maDuDinh)
        {
            return _db.GiaoDichDuDinhs.Where(p => p.MaDuDinh==maDuDinh).Select(p => new GiaoDichDuDinhDTO
            {
                MaGiaoDichDuDinh = p.MaGiaoDichDuDinh,
                MaDuDinh = p.MaDuDinh,
                MaSanPham = p.MaSanPham,
                SoLuong = (int)p.SoLuong,
                Gia = (int)p.Gia
            }).ToList();
        }
        //kiểm tra mã giao dịch có trùng không, trả về true nếu không trùng
        public bool KiemTraMaGiaoDich(string maGiaoDich) 
            => _db.GiaoDichDuDinhs.SingleOrDefault(p => p.MaGiaoDichDuDinh == maGiaoDich) == null;
        //thêm giao dịch mới
        public void ThemGiaoDich(GiaoDichDuDinh giaoDichDuDinh)
        {
            _db.GiaoDichDuDinhs.InsertOnSubmit(giaoDichDuDinh);
            _db.SubmitChanges();
        }

        //tính tổng tiền giao dịch theo mã dự định
        public int LayTongTien(string maDuDinh)
        {
            int? tongTien = _db.GiaoDichDuDinhs
                .Where(p => p.MaDuDinh == maDuDinh)
                .Sum(p => p.Gia*p.SoLuong);
            return tongTien.HasValue?tongTien.Value:0;  //hasvalues kiểm tra có giá trị hay không, trả về true or false
        }

        //sửa giao dịch (xoá cái cũ và thêm lại cái mới)
        //cách này thì nó hơi tốn thời gian, tài nguyên hơn, dễ bị mất liên kết với các table khác
        /*public void SuaGiaoDich(GiaoDichDuDinh giaoDichDuDinh)
        {
            GiaoDichDuDinh gd = _db.GiaoDichDuDinhs.Single(p => p.MaGiaoDichDuDinh == giaoDichDuDinh.MaGiaoDichDuDinh);
            _db.GiaoDichDuDinhs.DeleteOnSubmit(gd);
            _db.GiaoDichDuDinhs.InsertOnSubmit(giaoDichDuDinh);
            _db.SubmitChanges();
        }*/

        //sửa giao dịch (cập nhật trực tiếp luôn)
        public void SuaGiaoDich(GiaoDichDuDinh giaoDichDuDinh)
        {
            GiaoDichDuDinh gd = _db.GiaoDichDuDinhs.Single(p => p.MaGiaoDichDuDinh == giaoDichDuDinh.MaGiaoDichDuDinh);
            gd.MaDuDinh = giaoDichDuDinh.MaDuDinh;
            gd.MaSanPham = giaoDichDuDinh.MaSanPham;
            gd.SoLuong = giaoDichDuDinh.SoLuong;
            gd.Gia = giaoDichDuDinh.Gia;
            _db.SubmitChanges();
        }
        
        //lấy tiền theo mã giao dịch
        public int LayTien(string maGiaoDich)
        {
            GiaoDichDuDinh gd = _db.GiaoDichDuDinhs.Single(p => p.MaGiaoDichDuDinh == maGiaoDich);
            return (gd.Gia * gd.SoLuong).GetValueOrDefault(0);
        }
        
        //xoá giao dịch theo mã giao dịch
        public void XoaGiaoDichTheoMaGD(string maGiaoDich)
        {
            _db.GiaoDichDuDinhs.DeleteOnSubmit(_db.GiaoDichDuDinhs.Single(p => p.MaGiaoDichDuDinh == maGiaoDich));
            _db.SubmitChanges();
        }

        //xoá giao dịch theo mã dự định
        public void XoaGiaoDichTheoMaDD(string maDuDinh)
        {
            var giaoDichDuDinhsToDelete = _db.GiaoDichDuDinhs.Where(p => p.MaDuDinh == maDuDinh).ToList();

            _db.GiaoDichDuDinhs.DeleteAllOnSubmit(giaoDichDuDinhsToDelete);
            _db.SubmitChanges();
        }

        //tìm giao dịch theo mã giao dịch, mã dự định và mã sản phẩm
        public List<GiaoDichDuDinhDTO> TimGD(string maGiaoDich, string maDuDinh, string maSanPham, int gia, int soLuong)
        {
            return _db.GiaoDichDuDinhs.
                Where(p =>p.MaGiaoDichDuDinh.Contains(maGiaoDich) 
                && p.MaDuDinh.Contains(maDuDinh) 
                && p.MaSanPham.Contains(maSanPham) 
                && (p.Gia == gia || gia == 0)
                && (p.SoLuong == soLuong || soLuong == 0))
                .Select(p => new GiaoDichDuDinhDTO
                {
                    MaGiaoDichDuDinh = p.MaGiaoDichDuDinh,
                    MaDuDinh = p.MaDuDinh,
                    MaSanPham = p.MaSanPham,
                    SoLuong = (int)p.SoLuong,
                    Gia = (int)p.Gia
                })
                .ToList();
        }
    }
}
