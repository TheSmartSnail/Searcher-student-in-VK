using System;
using System.Collections.Generic;
using System.Text;
using Searcher_student_in_VK.Model.Entity;

namespace Searcher_student_in_VK.Model
{
    public class Student:NamedEntity
    {
        public Student(string name)
        {
            Name = name;
        }
    }
}
