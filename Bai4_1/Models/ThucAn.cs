namespace Bai4_1.Models
{
    public class ThucAn
    {
        public int ID { get; set; }
        public string TenThucAn { get; set; }
        public List<DongVat> DongVats { get; set; }
    }
}
