using System.Threading.Channels;
using System.Xml.Serialization;
using XMLSerializeDeserialTool;
using XMLSerializeDeserialTool.XMLDataObjects;

string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XMLFiles", "xmlSample.xml");

var company = XMLToObject.DeserializeCompany(xmlFilePath);
//XMLToObject.CompanyDescription(company);

// Creating new employee and adding to our Company

Employee newEmployee = new Employee
{
    Id = 3, 
    Name = "Amanda Brown",
    EmployeePosition = new Position { Title ="Programmer", Level = "1" },
    EmployeeDepartment = new Department { Id = 103, Name = "SupportTeam", Head = "Joseph Miller ", Location = "Building B, Floor 3" },
    EmployeeContact = new Contact
    {
        Emails = new List<Email> { new Email { Type = "work", Address = "amandabrown34@gmail.com" } },
        EmployeePhone = new Phone { Type = "work", Number = "+1234567890" }
    },
    Projects = new List<Project>
    {
        new Project{Id = 52,Name = "Backend Refactoring", Description = "Refactor the existing backend codebase to improve code maintainability, scalability, and performance.", Status = "Completed"},
        new Project{Id = 53,Name = "API Integration",Description =   "Integrate third-party APIs for payment processing and user authentication into the company's software platform.", Status = "Started"}, 
        new Project{Id = 54,Name = "New Feature Development",Description = "Develop a new feature for the company's web application, allowing users to customize their profiles with additional information.", Status = "In Progress"}
    }
};

company.Employees.Add(newEmployee);
//XMLToObject.CompanyDescription(company);


string xmlFilePathNew = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XMLFiles", "xmlSampleNew.xml");

ObjectToXML.SerializeCompany(company, xmlFilePathNew);
Console.WriteLine();
//ObjectToXML.XMLDescription(xmlFilePathNew);





