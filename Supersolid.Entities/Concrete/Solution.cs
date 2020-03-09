using Supersolid.Entities.Abstract;
using Supersolid.Entities.Enums;

namespace Supersolid.Entities.Concrete
{
    public class Solution : BaseEntity
    {
        public virtual SolutionGroup SolutionGroup { get; set; }
        public virtual SolutionSubGroup SolutionSubGroup { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string LongDescription { get; set; }
        public virtual string DirectoryName { get; set; }
        public virtual bool IsFileCreated { get; set; }
    }
}
