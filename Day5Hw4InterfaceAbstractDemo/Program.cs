using Day5Hw4InterfaceAbstractDemo.Abstract;
using Day5Hw4InterfaceAbstractDemo.Adapters;
using Day5Hw4InterfaceAbstractDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Hw4InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MerniServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new System.DateTime(1990,3,9),FirstName="Musa",LastName="Erkek",NationalityId= "12345678910" });
            Console.ReadLine();
        }
    }
}
