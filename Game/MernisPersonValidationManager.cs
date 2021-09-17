using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class MernisPersonValidationManager : IPersonValidationService
    {
       
        public bool Validate(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody (Convert.ToInt64(person.NationalityId),person.FirstName.ToUpper(),person.LastName.ToUpper(),person.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
            
        }
    }
}
