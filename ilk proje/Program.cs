using Business.concrete;
using Entities.concrete;
using System;

namespace ilk_proje
{
    class Program
    {
        static void Main(string[] args)
        {

           

            SelamVer("Berke");
            SelamVer();

            Person person1 = new Person();
            person1.Ad = "Berke";
            person1.DogumYili = 1999;
            person1.Soyad = "Maktav";
            person1.TC = 11111111111;

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);



            Console.ReadLine();
        }
        static void SelamVer(string isim = "no-name")
        {
            Console.WriteLine("Merhaba" + " " + isim);
        }

        
        


    }
}
