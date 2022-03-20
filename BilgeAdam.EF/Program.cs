using BilgeAdam.EF.Common;

namespace BilgeAdam.EF
{
    class Program
    {
        static void Main()
        {
            var context = new NorthwindDbContext();
            var employees = context.Employees.ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName}\t\t{employee.LastName}\t\t{employee.BirthDate}");
            }
            Console.WriteLine("__________________________________________________________________________");
            var products = context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductName}\t\t{product.UnitPrice}");
            }
        }
    }
}