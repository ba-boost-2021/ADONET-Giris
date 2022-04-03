using BilgeAdam.EF.DeepDive;
using BilgeAdam.EF.DeepDive.Entities;
using Microsoft.EntityFrameworkCore;

var context = new NorthwindDbContext();

var countOfProducts = context.Products.Count();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Result : {countOfProducts}");
Console.WriteLine("==================================================");
Console.ForegroundColor = ConsoleColor.White;


var productsAndOtherInformations = context.Products
                                          .Select(s => new
                                          {
                                              Name = s.ProductName,
                                              Category = s.Category.CategoryName,
                                              Company = s.Supplier.CompanyName
                                          }).ToList();

Console.ForegroundColor = ConsoleColor.Yellow;
foreach (var product in productsAndOtherInformations)
{
    Console.WriteLine("{0, 35}\t{1, 25}\t{2, 40}", product.Name, product.Category, product.Company);
}
Console.WriteLine("==================================================");
Console.ForegroundColor = ConsoleColor.White;

var sumOfAlfkisOrderPrice = context.OrderDetails.Include(i => i.Order)
                                                .Where(f => f.Order.CustomerID == "ALFKI")
                                                .Sum(s => s.UnitPrice * s.Quantity * (1 - (decimal)s.Discount));
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Result : {sumOfAlfkisOrderPrice}");
Console.WriteLine("==================================================");
Console.ForegroundColor = ConsoleColor.White;

var employeeSalesPerformanceFor1997 = context.OrderDetails.Include(i => i.Order)
                                                          .ThenInclude(i => i.Employee)
                                                          .Where(f => f.Order.OrderDate.Year == 2019)
                                                          .GroupBy(g => g.Order.EmployeeID)
                                                          .Select(s => new
                                                          {
                                                              EmployeeID = s.Key,
                                                              SalesPerformance = s.Sum(s => s.UnitPrice * s.Quantity * (1 - (decimal)s.Discount))
                                                          })
                                                          .ToList();
Console.ForegroundColor = ConsoleColor.Red;
foreach (var perf in employeeSalesPerformanceFor1997)
{
    Console.WriteLine($"\t{perf.EmployeeID}\t{perf.SalesPerformance}");
}
Console.WriteLine("==================================================");
Console.ForegroundColor = ConsoleColor.White;

var employeeSalesPerformanceFor1997Ordered = context.OrderDetails.Include(i => i.Order)
                                                          .ThenInclude(i => i.Employee)
                                                          .Where(f => f.Order.OrderDate.Year == 2019)
                                                          .GroupBy(g => g.Order.EmployeeID)
                                                          .Select(s => new
                                                          {
                                                              EmployeeID = s.Key,
                                                              SalesPerformance = s.Sum(s => s.UnitPrice * s.Quantity * (1 - (decimal)s.Discount))
                                                          })
                                                          .OrderByDescending(o => o.SalesPerformance)
                                                          .ToList();
Console.ForegroundColor = ConsoleColor.Red;
foreach (var perf in employeeSalesPerformanceFor1997Ordered)
{
    Console.WriteLine($"\t{perf.EmployeeID}\t{perf.SalesPerformance}");
}
Console.WriteLine("==================================================");
Console.ForegroundColor = ConsoleColor.White;

var employeeSalesPerformanceFor1997DetailedAndOrdered = context.OrderDetails
                                                               .Include(i => i.Order)
                                                               .ThenInclude(i => i.Employee)
                                                               .Where(f => f.Order.OrderDate.Year == 2019)
                                                               .GroupBy(g => new { g.Order.Employee.FirstName, g.Order.Employee.LastName })
                                                               .Select(s => new
                                                               {
                                                                   FullName = s.Key.FirstName + " " + s.Key.LastName,
                                                                   SalesPerformance = s.Sum(s => s.UnitPrice * s.Quantity * (1 - (decimal)s.Discount))
                                                               })
                                                               .OrderByDescending(o => o.SalesPerformance)
                                                               .ToList();
Console.ForegroundColor = ConsoleColor.Red;
foreach (var perf in employeeSalesPerformanceFor1997DetailedAndOrdered)
{
    Console.WriteLine("{0, 25}\t{1}", perf.FullName, perf.SalesPerformance);
}
Console.WriteLine("==================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Order Details Oriented");
Console.ForegroundColor = ConsoleColor.White;
var salesSummaryOfEachProductInBeveragesCategory = context.OrderDetails
                                                          .Include(i => i.Product)
                                                          .ThenInclude(i => i.Category)
                                                          .Where(f => f.Product.Category.CategoryName == "Beverages")
                                                          .GroupBy(g => new { g.Product.ProductName, g.Product.Category.CategoryName })
                                                          .Select(s => new 
                                                          {
                                                              ProductName = s.Key.ProductName,
                                                              CategoryName = s.Key.CategoryName,
                                                              Summary = s.Sum(s => s.UnitPrice * s.Quantity)
                                                          });

Console.ForegroundColor = ConsoleColor.Red;
foreach (var sales in salesSummaryOfEachProductInBeveragesCategory)
{
    Console.WriteLine("{0, 25}\t{1, 12}\t{2}", sales.ProductName, sales.CategoryName, sales.Summary);
}
Console.WriteLine("==================================================");
Console.ForegroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Product Oriented");
Console.ForegroundColor = ConsoleColor.White;
var salesSummaryOfEachProductInBeveragesCategory2 = context.Products
                                                          .Include(i => i.Category)
                                                          .Include(i => i.OrderDetails)
                                                          .Where(f => f.Category.CategoryName == "Beverages")
                                                          .GroupBy(g => new { g.ProductName, g.Category.CategoryName })
                                                          .Select(s => new
                                                          {
                                                              ProductName = s.Key.ProductName,
                                                              CategoryName = s.Key.CategoryName,
                                                              Summary = s.SelectMany(m => m.OrderDetails).Sum(t => t.UnitPrice * t.Quantity)
                                                          });

Console.ForegroundColor = ConsoleColor.Red;
foreach (var sales in salesSummaryOfEachProductInBeveragesCategory2)
{
    Console.WriteLine("{0, 25}\t{1, 12}\t{2}", sales.ProductName, sales.CategoryName, sales.Summary);
}
Console.WriteLine("==================================================");
Console.ForegroundColor = ConsoleColor.White;

//void PrintQuery<T>(IQueryable<T> query)
//{
//    Console.WriteLine("==================================================");
//    Console.WriteLine(query.ToQueryString());  // EF sorgusunu TSQL'e çevirir
//}