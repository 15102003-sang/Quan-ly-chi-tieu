using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DuDinhBUS
    {
        private DuDinhDAO dao;

        public DuDinhBUS() 
        {
            dao = new DuDinhDAO();
        }
        public List<DuDinhDTO> LayDuDinhBUS(string maNguoiDung)
        {
            return dao.LayDuDinhDAO(maNguoiDung);
        }

        public bool KiemTraMaDuDinh(string maDuDinh) => dao.KiemTraMaDuDinh(maDuDinh);

        public string ThemDuDinh(string madd, string mand, string tendd, string thoigian, string tien)
        {
            if (KiemTraMaDuDinh(madd))
                if (Int32.TryParse(tien, out int tien1))
                    if (DateTime.TryParse(thoigian, out DateTime thoigian1))
                    {
                        DuDinh duDinh = new DuDinh
                        {
                            MaDuDinh = madd,
                            MaNguoiDung = mand,
                            TenDuDinh = tendd,
                            ThoiGianDuDinh = thoigian1,
                            TienDuDinh = tien1
                        };
                        dao.ThemDuDinh(duDinh);
                        return "Đã thêm dự định thành công";
                    }
                    else return "Nhập thời gian không hợp lệ";
                else return "Nhập số tiền không hợp lệ";
            else return "Mã dự định này đã tồn tại";
        }

        public int LayTienDuDinh(string maDuDinh) => dao.LayTienDuDinh(maDuDinh);

        public string SuaDuDinh(string madd, string mand, string tendd, string thoigian, string tien)
        {
            if (KiemTraMaDuDinh(madd))
                if (Int32.TryParse(tien, out int tien1))
                    if (DateTime.TryParse(thoigian, out DateTime thoigian1))
                    {
                        DuDinhDTO duDinhDTO = new DuDinhDTO
                        {
                            MaDuDinh = madd,
                            MaNguoiDung = mand,
                            TenDuDinh = tendd,
                            ThoiGianDuDinh = thoigian1,
                            TienDuDinh = tien1
                        };
                        dao.SuaDuDinh(duDinhDTO);
                        return "Đã thay đổi dự định thành công";
                    }
                    else return "Nhập thời gian không hợp lệ";
                else return "Nhập số tiền không hợp lệ";
            else return "Không thể thay đổi mã dự định";
        }

        public void XoaDuDinhTheoMaDD(string maDuDinh) => dao.XoaDuDinhTheoMaDD(maDuDinh);

        public void XoaDuDinhTheoMaND(string maNguoiDung) => dao.XoaDuDinhTheoMaND(maNguoiDung);

        public List<DuDinhDTO> TimDD(string maDD, string tenDD, int tienDD, DateTime time)
            => dao.TimDD(maDD, tenDD, tienDD, time);
    }
}
