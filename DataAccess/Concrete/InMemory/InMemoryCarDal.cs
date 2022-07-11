using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() 
            {
                new Car{Id = 1, BrandId = 1, ColorId = 8, DailyPrice = 1500, ModelYear = 1989, Description = "Hatasız"},
                new Car{Id = 2, BrandId = 3, ColorId = 5, DailyPrice = 3500, ModelYear = 2009, Description = "Hatasız"},
                new Car{Id = 3, BrandId = 4, ColorId = 3, DailyPrice = 5500, ModelYear = 2020, Description = "Hatasız"},

            };
            
        }
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
