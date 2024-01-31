using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem
{
    public class TypeInformation<T>
    {
        private T _type;

        //public TypeInformation(T type)
        //{
        //    _type = type;
        //}
        public T Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public void TypeInfoThroughReflection()
        {
            var t = typeof(T);
            Console.WriteLine($"Type Information for {t.Name} class:");
            Console.WriteLine();
            Console.WriteLine($"Properties: ");
            Console.WriteLine(new string('-', 25));
            foreach (var property in t.GetProperties())
            {
                Console.WriteLine($"Property Name: {property.Name}, Type: {property.PropertyType.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Constructors: ");
            Console.WriteLine(new string('-', 25));

            foreach (var constructor in t.GetConstructors())
            {
                Console.Write($"Constructor name is: {constructor.Name}, parameters: ");
                foreach (var parameter in constructor.GetParameters())
                {
                    Console.Write($"{parameter.Name}, ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Methods:");
            Console.WriteLine(new string('-', 25));

            foreach (var method in t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)) 
            {
                Console.WriteLine($"Method name is: {method.Name}, Member type is {method.ReturnType}");
            }

            //foreach (var member in t.GetMembers())
            //{
            //    Console.WriteLine($"Member name is: {member.Name}, Member type is {member.MemberType}");
            //}
           
        }

    }
}
