using WebStoreCoreApplication.Domain.Entities.Base.Interfaces;

namespace WebStoreCoreApplication.Domain.Entities.Base
{
    public class NameEntity : INameEntity
    {
        public int Id { get; set; }
      
        public string Name { get; set; }
         
    }
}
