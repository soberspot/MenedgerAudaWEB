using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;

namespace MenedgerAudaWEB_0._0
{
    class XMLresours
    {

//        XElement contactXML =
//    new XElement("Contact",
//    new XElement("Name", "Patrick Hines"),
//    new XElement("Phone", "206-555-0144"),
//    new XElement("Address",
//        new XElement("Street1", "123 Main St"),
//        new XElement("City", "Mercer Island"),
//        new XElement("State", "WA"),
//        new XElement("Postal", "68042")
//    )
//);


       
        public class DynamicXMLNode : DynamicObject
        {
            XElement node;
            public DynamicXMLNode(XElement node)
            {
                this.node = node;
            }
            public DynamicXMLNode()
            {
            }
            public DynamicXMLNode(String name)
            {
                node = new XElement(name);
            }
            public override bool TrySetMember(
                SetMemberBinder binder, object value)
            {
                XElement setNode = node.Element(binder.Name);
                if (setNode != null)
                    setNode.SetValue(value);
                else
                {
                    if (value.GetType() == typeof(DynamicXMLNode))
                        node.Add(new XElement(binder.Name));
                    else
                        node.Add(new XElement(binder.Name, value));
                }
                return true;
            }
            public override bool TryGetMember(
                GetMemberBinder binder, out object result)
            {
                XElement getNode = node.Element(binder.Name);
                if (getNode != null)
                {
                    result = new DynamicXMLNode(getNode);
                    return true;
                }
                else
                {
                    result = null;
                    return false;
                }
            }
        }
        
//Теперь дело за малым – если нужно свойство, можно его просто брать через точку:

//var xe = XElement.Parse(something);
//var dxn = new DynamicXmlNode(xe);
//var name = dxn.people.dmitri.name;



//        dynamic contact = new DynamicXMLNode("Contacts");
//contact.Name = "Patrick Hines";
//contact.Phone = "206-555-0144";
//contact.Address = new DynamicXMLNode();
//contact.Address.Street = "123 Main St";
//contact.Address.City = "Mercer Island";
//contact.Address.State = "WA";
//contact.Address.Postal = "68402";



    }
}
