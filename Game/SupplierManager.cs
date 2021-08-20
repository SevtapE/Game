using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SupplierManager:IPersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName + " is added to the Suppliers");
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
