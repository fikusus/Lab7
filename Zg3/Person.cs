using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zg3
{
    class Person
    {
        private String firstName;
        private String lastName;
        private String middleName;
        public uint Age { get; private set; }
        private double weight;

        public Person(string firstName, string lastName, string middleName, uint age, double weight)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.Age = age;
            this.weight = weight;
        }


        public override string ToString()
        {
            return firstName + " " + lastName + " " + middleName + " возраст:" + Age + " вес:" + weight;
        }


    }
}
