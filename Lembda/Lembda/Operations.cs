using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lembda
{
    internal class Operations
    {
        public void RetreiveTopRecordsOfAge(List<Person> person)
        {
            var data = person.Where(x => x.Age < 60).ToList().Take(2);
            foreach (var result in data)
            {
                Console.WriteLine(result.SSN);
            }
        }
    }
}
