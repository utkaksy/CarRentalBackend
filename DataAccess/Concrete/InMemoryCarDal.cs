using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=15000,Description="a",ModelYear="2000"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=20000,Description="a",ModelYear="2000"},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=5000,Description="a",ModelYear="2000"},
                new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=10000,Description="a",ModelYear="2000"},
                new Car{Id=5,BrandId=3,ColorId=2,DailyPrice=50000,Description="a",ModelYear="2000"},
            };
        }
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            var result=_cars.FirstOrDefault(c => c.Id == car.Id);
            _cars.Remove(result);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
