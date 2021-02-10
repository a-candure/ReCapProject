using System;
using System.Collections.Generic;
using Business.Concreate;
using DataAccess.Concreate;
using DataAccess.Concreate.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           CarManager carManager = new CarManager(new EfCarDal());
           foreach (var Car in carManager.GetAll())
           {
               Console.WriteLine(carManager);
           }
        }
    }
}
