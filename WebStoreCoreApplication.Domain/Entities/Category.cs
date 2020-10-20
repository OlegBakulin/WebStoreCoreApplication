using WebStoreCoreApplication.Domain.Entities.Base;
using WebStoreCoreApplication.Domain.Entities.Base.Interfaces;

namespace WebStoreCoreApplication.Domain.Entities
{
    public class Category : NameEntity, IOrderEntity
    {
        public int? ParentId { get; set; }
        public int Order { get; set; }
    }
}
