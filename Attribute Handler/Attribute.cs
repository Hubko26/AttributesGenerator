using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attribute_Handler
{
    internal class Attribute : IGeneratable
    {
        public string AttributeName { get; set; }

        public string AttributeDataType { get; set; }

        public string APPEDIA_ATTRIBUTE { get; set; }

        public IEnumerable<string> ?FilesToUpdate { get; set; }

        public string ?DataElement { get; set; }

        public Attribute(string attributeName, string attributeDataType, string repo)
        {
            AttributeName = attributeName;
            AttributeDataType = attributeDataType;
            APPEDIA_ATTRIBUTE = repo + "\\src\\artifacts\\appedia_attribute.clas.abap";
        }

        void IGeneratable.GeneratedCodeAttribute()
        {
            var reader = new StringReader(APPEDIA_ATTRIBUTE);
            string input = reader.ReadToEnd();


            using (var writer = new StreamWriter(APPEDIA_ATTRIBUTE))
            {
                
            }
            throw new NotImplementedException();
        }
    }
}
