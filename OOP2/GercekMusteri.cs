using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri: Musteri     //Bu olaya miras-inheritance denir.
    {
        public string TcNo { get; set; }    //string dememizin sebebi burada kullanacağımız sayıyı herhangi bir matematiksel işlemde kullanmayacağımız için.
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
    }
}
