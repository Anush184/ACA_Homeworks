using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializeDeserialTool.XMLDataObjects
{
    public class Email
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlText]
        public string Address { get; set; }
    }
}
