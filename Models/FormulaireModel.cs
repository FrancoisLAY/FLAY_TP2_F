using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;


namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string sex { get; set; }
        public string adresse { get; set; }
        public int cp { get; set; }
        public string ville { get; set; }
        public string email { get; set; }
        public DateTime debF { get; set; }
        public string formation { get; set; }
        public string avisC { get; set; }
        public string avisO { get; set; }
    }
}

