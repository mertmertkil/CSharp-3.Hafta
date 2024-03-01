using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class Brand : BaseEntity<int>
	{
		public Brand()
		{
		}

		public string Name { get; set; }
		

	}
}

