using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concreate
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2015, Description = "Vw Golf VII Mavi", DailyPrice = 230000},
                new Car{Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2017, Description = "Vw Passat B8 Beyaz", DailyPrice = 290000},
                new Car{Id = 3, BrandId = 2, ColorId = 2, ModelYear = 2016, Description = "Ford Focus Beyaz", DailyPrice = 195000},
                new Car{Id = 4, BrandId = 3, ColorId = 3, ModelYear = 2010, Description = "Volvo S60 Siyah", DailyPrice = 142000},
                new Car{Id = 5, BrandId = 2, ColorId = 1, ModelYear = 2012, Description = "Vw Polo Mavi", DailyPrice = 175000}

            };
        }

        public string GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c =>c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }
    }
}