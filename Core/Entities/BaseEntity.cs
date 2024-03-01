using System;
namespace Core.Entities
{
	public class BaseEntity<TId> // TId : 
	{
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedTime { get; set; }

    }
}

