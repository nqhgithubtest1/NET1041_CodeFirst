namespace Bai4_1.Models
{
    public class Chuong
    {
        public int ID { get; set; }
        public string TenChuong { get; set; }
        public List<DongVat> DongVats { get; set; }
    }
}
