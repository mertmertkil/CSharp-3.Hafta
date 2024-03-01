using System;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface IBrandService
	{
		CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
		List<GetAllBrandResponse> GetAll();
	}
}

