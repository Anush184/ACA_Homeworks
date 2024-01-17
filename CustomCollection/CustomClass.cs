using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CustomCollectionExample
{
    public class CustomClass
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set;}

        public CustomClass(string name, string lastName, int age, DateTime birthday)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Birthday = birthday;
        }


        public static bool operator ==(CustomClass left, CustomClass right)
        {
            if (left.Name == right.Name && left.LastName == left.LastName && left.Age == left.Age && left.Birthday == left.Birthday)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(CustomClass left, CustomClass right)
        {
            if (left.Name == right.Name && left.LastName == left.LastName && left.Age == left.Age && left.Birthday == left.Birthday)
            {
                return false;
            }

            return true;
        }
        public string this[int age]
        {
            get
            {
                if (age == Age)
                {
                    return $"{Name} {LastName}, Age: {Age}, Birthday: {Birthday.ToShortDateString()}";
                }
                else
                {
                    return null; // Or throw an exception, or handle the case accordingly
                }
            }
        }


    }
}
