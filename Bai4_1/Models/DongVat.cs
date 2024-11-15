namespace Bai4_1.Models
{
    public class DongVat
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public ChuNhan ChuNhan { get; set; }
        public Chuong? Chuong { get; set; }
        public List<ThucAn> ThucAns { get; set; }
    }
}
