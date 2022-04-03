using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.EF.DeepDive.Entities
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
    }
}