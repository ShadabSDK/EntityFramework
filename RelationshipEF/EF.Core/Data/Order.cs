using System;

namespace EF.Core.Data
{
    public class Order : BaseEntity
    {
        public byte Quanatity { get; set; }
        public Decimal Price { get; set; }
        public Int64 CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
