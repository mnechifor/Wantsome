﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdoNetExamples
{
    public class Author
    {
        [XmlElement(ElementName = "FullName")]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
