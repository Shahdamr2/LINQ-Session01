using System.Xml.Linq;

namespace LINQ_Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            var ProductList = new[]
            {
                new  { ProductName = "Salmon", Category = "Seafood", UnitPrice = 25,UnitsInStock = 40 },
                new  { ProductName = "Condiments", Category = "Beverages", UnitPrice = 18,UnitsInStock=33 },
                new  { ProductName = "Crab", Category = "Seafood", UnitPrice = 30,UnitsInStock=20 }
            };

            //var result = ProductList.Where(p => p.Category == "Seafood");

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}$");
            //}
            #endregion
            #region Question02
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion
            #region Question03
            //var result = ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name : {product.ProductName} , Product Price : {product.UnitPrice}$");
            //}
            #endregion
            #region Question04
            //var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}$");
            //}
            #endregion
            #region Question05
            //var result = ProductList.Where(p => p.ProductName == "Condiments" && p.UnitsInStock > 0);
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Stock: {product.UnitsInStock}");
            //}
            #endregion
            #region Question06
            //var result =ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock >0 ? "Available" : "Out of Stock"


            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(
            //        $"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
            //}
            #endregion
            #region Question07
            //var result = ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question09
            var result = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock)
                .Select(p => new
                {
                    p.ProductName,
                    p.UnitsInStock
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            }

            #endregion

            #region Question11

            #endregion

        }
    }
}
