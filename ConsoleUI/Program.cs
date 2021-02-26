using System;
using System.Collections.Generic;
using System.ComponentModel;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandAndCarAdded();
            //ColorAddedTest();
            //ListOfAllTest();
            CustomerDetailDTO();


        }

        private static void CustomerDetailDTO()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetCustomerDetailDto();
            Console.WriteLine("---------MÜŞTERİ LİSTESİ---------\n ");
            foreach (var customerDTO in result.Data)
            {
                Console.WriteLine(" Müşteri Adı : " + customerDTO.CustomerName +
                                  "\n Müşterinin Soyadı :  " + customerDTO.CustomerSurname +
                                  "\n Müşterinin Şirketi :  "+ customerDTO.CustomerCompany+
                                  "\n----------------------------------------");

            }
        }

        private static void ColorAddedTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 7, ColorName = "Yeşil" });
        }

        private static void BrandAndCarAdded()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 9, BrandName = "Toyota" });
            carManager.Add(new Car
            { Id = 8, ColorId = 1, BrandId = 9, DailyPrice = 250, ModelYear = 2011, Description = "Hilux" });
        }

        private static void ListOfAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetailDto();

            Console.WriteLine("---------KİRALIK ARABA LİSTESİ---------\n ");
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(" Arabanın Adı : " + car.Description +
                                      "\n Arabanın Marka Adı :  " + car.BrandName +
                                      "\n Arabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
                                      "\n Arabanın Rengi :  " + car.ColorName +
                                      "\n----------------------------------------");
                }
            }
        }
    }
}