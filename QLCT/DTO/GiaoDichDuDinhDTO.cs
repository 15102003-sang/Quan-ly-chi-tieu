using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoDichDuDinhDTO
    {
        public string MaGiaoDichDuDinh { get; set; }
        public string MaDuDinh { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }

        public override bool Equals(object obj)     //override: ghi đè
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            GiaoDichDuDinhDTO other = (GiaoDichDuDinhDTO)obj;

            return MaGiaoDichDuDinh == other.MaGiaoDichDuDinh &&
                   MaDuDinh == other.MaDuDinh &&
                   MaSanPham == other.MaSanPham &&
                   SoLuong == other.SoLuong &&
                   Gia == other.Gia;
        }
        //hàm này xác định giá trị băm của đối tượng
        public override int GetHashCode()
        {
            int hash = 30;
            hash = hash * 9 + MaGiaoDichDuDinh.GetHashCode();
            hash = hash * 9 + MaDuDinh.GetHashCode();
            hash = hash * 9 + MaSanPham.GetHashCode();
            hash = hash * 9 + SoLuong.GetHashCode();
            hash = hash * 9 + Gia.GetHashCode();
            return hash;
        }
    }
}
