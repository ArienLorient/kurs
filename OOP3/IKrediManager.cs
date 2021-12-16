using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Interface'leri genellikle operasyonel metotlarda kullanırız.
    //Interface'ler implemente ettiği classların referans numaralarını tutabilir.
    //Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    interface IKrediManager     //şablonumuz olarak görev görür.
    {
        void Hesapla();  //İmzanın aynı olduğu ama içerisinin farklı olduğu durumlarda base class'ı interface haline getiririz.
        void BiSeyYap();     

    }
}
