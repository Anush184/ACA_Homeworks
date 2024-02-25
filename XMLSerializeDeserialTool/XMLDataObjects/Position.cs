using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializeDeserialTool.XMLDataObjects
{

    public class Position
    {
        [XmlAttribute("title")]
        public string Title { get; set; }

        [XmlAttribute("level")]
        public string Level { get; set; }
    }
}
