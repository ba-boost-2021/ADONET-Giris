namespace BilgeAdam.Sql.ThirdParty.HR.Models
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string City { get; set; }
    }

    public class EmployeeFilterParameter
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class NewEmployeeDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
