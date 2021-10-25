using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Searcher_student_in_VK.Infrastructure;
using Searcher_student_in_VK.Model.Entity;

namespace Searcher_student_in_VK.Model
{
    public class University : NamedEntity 
    { 
        public List<Student> Students { get; set; }
        public University(string Name)
        {
            this.Name = Name;
            Students = new List<Student>();
        }
    }
}
