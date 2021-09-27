using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    {
        //Bir ürünü tanımlayan ifaleri burada tanımlarız. Bir ürünü ürün yapan elemanları tanımlarız.
        //public olarak başlayan satırların hepsi bi property'dir.
        //Id: Bir datayı diğer datalardan ayırtetmek için kullandığımız eşşiz değerdir. Örn: Tc kimlik no.
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

        // üstte yazan tüm satırlar birer Property'dir yani özelliktir.

    }
}
