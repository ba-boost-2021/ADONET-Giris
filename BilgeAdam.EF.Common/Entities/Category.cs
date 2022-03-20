using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.EF.Common.Entities
{
    [Table("Categories")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}