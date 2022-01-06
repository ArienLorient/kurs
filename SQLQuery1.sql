																	--Select SQL'de yorum satırını "--" ile yaparız.
																	-- Select * from Customers - Burada ise tüm Customers tablosunu getirmesini istedik.
Select ContactName,CompanyName,City from Customers					--Burada Customers içinde ki 3 kolonu seçip getir dedik.
																	--Burada sahte bir tablo oluşturup getiriyor. Burası aslında bir tablo.
																	--Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers / bu kullanım ile tabloları farklı bir isimle değiştirip çağırabiliriz.
Select * from Customers where City = 'London'						--London'da olan müşterileri getirmesini istedik.
																	--case insensitive = büyük küçük harflere duyarsızdır.
Select * from Products												--Ürünler tablosunu tüm kolonlarıyla getirir.

Select * from Products where CategoryID=1 or CategoryID=3			--1 numaralı kategoriye ait ürünleri listeledik. E-ticaret sitelerinde kategorileri filtrelediğimizde yapılan işlem budur.

Select * from Products where CategoryID=1 and UnitPrice>=10			-- >= büyük eşittir / <> farklı olan

Select * from Products order by ProductName							--ürün ismine göre listelenmiş şekilde görüyoruz.

Select * from Products order by CategoryID, ProductName				-- Önce Kategori Id'sine göre kategoriId içinde de Ürün adına göre sıralamış olduk.

Select * from Products order by UnitPrice asc						--Ürün fiyatına göre en ucuzdan sıraladık. ascending'den gelir = artan sıraya göre sıralar. Default olarak sıralarsak asc olarak sıralarız. Vermesekte olur.

Select * from Products order by UnitPrice desc						--Descending'den gelir. Fiyatları azalan sıraya göre listelememizi sağlar.

Select * from Products where CategoryID=1 order by UnitPrice desc	--CategoryId kısmında önce kategorisini sonra o kategoride ki fiyata göre azalan şekilde sıralarız bu kodla.

Select count(*) from Products										--Products tablosunda kaç tane eleman olduğunu gösteren kod. tüm satırları saymasını isteriz. Kataloğumuzda kaç adet ürün olduğunu bu kod ile gösteririz.
																	--Bu kodda sadece tek bir satır ve kolon gelir. Count'tan sonra where-order by gibi kodlar geçerlidir. 
Select count(*) Adet from Products where CategoryID=2
	
Select CategoryId, UnitPrice,count(*) Adet from Products group by CategoryID, UnitPrice	--Burada group by ifadesinden sonra gelen nesne için sıralamamızı ve o nesnede kaç eleman olduğunu hesaplaabiliriz. Group by ile 2 kolona birden de araya virgül koyarak komut verebiliriz.

Select CategoryId,count(*) Adet from Products group by CategoryID having count(*)<10	--having kümülatif dataya odaklanmamıza yarayan kod bloğudur. Sistemde 10'dan az olan ürünleri listelemek için kullandığımız kod bloğudur.

Select CategoryId,count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10		--çoklu emirlerde her zaman önce "where" çalışır. Bu kod şu demektir; birim fiyatı 20'den fazla olan ürünleri CategoryId'ye göre grupla onlardan da sayısı 10'dan düşük olanları listelememizi sağladı.

select *															--from hem products'ı hemde Categories'i kapsıyor. İkisini bir araya getirmiş oluyor.
from Products inner join Categories									--inner join ile Products ile Categories'i birleştirdik.
on Products.CategoryID=Categories.CategoryID						--on, şartında demektir. products da bulunan categoryid ile categories te bulunan categoryid eşitse yan yana getir demektir.

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName		--* tüm kolonları kapsadığı için sadece belirli kolonları listelemek istediğimizde yanda ki gibi belirtmemiz yeterlidir.
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID						--DTO -Data Trasnformation Object- Hazırladığımız joinlere verilen isimdir.

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName		--Burada fiyatı 10dan büyük olan ürünleri kategori isimleri ile getirecek sorgunun ta kendisidir. 
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10											--inner join ile sadece 2 tabloda ki datalardan eşleşenleri bir araya getiririz. Eşleşmeyen bilgiler bir araya getirilmez. 2 tabloda ki ortak kolonları bulmamız gerekiyor.

Select * from Products p left join [Order Details]	od				--Order Details'in yazımında hata olduğu için arada ki boşluğu 2 farklı kod olarak algılamasın diye köşeli parantez içerisinde getirdi.
on p.ProductID=od.ProductID											--SQL'de kısaltmaları kullanabliyoruz. p Products, od yi ise OrderDetails yerine kullanabiliriz.
																	--left join solda olup sağda olmayanları da getir demektir.

select * from Customers c left join Orders o						--sistemde kayıtlı ama daha alışveriş yapmamış kişiler var mı? sorusunun yanıtını inner ile left'i değiştirip sonuçlara bakarak bulabiliriz. Genellikle ana tablo öne yazılır.
on c.CustomerID=o.CustomerID										--sipariş vermeyen müşterileri listeleyen kod bloğudur.
where o.CustomerID is null											--right join ise left join'in tam tersi durumdadır. bu kodlar genelde yazım sırasını belirler. 

Select * from Products p inner join [Order Details]	od				--2den fazla tabloyu birleştirme örneği.
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

