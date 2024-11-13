using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai4_1.Models
{
    public class SinhVien
    {
        public int SinhVienID { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public bool TrangThai { get; set; }


        // 1-1
        [ForeignKey("SinhVienID")]
        public DiaChi DiaChi { get; set; }

        // n-1
        public List<Laptop> Laptops { get; set; }

        public List<LopHoc> LopHocs { get; set; }
    }
}
