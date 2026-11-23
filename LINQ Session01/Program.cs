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
                new  { ProductName = "Salmon", Category = "Seafood", UnitPrice = 25 },
                new  { ProductName = "Chai", Category = "Beverages", UnitPrice = 18 },
                new  { ProductName = "Crab", Category = "Seafood", UnitPrice = 30 }
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
            var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            foreach (var product in result)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}$");
            }
            #endregion

        }
    }
}
