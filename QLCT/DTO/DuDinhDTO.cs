using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DuDinhDTO
    {
        public string MaDuDinh { get; set; }
        public string MaNguoiDung { get; set; }
        public string TenDuDinh { get; set; }
        public int TienDuDinh { get; set; }
        public DateTime ThoiGianDuDinh { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType()) return false;
            
            DuDinhDTO duDinhDTO = (DuDinhDTO)obj;
            return MaDuDinh == duDinhDTO.MaDuDinh
                   && TenDuDinh == duDinhDTO.TenDuDinh
                   && TienDuDinh == duDinhDTO.TienDuDinh
                   && ThoiGianDuDinh.Date == duDinhDTO.ThoiGianDuDinh.Date
                   && MaNguoiDung == duDinhDTO.MaNguoiDung;
        }

        public override int GetHashCode()
        {
            int hash = 30;
            hash = hash * 9 + MaDuDinh.GetHashCode();
            hash = hash * 9 + TenDuDinh.GetHashCode();
            hash = hash * 9 + MaNguoiDung.GetHashCode();
            hash = hash * 9 + TienDuDinh.GetHashCode();
            hash = hash * 9 + ThoiGianDuDinh.GetHashCode();
            return hash;
        }
    }

}
