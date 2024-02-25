using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializeDeserialTool.XMLDataObjects
{
    public class Department
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "head")]
        public string Head { get; set; }

        [XmlElement(ElementName = "location")]
        public string Location { get; set; }
    }
}
