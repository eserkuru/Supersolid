using System;

namespace Core.Entities
{
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        Guid Id { get; set; }
        int IntId { get; set; }
        /// <summary>
        /// Gets or sets the entity created time
        /// </summary>
        string Created { get; set; }
        /// <summary>
        /// Gets or sets the entity created by
        /// </summary>
        string CreatedBy { get; set; }
        /// <summary>
        /// Gets or sets the entity modified time
        /// </summary>
        string Modified { get; set; }
        /// <summary>
        /// Gets or sets the entity modified by
        /// </summary>
        string ModifiedBy { get; set; }
        /// <summary>
        /// Gets or sets the entity is deleted
        /// </summary>
        bool IsDeleted { get; set; }
    }
}
