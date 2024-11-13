namespace Bai4_1.Models
{
    public class LopHoc
    {
        public int LopHocID { get; set; }
        public string TenLopHoc { get; set; }

        // n-n
        // trong LopHoc dat 1 danh sach cac SinhVien
        public List<SinhVien> SinhViens { get; set; }
    }
}
