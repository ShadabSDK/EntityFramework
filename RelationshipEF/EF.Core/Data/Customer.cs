using System.Collections.Generic;

namespace EF.Core.Data
{
  public  class Customer : BaseEntity 
    {
      public string Name { get; set; }
      public string Email { get; set; }
      public virtual ICollection<Order> Orders { get; set; }
    }
}
