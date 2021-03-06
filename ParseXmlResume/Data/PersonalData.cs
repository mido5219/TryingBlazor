﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParseXmlResume.Data
{
    public class PersonalData
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("BD")]
        public string Birthdate { get; set; }
        [XmlElement("AY")]
        public string AcademicYear { get; set; }
        [XmlElement("PN")]
        public string Phonenumber { get; set; }
        [XmlElement("skills")]
        public string Skills { get; set; }
    }
}
