using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            //topla işlemini yapan bir metodumuz olduğu için bu metoda uygun bi örnek oluşturmamız lazım. Bu metod zaten DortIslem classının içinde.
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5,6);
            dortIslem.Topla(2,7);
        }
    }
}
