using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Searcher_student_in_VK.Model.Entity;

namespace Searcher_student_in_VK.Model
{
    public class Student: EntityWithImage
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        //Направление обучения
        public string Group { get; set; }
        public string URL { get; set; }
        public string Probability { get; set; }

        public List<Student> Friends { get; set; }
        public List<Student> ConfirmedFriends { get; set; }

        public Student(string name, string photoPath = standardImagePath) :base(name, photoPath)
        {
        }
        
        private Student(string name) : base(name)
        {
        }
    }
}
