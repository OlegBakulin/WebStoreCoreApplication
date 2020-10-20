using WebStoreCoreApplication.Domain.Entities.Base.Interfaces;

namespace WebStoreCoreApplication.Domain.Entities.Base
{
    public class NameEntity : INameEntity
    {
        int Id { get; set; }
        int INameEntity.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        int IBaseEntity.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        string Name { get; set; }
        string INameEntity.Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
