using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializeDeserialTool.XMLDataObjects
{
    public class Phone
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlText]
        public string Number { get; set; }
    }
}
