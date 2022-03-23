using System.ComponentModel.DataAnnotations.Schema;
using Tratel.Common.Enums;

namespace Tratel.Entities.Customer
{
    [Table("Places", Schema = "Customer")]
    public class Place : EntityBase
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public PlaceType Type { get; set; }
    }
}
