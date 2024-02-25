using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializeDeserialTool.XMLDataObjects
{
    [XmlRoot("company")]
    public class Company
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("registration_number")]
        public string RegistrationNumber { get; set; }


        [XmlArray("employees")]
        [XmlArrayItem("employee")]
        public List<Employee> Employees { get; set; }
    }
}
