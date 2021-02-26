using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = 
                    from c in context.Cars
                    join b in context.Brands on c.BrandId equals b.BrandId
                    join r in context.Colors on c.ColorId equals r.ColorId
                    select new CarDetailDto 
                    { 
                        CarId = c.Id, 
                        BrandName = b.BrandName,
                        ColorName = r.ColorName,
                        Description = c.Description,
                        DailyPrice = (short)c.DailyPrice
                    };
                return result.ToList();
            }
            

        }
    }
}