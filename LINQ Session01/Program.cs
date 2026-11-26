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
                new  { ProductName = "Mustard", Category = "Condiments", UnitPrice = 18,UnitsInStock=33 },
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
            var result = ProductList.Where(p => p.Category == "Condiments" && p.UnitsInStock > 0);
            foreach (var product in result)
            {
                Console.WriteLine($"Name: {product.ProductName}, Stock: {product.UnitsInStock}");
            }
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
            #region Question08
            //var result = ProductList
            //.OrderBy(p => p.Category)
            //.ThenByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductName} - {item.UnitPrice}");
            //}
            #endregion
            #region Question09
            //var result = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock)
            //    .Select(p => new
            //    {
            //        p.ProductName,
            //        p.UnitsInStock
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            //}

            #endregion
            #region Question10
            //var customers = new[]
            //{
            //    new
            //    {
            //        CustomerID = "C001",
            //        Orders = new[]
            //        {
            //            new { OrderDate = new DateTime(1996, 5, 10) },
            //            new { OrderDate = new DateTime(1997, 8, 15) }
            //        }
            //    },
            //    new
            //    {
            //        CustomerID = "C002",
            //        Orders = new[]
            //        {
            //            new { OrderDate = new DateTime(1998, 3, 20) }
            //        }
            //    }
            //};

            //var result =
            //    from c in customers
            //    from o in c.Orders
            //    where o.OrderDate >= new DateTime(1997, 1, 1)
            //    select new
            //    {
            //        c.CustomerID,
            //        o.OrderDate
            //    };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CustomerID} - {item.OrderDate}");
            //}
            #endregion
            #region Question11
            //var result = ProductList.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    p.ProductName
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}
            #endregion
            #region Question12
            string[] Arr =
            {
                "aPPLE", "AbAcUs", "bRaNcH",
                "BlUeBeRrY", "ClOvEr", "cHeRry", "kiwi"
            };

            //var result = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Question13

            //var result13 = Arr
            //    .Where(word => word.Length > 1 && char.ToLower(word[1]) == 'i')
            //    .Reverse()
            //    .ToList();

            //foreach (var word in result13)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

        }
    }
}
