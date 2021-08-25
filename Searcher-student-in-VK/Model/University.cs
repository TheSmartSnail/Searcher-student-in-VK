using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Searcher_student_in_VK.Infrastructure;

namespace Searcher_student_in_VK.Model
{
    [Serializable]
    public class University
    {
        private string name;

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public University(string name)
        {
            this.name = name;
        }

        public University()
        {

        }

        private void Save()
        {
            BinarySaver.Save(this, Name);
        }
    }
}
