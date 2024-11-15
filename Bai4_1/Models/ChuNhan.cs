namespace Bai4_1.Models
{
    public class ChuNhan
    {
        public int ID { get; set; }
        public string Ten { get; set; }

        // 1-1
        public int DongVatID { get; set; }
        public DongVat DongVat { get; set; }
    }
}
