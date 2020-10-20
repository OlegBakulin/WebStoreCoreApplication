using System;
using System.Collections.Generic;
using System.Text;
using WebStoreCoreApplication.Domain.Entities.Base;
using WebStoreCoreApplication.Domain.Entities.Base.Interfaces;

namespace WebStoreCoreApplication.Domain.Entities
{
    public class Brand : NameEntity, IOrderEntity
    {
        public int Order { get; set; }
    }
}
