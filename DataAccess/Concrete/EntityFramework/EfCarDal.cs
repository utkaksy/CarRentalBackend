﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, AppDbContext>, ICarDal
    {
        List<CarDetailDto> ICarDal.GetCarDetails()
        {
            using (AppDbContext context=new())
            {
                var result = from car in context.Cars
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join color in context.Colors on car.ColorId equals color.Id
                             select new CarDetailDto { Brand = brand.Name, Color = color.Name, CarId = car.Id, CarName = car.Name };
                return result.ToList();
            }
        }
    }
}
