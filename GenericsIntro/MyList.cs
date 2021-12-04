using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T ile çalışacağımız özel bir tipi belirtiriz. Type'tan gelir
    {
        T[] items; //metodun dışında ama class'ın içinde yazmamızın sebebi classa dahil tüm operasyonlarda kullanmamızı sağlar.
        //bu bloğa constructor denir. ctor ile oluştururuz. Class'ın adıyla aynıdır. Class'ı new lediğimiz anda  çalışır.
        public MyList() //ctor
        {
            items = new T[0];   //0 elemanlı yeni bir liste oluşturduk.
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //18. satırda yapılan new leme işleminde eski dizi kaybolmasın diye geçici bi dizide değerleri tutarız.
            items = new T[items.Length+1]; //items dizisinin eleman sayısını 1 arttırırız bu kod ile.
            for (int i = 0; i < tempArray.Length; i++)    //emanet olarak verdiğimiz değerleri geri ekleyeceğiz dizimizin son haline.
            {
                items[i] = tempArray[i]; //tempArray'e tanımladığımız değerleri sırasıyla items'a geri alıyoruz.
            }

            items[items.Length - 1] = item; //artık eklemek istediğimiz elemanı ekleyebiliriz.
        }
    }
}
