using Supersolid.Entities.Abstract;
using Supersolid.Entities.Enums;

namespace Supersolid.Entities.Concrete
{
    public class Layer: BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual SourceType SourceType { get; set; }
        public virtual string Description { get; set; }
        public virtual Solution Solution { get; set; }
    }
}
