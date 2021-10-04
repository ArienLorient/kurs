using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class Product
    {
        public int Id { get; set; } //Ürünün İd numarası
        public int CategoryId { get; set; } //Ürünün kategorisi
        public string ProductName { get; set; } //Ürünün adı
        public double UnitPrice { get; set; } //Ürünün ücreti
        public int UnitsInStock { get; set; } //Stok adedi
    }
}
