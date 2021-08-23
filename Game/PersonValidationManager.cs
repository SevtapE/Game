using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class PersonValidationManager : IPersonValidationService
    {
        public bool Validate(Person person)
        {
            if (person.NationalityId != null)
            { //assume the person has been validated
                return true;
            }
            else { return false; }
        }
    }
}
