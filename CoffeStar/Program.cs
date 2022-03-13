using CoffeStar.Abstract;
using CoffeStar.Concrete;
using CoffeStar.Entites;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using CoffeStar.Adapters;

namespace CoffeStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1996, 9, 8), Name = "?", Surname = "?" ,NationalityId="?"});//Insert your infos
            Console.Read();

        }
    }
}
