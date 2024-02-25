using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializeDeserialTool.XMLDataObjects
{
    public class Employee
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("position")]
        public Position EmployeePosition { get; set; }

        [XmlElement("department")]
       public Department EmployeeDepartment { get; set; }

        [XmlElement("contact")]
        public Contact EmployeeContact { get; set; }

        [XmlArray("projects")]
        [XmlArrayItem("project")]
        public List<Project> Projects { get; set; }
    }
}
