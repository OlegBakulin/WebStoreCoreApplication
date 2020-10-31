using System.ComponentModel.DataAnnotations.Schema;
using WebStoreCoreApplication.Domain.Entities.Base;
using WebStoreCoreApplication.Domain.Entities.Base.Interfaces;

namespace WebStoreCoreApplication.Domain.Entities
{
    [Table("Products")]
    public class Product : NameEntity, IOrderEntity
    {
        public int Order { get; set; }
        public int CategoryId { get; set; }
        public int? BrandId { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        //public int Size { get; set; }
        [ForeignKey("CategoryIDForeigen")]
        public virtual Category Category { get; set; }

        [ForeignKey("BrandIdForeigen")]
        public virtual Brand Brand { get; set; }

    }
}