using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GamerManager : IPersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName+ " is added to the Gamers");
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
