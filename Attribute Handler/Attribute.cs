using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attribute_Handler
{
    internal class Attribute : Generatable
    {
        public string AttributeName { get; set; }

        public string AttributeDataType { get; set; }

        public IEnumerable<string> ?FilesToUpdate { get; set; }

        public string ?DataElement { get; set; }

        public Attribute(string attributeName, string attributeDataType)
        {
            AttributeName = attributeName;
            AttributeDataType = attributeDataType;
        }

        void Generatable.GeneratedCodeAttribute()
        {
            throw new NotImplementedException();
        }
    }
}
