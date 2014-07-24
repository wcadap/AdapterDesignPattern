using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace AdapterDesignPattern.Adaptee_LegacyCode
{
    public class GetXMLBookOrder
    {
        public ArrayList ReadXML()
        {
            ArrayList Orders = new ArrayList();
            string[] Order;

            string xmlString = XDocument.Load(@"XMLData\BookOrder.xml").ToString();

            // Read the XML
            Order = new string[6];
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
            {
                while (reader.Read())
                {
                    switch (reader.Name)
                    {
                        case "Title" :
                            if (reader.Read()) { 
                                Order[0] = reader.Value.Trim();
                                reader.Read();
                            }
                            break;
                        case "ISBN":
                            if (reader.Read())
                            {
                                Order[1] = reader.Value.Trim();
                                reader.Read();
                            }
                            break;
                        case "Author":
                            if (reader.Read())
                            {
                                Order[2] = reader.Value.Trim();
                                reader.Read();
                            }
                            break;
                        case "Price":
                            if (reader.Read())
                            {
                                Order[3] = reader.Value.Trim();
                                reader.Read();
                            }
                            break;
                        case "Quantity":
                            if (reader.Read())
                            {
                                Order[4] = reader.Value.Trim();
                                reader.Read();
                            }
                            break;
                        case "Customer":
                            if (reader.Read())
                            {
                                Order[5] = reader.Value.Trim();
                                Orders.Add(Order);
                                Order = new string[6];
                                reader.Read();
                            }
                            break;
                    }
                }
            }
            return Orders;
        }
    }
}
