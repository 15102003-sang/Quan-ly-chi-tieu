using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class GiaoDichDuDinhBUS
    {
        private GiaoDichDuDinhDAO giaoDichDuDinhDAO;
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        DuDinhBUS duDinhBUS = new DuDinhBUS();
        public GiaoDichDuDinhBUS()
        {
            giaoDichDuDinhDAO = new GiaoDichDuDinhDAO();
        }
        //lấy danh sách tất cả giao dịch theo mã dự định
        public List<GiaoDichDuDinhDTO> LayGiaoDichDuDinhBUS(string maDuDinh)
            => giaoDichDuDinhDAO.LayDanhSachGiaoDichDuDinh(maDuDinh);

        public bool KiemTraMaGiaoDich(string maGiaoDich) => giaoDichDuDinhDAO.KiemTraMaGiaoDich(maGiaoDich);

        public string ThemGiaoDich(string magd, string masp, string madd, string gia, string soLuong, string mand)
        {
            if (KiemTraMaGiaoDich(magd))
                if (!sanPhamBUS.KiemTraMaSanPham(masp))
                    if (KiemTraMaDuDinhCuaBan(mand,madd))
                        if (int.TryParse(gia, out int gia1))
                            if (int.TryParse(soLuong, out int soLuong1))
                                if ((LayTongTien(madd) + gia1 * soLuong1) <= duDinhBUS.LayTienDuDinh(madd))
                                {
                                    giaoDichDuDinhDAO.ThemGiaoDich(new GiaoDichDuDinh
                                    {
                                        MaGiaoDichDuDinh = magd,
                                        MaSanPham = masp,
                                        MaDuDinh = madd,
                                        SoLuong = soLuong1,
                                        Gia = gia1,
                                    });
                                    return "Đã thêm giao dịch thành công";
                                }
                                else return "Vượt quá số lượng tiền dự định";
                            else return "Nhập số lượng không hợp lệ";
                        else return "Nhập Giá không hợp lệ";
                    else return "Bạn phải nhập mã dự định của bạn";
                else return "Mã sản phẩm chưa tồn tại";
            else return "Mã giao dịch đã tồn tại";
        }
        //tạo ra cái hàm này để kiểm tra mã giao dịch bên tabpage giao dịch dự định,
        //yêu cầu người dùng phải nhập mã dự định của chính mình
        public bool KiemTraMaDuDinhCuaBan(string maNguoiDung, string madd)
        {
            List<DuDinhDTO> duDinhDTOs = duDinhBUS.LayDuDinhBUS(maNguoiDung);
            List<string> dsMaDuDinh = new List<string>();
            duDinhDTOs.ForEach(p => dsMaDuDinh.Add(p.MaDuDinh));
            foreach (string ma in dsMaDuDinh)
            {
                if (madd == ma) return true;
            }
            return false;
        }
        public int LayTongTien(string maDuDinh) => giaoDichDuDinhDAO.LayTongTien(maDuDinh);

        public string SuaGiaoDich(string magd, string masp, string madd, string gia, string soLuong, string mand)
        {
            if (!KiemTraMaGiaoDich(magd))
                if (!sanPhamBUS.KiemTraMaSanPham(masp))
                    if (KiemTraMaDuDinhCuaBan(mand, madd))
                        if (int.TryParse(gia, out int gia1))
                            if (int.TryParse(soLuong, out int soLuong1))
                                if ((LayTongTien(madd) - LayTien(magd) + gia1 * soLuong1) <= duDinhBUS.LayTienDuDinh(madd))
                                {
                                    giaoDichDuDinhDAO.SuaGiaoDich(new GiaoDichDuDinh
                                    {
                                        MaGiaoDichDuDinh = magd,
                                        MaSanPham = masp,
                                        MaDuDinh = madd,
                                        SoLuong = soLuong1,
                                        Gia = gia1,
                                    });
                                    return "Đã thay đổi giao dịch thành công";
                                }
                                else return "Vượt quá số lượng tiền dự định";
                            else return "Nhập số lượng không hợp lệ";
                        else return "Nhập Giá không hợp lệ";
                    else return "Bạn phải nhập mã dự định của bạn";
                else return "Mã sản phẩm chưa tồn tại";
            else return "Không thể thay đổi Mã giao dịch dự định";
        }

        public int LayTien(string maGiaoDich) => giaoDichDuDinhDAO.LayTien(maGiaoDich);

        public void XoaGiaoDichTheoMaGD(string maGiaoDich) => giaoDichDuDinhDAO.XoaGiaoDichTheoMaGD(maGiaoDich);

        public void XoaGiaoDichTheoMaDD(string maDuDinh) => giaoDichDuDinhDAO.XoaGiaoDichTheoMaDD(maDuDinh);

        public List<GiaoDichDuDinhDTO> TimGD(string maGD, string maDD, string maSP, int gia, int soLuong)
            => giaoDichDuDinhDAO.TimGD(maGD,maDD,maSP,gia,soLuong);

    }
}
