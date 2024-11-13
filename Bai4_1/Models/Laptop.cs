using System.ComponentModel.DataAnnotations.Schema;

namespace Bai4_1.Models
{
    public class Laptop
    {
        public int LaptopID { get; set; }
        public string TenLaptop { get; set; }

        // 1-n
        [ForeignKey("SinhVien")]
        public int SinhVienID { get; set; }
        public SinhVien SinhVien { get; set; }
    }
}
