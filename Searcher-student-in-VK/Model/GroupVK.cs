using Searcher_student_in_VK.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Searcher_student_in_VK.Model
{
    public class GroupVK:NamedEntity
    {
        string URL { get; set; }

        List<Student> Users { get; set; }
        Image Photo { get; set; }

        public GroupVK(string name) : base(name){ }
    }
}
