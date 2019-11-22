using Supersolid.Entities.Abstract;
using Supersolid.Entities.Enums;

namespace Supersolid.Entities.Concrete
{
    public class Project : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public virtual SourceType SourceType { get; set; }
        public virtual string DirectoryName { get; set; }
        public virtual bool IsFileCreated { get; set; }
        public virtual Layer Layer { get; set; }
    }
}
