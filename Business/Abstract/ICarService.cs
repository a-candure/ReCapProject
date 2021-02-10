using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car>GetCarByBrandId(int id);
        List<Car> GetCarByColorId(int id);

    }
}