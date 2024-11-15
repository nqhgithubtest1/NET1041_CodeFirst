using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideOverload
{
    public class ConNguoi
    {
        public int ID { get; set; }
        public string Ten { get; set; }

        public virtual void LamViec()
        {
            Console.WriteLine("Con nguoi lam viec.");
        }

        public void LamViec(int soNam)
        {
            Console.WriteLine("Con nguoi lam viec " + soNam + " nam.");
        }
    }
}
