using Business.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.concrete
{
    public class PttManager : IDagiticiServis
    {
        private IbasvuranKisi _basvuranKisi;
        public PttManager(IbasvuranKisi basvurankisi)
        {
            _basvuranKisi = basvurankisi;
        }
    
        public void GiveMask(Person person)
        {
            

       
            if (_basvuranKisi.CheckPerson(person))
            {
                Console.WriteLine(person.Ad + " " + "için maske verildi.");
            }
        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
}
