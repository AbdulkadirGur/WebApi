using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    internal class BrandManager : IBrandServices
    {
        private readonly IBrandServices _brandDal;

        public BrandManager(IBrandServices brandDal)
        {
            _brandDal = brandDal;
        }

        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            //business rules

            //mapping ----Autoamapper
            Brand brand = new();
            brand.Name = createBrandRequest.Name;
            brand.CreatedDate = DateTime.Now;

            _brandDal.Add(brand);

            //mapping
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = brand.Name;
            createdBrandResponse.Id = 4;
            createdBrandResponse.CreatedDate = brand.CreatedDate;

            return createdBrandResponse;
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
