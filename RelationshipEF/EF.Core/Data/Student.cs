using System.Collections.Generic;

namespace EF.Core.Data
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public bool IsCurrent { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
