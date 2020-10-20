namespace WebStoreCoreApplication.Domain.Entities.Base.Interfaces
{
    public interface INameEntity : IBaseEntity
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
