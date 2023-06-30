using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Reflection;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarSevice carSevice = new CarManager(new EfCarDal());
            var result = carSevice.GetAllCarDetails();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.BrandName + "-" + item.CarName + "-" + item.ColorName + "-" + item.DailyPrice);
                }
            }
         
        }
    }
}
