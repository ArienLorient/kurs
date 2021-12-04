using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 4;

            Product product2 = new Product { Id = 2, CategoryId = 4, UnitsInStock = 4, ProductName = "Kalem", UnitPrice = 35, };
            // 9. satırda yaptığımız işlemin aynısını 16. satırda yaptığımız şekilde de yapabiliriz.
            // Ayrıca bu tarz ürün listelerini oluştururken adı, fiyatı, id gibi detayları kullanıcıdan isteriz.
            
            //Aşağıda ki kod bloğunun sol kısmı STACK kısmında sağ tarafı ise HEAP kısmında yer tutar.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int, double, bool... gibi sayısal veriler değer tip.
            //diziler, class, abstract class, interface... bunlar ise referans tip değerlerdir.
        }
    }
}
