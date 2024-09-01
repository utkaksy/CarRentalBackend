using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //NewMethod();
            
            List<CarDetailDto> cars= carManager.GetCarDetails();
            foreach (var carDetail in cars)
            {
                Console.WriteLine(carDetail.CarName+" "+carDetail.Brand+" "+carDetail.Color+" "+carDetail.CarId);
            }
        }

        private static void NewMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.BrandId + "   " + item.DailyPrice);
            }
        }
    }
}
