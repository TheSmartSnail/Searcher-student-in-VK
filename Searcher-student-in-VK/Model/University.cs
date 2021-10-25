using System;
using System.Collections.Generic;
using System.Text;
using Searcher_student_in_VK.Model.Entity;

namespace Searcher_student_in_VK.Model
{
    public class University : NamedEntity 
    { 
        public List<GroupVK> GroupsVK { get; set; }
        public List<Student> Students { get; set; }
        public University(string Name):base(Name)
        {
            GroupsVK = new List<GroupVK>();
            Students = new List<Student>();
        }
    }
}
