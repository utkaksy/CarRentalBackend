using Business.Concrete;
using DataAccess.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager=new CarManager(new InMemoryCarDal());
            
            var result = carManager.GetAll();
            
            foreach (var item in result)
            {
                Console.WriteLine(item.BrandId+"   "+item.DailyPrice);
            }
        }
    }
}
