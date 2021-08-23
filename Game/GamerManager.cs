using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GamerManager : IPersonManager
    {
        IPersonValidationService _personValidationService;

        public GamerManager(IPersonValidationService personValidationService)
        {
            _personValidationService = personValidationService;
        }

        public void Add(Person person)
        {
            if (_personValidationService.Validate(person)==true)
            {
                Console.WriteLine(person.FirstName + " is added to the Gamers");
            }
            else
            {
                Console.WriteLine(person.FirstName + " could not get validated");

            }

        }

        public void Delete(Person person)
        {
            Console.WriteLine(person.FirstName+" is edited on the Gamers");
        }

        public void Update(Person person)
        {
            Console.WriteLine(person.FirstName+ " is deleted from the Gamers");
        }
    }
}
