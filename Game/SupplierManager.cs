using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SupplierManager:IPersonManager
    {
        IPersonValidationService _personValidationService;

        public SupplierManager(IPersonValidationService personValidationService)
        {
            _personValidationService = personValidationService;
        }

        public void Add(Person person)
        {
            if (_personValidationService.Validate(person) == true)
            {
                Console.WriteLine(person.FirstName + " is added to the Suppliers");
            }
            else
            {
                Console.WriteLine(person.FirstName + " could not get validated.");

            }
            
        }

        public void Delete(Person person)
        {
            Console.WriteLine(person.FirstName + " is edited on the Suppliers");
        }

        public void Update(Person person)
        {
            Console.WriteLine(person.FirstName + " is deleted from the Suppliers");
        }
    }
}
