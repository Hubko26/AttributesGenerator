﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Handler
{
    public interface Generatable
    {
        public static readonly string[] DataTypes = { "string", "i", "char30" };
        void GeneratedCodeAttribute();
    }
}
