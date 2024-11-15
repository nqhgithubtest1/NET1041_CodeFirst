using System.ComponentModel.DataAnnotations.Schema;

namespace Bai4_1.Models
{
    public class Laptop
    {
        public int LaptopID { get; set; }
        public string TenLaptop { get; set; }

        // 1-n
        // De thiet lap quan he 1-n
        // lay PK cua thuc the ve 1 dat lam FK trong thuc the ve nhieu
        [ForeignKey("SinhVien")]
        public int SinhVienID { get; set; }
        public SinhVien SinhVien { get; set; }
    }
}
