using Supersolid.Entities.Abstract;

namespace Supersolid.Entities.Concrete
{
    public class Solution : BaseEntity
    {
        public virtual string CompanyName { get; set; }
        public virtual string ProjectName { get; set; }
        public virtual string Description { get; set; }
        public virtual string LongDescription { get; set; }
        public virtual string DirectoryName { get; set; }
        public virtual bool IsFileCreated { get; set; }
    }
}
