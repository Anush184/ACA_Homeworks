using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializeDeserialTool.XMLDataObjects
{
    public class Contact
    {
        [XmlElement("email")]
        public List<Email> Emails { get; set; }


        [XmlElement("phone")]
        public Phone EmployeePhone { get; set; }

    }
}
