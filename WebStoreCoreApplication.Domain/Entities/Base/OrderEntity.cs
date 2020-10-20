using WebStoreCoreApplication.Domain.Entities.Base.Interfaces;

namespace WebStoreCoreApplication.Domain.Entities.Base
{
    public class OrderEntity : IOrderEntity
    {
        int Order { get; set; }
        int IOrderEntity.Order { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
