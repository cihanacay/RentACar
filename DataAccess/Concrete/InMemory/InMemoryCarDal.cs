using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=1, ColorId=1,DailyPrice=200,Fuel="Dizel",Gear="Manuel",ModelYear="2015",LuggageVolume="300L"},
                new Car{Id=2, BrandId=2, ColorId=1,DailyPrice=150,Fuel="Benzin",Gear="Otomatik",ModelYear="2019",LuggageVolume="100L"},
                new Car{Id=3, BrandId=3, ColorId=1,DailyPrice=300,Fuel="LPG",Gear="Manuel",ModelYear="2020",LuggageVolume="200L"},
                new Car{Id=4, BrandId=1, ColorId=1,DailyPrice=400,Fuel="Dizel",Gear="Manuel",ModelYear="2017",LuggageVolume="300L"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId; 
            carToUpdate.DailyPrice = car.DailyPrice; 
            carToUpdate.Fuel = car.Fuel; 
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Gear = car.Gear;

        }
         
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(x => x.BrandId == brandId).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
