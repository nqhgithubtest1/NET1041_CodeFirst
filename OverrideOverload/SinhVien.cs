using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideOverload
{
    public class SinhVien : ConNguoi
    {
        public int NamHoc { get; set; }
        public override void LamViec()
        {
            Console.WriteLine("Sinh vien di hoc.");
        }
    }
}
