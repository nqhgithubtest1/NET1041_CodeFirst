using System.ComponentModel.DataAnnotations.Schema;

namespace Bai4_1.Models
{
    public class DiaChi
    {
        public int DiaChiID { get; set; }
        public string ThanhPho { get; set; }
        public string QuanHuyen { get; set; }
        public string XaPhuong { get; set; }
        public string SoNha { get; set; }

        
        public int SinhVienID { get; set; }
        public SinhVien SinhVien { get; set; }
    }
}
