using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using EmployeeManagementSystem;


//Employee manager = new Employee(1, "Manager", 1500);
//Employee employee2 = new Employee(1, "Armine", 1500);
//Employee employee3 = new Employee(3, "Ann", 2500);
//Employee employee4 = new Employee(4, "Saten", 500);
//manager.AddEmployee(employee2);
//manager.AddEmployee(employee3);
//manager.AddEmployee(employee4);
//foreach (var emp in manager)
//{
//    Console.WriteLine(emp.ToString());
//}


var t = typeof(Employee);
TypeInformation<Employee> typeInfo = new TypeInformation<Employee>();
typeInfo.TypeInfoThroughReflection();
Console.WriteLine();

foreach (var field in t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
{
    if (field.Name == "_salary")
    {
        var validationAttributes = field.GetCustomAttributes(typeof(SalaryValidationAttribute), true);
        foreach (var validationAttribute in validationAttributes)
        {
            if (validationAttribute is ValidationAttribute attribute)
            {
                if (!attribute.IsValid(field.GetValue(new Employee(5, "Anna", 6000))))
                {
                    Console.WriteLine($"Validation failed for field {field.Name}: {attribute.ErrorMessage}");
                }
                else
                {
                    Console.WriteLine($"Validation passed for field {field.Name}.");
                }
            }
        }
    }
}
