using System;
using System.Collections.Generic;
using System.Text;

namespace Searcher_student_in_VK.Model.Entity
{
    public abstract class NamedEntity :Entity
    {
        public string Name { get; set; }

        protected NamedEntity(string Name)
        {
            this.Name = Name;
        }

    }
}
