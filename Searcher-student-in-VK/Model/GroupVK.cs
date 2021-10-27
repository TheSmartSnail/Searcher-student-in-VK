using Searcher_student_in_VK.Model.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Searcher_student_in_VK.Model
{
    public class GroupVK:EntityWithImage
    {
        public string URL { get; set; }
        
        List<Student> Users { get; set; }
        
        
        public GroupVK(string name, string photoPath = standardImagePath) :base(name, photoPath)
        {
            
        }

        private GroupVK(string name) : base(name)
        {

        }
    }
}
