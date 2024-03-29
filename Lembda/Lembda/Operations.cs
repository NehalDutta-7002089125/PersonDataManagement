﻿using System;
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
        public void RetreiveAllRecordsOfAge(List<Person> person)
        {
            var data = person.Where(x => x.Age > 13 && x.Age < 18).ToList();
            foreach (var result in data)
            {
                Console.WriteLine(result.SSN);
            }
        }
        public void AverageAge(List<Person> person)
        {
            var data = person.Average(x => x.Age);
            Console.WriteLine(data);
        }
    }
}
