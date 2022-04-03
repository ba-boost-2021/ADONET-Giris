using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.EF.DeepDive.Entities
{
    [Table("Categories")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; } //Reverse Navigation Property
    }
}