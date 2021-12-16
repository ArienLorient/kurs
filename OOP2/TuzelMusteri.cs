using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TuzelMusteri: Musteri      //Bu olaya miras-inheritance denir.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }     //string dememizin sebebi burada kullanacağımız sayıyı herhangi bir matematiksel işlemde kullanmayacağımız için.
    }
}
