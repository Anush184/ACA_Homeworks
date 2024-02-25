using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLSerializeDeserialTool.XMLDataObjects;

namespace XMLSerializeDeserialTool
{
    public class XMLToObject
    {
        public static Company DeserializeCompany(string filePath)
        {
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Company));
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    try
                    {
                        Company company = (Company)serializer.Deserialize(fs);
                        return company;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            }
            else
            {
                throw new Exception("XML file not found.");
            }
        }
        public static void CompanyDescription(Company company)
        {
            Console.WriteLine($"Company name: '{company.Name}'");
            Console.WriteLine("Number of Employees: " + company.Employees.Count);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"{company.Name} Company employees:");
            foreach (var employee in company.Employees)
            {
                Console.WriteLine($"Employee Id: {employee.Id}");
                Console.WriteLine($"Employee Name: {employee.Name}");
                Console.WriteLine($"Position Title: {employee.EmployeePosition.Title}");
                Console.WriteLine($"Position Level: {employee.EmployeePosition.Level}");
                Console.WriteLine($"Department Name: {employee.EmployeeDepartment.Name}");
                Console.WriteLine($"Department Head: {employee.EmployeeDepartment.Head}");
                Console.WriteLine($"Department Location: {employee.EmployeeDepartment.Location}");

                List<Email> emails = employee.EmployeeContact.Emails;
                foreach (Email email in emails)
                {
                    Console.WriteLine($"Email Type: {email.Type}: {email.Address}");
                }

                Console.WriteLine($"Phone Type: {employee.EmployeeContact.EmployeePhone.Type}: " +
                                  $"{employee.EmployeeContact.EmployeePhone.Number}");

                foreach (var project in employee.Projects)
                {
                    Console.WriteLine($"Project Id: {project.Id}");
                    Console.WriteLine($"Project Name: {project.Name}");
                    Console.WriteLine($"Project Description: {project.Description}");
                    Console.WriteLine($"Project Status: {project.Status}");
                }
                Console.WriteLine(new string('-', 30));
            }
        }

    }
}
