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
        // Dat 1 thuoc tinh DiaChi vao class SinhVien
        [ForeignKey("SinhVienID")]
        public DiaChi DiaChi { get; set; }

        // n-1
        // Vi 1 SinhVien co nhieu Laptop 
        // nen trong SInhVien dat 1 danh sach cac Laptop
        public List<Laptop> Laptops { get; set; }

        // n-n
        // trong SInhVien dat 1 danh sach cac LopHoc
        public List<LopHoc> LopHocs { get; set; }
    }
}
