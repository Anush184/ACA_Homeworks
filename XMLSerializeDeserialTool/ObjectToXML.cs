using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLSerializeDeserialTool.XMLDataObjects;

namespace XMLSerializeDeserialTool
{
    public class ObjectToXML
    {
        public static void SerializeCompany(Company company, string filePath)
        {
            if (company == null)
            {
                throw new ArgumentNullException(nameof(company), "The Company object was null.");
            }

            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("The file path was null or empty.", nameof(filePath));
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Company));
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(fs, company);
                }
                Console.WriteLine($"Company object serialized and saved to {filePath} successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error occurred during serialization: {e.Message}");
                throw; 
            }
        }

        public static void XMLDescription(string filePath)
        {
            if (File.Exists(filePath))
            {
                string xmlContent = File.ReadAllText(filePath);
                Console.WriteLine(xmlContent);
            }
            else
            {
                Console.WriteLine("XML file not found.");
            }
        }
    }
}
