using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DigiLabelFormats.Classes
{
    public class clsXMLReader
    {
        public string XML_FileName { get; set; }
        public string XML_SelectElement { get; set; }
        public string XML_WhereElement { get; set; }
        public string XML_WhereEquals { get; set; }
        public string XML_OrderBy { get; set; }

        public XElement xelement { get; set; }


        public clsXMLReader(string xml_FileName, string xml_WhereElement, string xml_WhereEquals, string xml_SelectElement)
        {
            this.XML_FileName = xml_FileName;
            this.XML_WhereElement = xml_WhereElement;
            this.XML_WhereEquals = xml_WhereEquals;
            this.XML_SelectElement = xml_SelectElement;
            createXElement();
        }

        public clsXMLReader(string xml_FileName, string xml_Orderby)
        {
            this.XML_FileName = xml_FileName;
            this.XML_OrderBy = xml_Orderby;
            createXElement();
        }

        private void createXElement()
        {

            this.xelement = XElement.Load(Directory.GetCurrentDirectory() + @"\XML\" + XML_FileName + ".xml");


        }
        public string getSingleWhere()
        {
            var singleValue = (from _element in this.xelement.Elements()
                               where (string)_element.Element(this.XML_WhereElement).Value == this.XML_WhereEquals
                               select _element.Element(this.XML_SelectElement)).Single().Value;

            return singleValue;

        }


        public IOrderedEnumerable<XElement> getOrderedList()
        {

            var elements = from field in this.xelement.Elements()
                           orderby int.Parse(field.Element(this.XML_OrderBy).Value)
                           select field;


            return elements;

        }

       

       
    }
}
