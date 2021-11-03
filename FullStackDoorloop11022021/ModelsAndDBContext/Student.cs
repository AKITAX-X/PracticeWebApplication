using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsAndDBContext
{
    public class Student
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public int Studiejaar { get; set; }
        public string Woonplaats { get; set; }
    }
}
