using System;
using System.Collections.Generic;

namespace EF.Core.Data
{
   public class Course : BaseEntity
    {
       public string Name { get; set; }
       public Int64 MaximumStrength { get; set; }
       public virtual ICollection<Student> Students { get; set; }
    }
}
