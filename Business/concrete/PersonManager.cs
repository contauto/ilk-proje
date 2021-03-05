using Business.Abstract;
using Entities.concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.concrete
{
    public class PersonManager:IbasvuranKisi 
    {

        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.TC, person.Ad, person.Soyad, person.DogumYili))).Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
