using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Searcher_student_in_VK.Model.Entity;

namespace Searcher_student_in_VK.Model
{
    public class Student:NamedEntity
    {
        string FirstName { get; set; }
        string SecondName { get; set; }
        string Group { get; set; }
        string URL { get; set; }
        string Probability { get; set; }

        List<Student> Friends { get; set; }
        List<Student> ConfirmedFriends { get; set; }
        Image Photo { get; set; }
        public Student(string name):base(name)
        {
        }
    }
}
