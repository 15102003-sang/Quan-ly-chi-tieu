using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DuDinhDAO
    {
        private DataQLCTDataContext _DataContext;
        
        public DuDinhDAO()
        {
            _DataContext = new DataQLCTDataContext();
        }
        //lấy các dự định của người dùng có mã truyền vào
        public List<DuDinhDTO> LayDuDinhDAO(string maNguoiDung)
        {
            return _DataContext.DuDinhs.Where(p => p.MaNguoiDung == maNguoiDung)
                                        .Select(p => new DuDinhDTO
                                        {
                                            MaDuDinh = p.MaDuDinh,
                                            MaNguoiDung = p.MaNguoiDung,
                                            TenDuDinh = p.TenDuDinh,
                                            ThoiGianDuDinh = (DateTime)p.ThoiGianDuDinh,
                                            TienDuDinh = (int)p.TienDuDinh,
                                        })
                                        .ToList();
        }

        //kiểm tra mã dự định 
        public bool KiemTraMaDuDinh(string maDuDinh)
            => _DataContext.DuDinhs.SingleOrDefault(p => p.MaDuDinh == maDuDinh) == null;

        //thêm dự định mới
        public void ThemDuDinh(DuDinh duDinh)
        {
            _DataContext.DuDinhs.InsertOnSubmit(duDinh);
            _DataContext.SubmitChanges();
        }
        //lấy tổng tiền theo mã dự định
        public int LayTienDuDinh(string maDuDinh)
        {
            return (int)_DataContext.DuDinhs.SingleOrDefault(p => p.MaDuDinh.Equals(maDuDinh)).TienDuDinh;
        }

        //sửa dự định theo mã dự định
        public void SuaDuDinh(DuDinhDTO duDinhDTO)
        {
            DuDinh duDinh = _DataContext.DuDinhs.Single(p => p.MaDuDinh == duDinhDTO.MaDuDinh);
            duDinh.TenDuDinh = duDinhDTO.TenDuDinh;
            duDinh.ThoiGianDuDinh = duDinhDTO.ThoiGianDuDinh;
            duDinh.TienDuDinh = duDinhDTO.TienDuDinh;
            _DataContext.SubmitChanges();
        }

        //xoá dự định theo mã dự định
        public void XoaDuDinhTheoMaDD(string maDuDinh)
        {
            _DataContext.DuDinhs.DeleteOnSubmit(_DataContext.DuDinhs.Single(p => p.MaDuDinh == maDuDinh));
            _DataContext.SubmitChanges();
        }
        //xoá dự định theo mã người dùng
        public void XoaDuDinhTheoMaND(string maNguoiDung)
        {
            List<DuDinh> duDinh = _DataContext.DuDinhs.Where(p => p.MaNguoiDung == maNguoiDung).ToList();
            foreach(DuDinh dd in  duDinh)
            {
                _DataContext.DuDinhs.DeleteOnSubmit(dd);
            }
            _DataContext.SubmitChanges();
        }

        //Tìm dự định
        public List<DuDinhDTO> TimDD(string maDuDinh, string tenDuDinh, int tienDD, DateTime time)
        {
            return _DataContext.DuDinhs.Where(p => p.MaDuDinh.Contains(maDuDinh)
                    && p.TenDuDinh.Contains(tenDuDinh)
                    && (p.TienDuDinh == tienDD || tienDD == 0)
                    && (p.ThoiGianDuDinh == time || time == new DateTime(1, 1, 1)))
                    .Select(p => new DuDinhDTO
                    {
                        MaDuDinh = p.MaDuDinh,
                        MaNguoiDung = p.MaNguoiDung,
                        TenDuDinh = p.TenDuDinh,
                        ThoiGianDuDinh = (DateTime)p.ThoiGianDuDinh,
                        TienDuDinh = (int)p.TienDuDinh
                    })
                    .ToList();
        }
    }
}
