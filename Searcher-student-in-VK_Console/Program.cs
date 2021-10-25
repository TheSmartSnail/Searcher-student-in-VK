using Searcher_student_in_VK.Model;
using Searcher_student_in_VK.Infrastructure;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Searcher_student_in_VK.Infrastructure.Data.EntityDbContext;
using System.IO;

namespace Searcher_student_in_VK_Console
{

    

    
    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            UniversityDB db = new UniversityDB();
            //var db1 = new List<University>();
            //db1.Add(new University ("SMTU"));
            //db1.Add(new University("GNNN"));
            //db1.Add(new University("MTU"));
            //db1.Add(new University("VSHE"));
            //db1.Add(new University("REP"));

            //db1[1].Students.Add(new Student("Leha"));
            //db1[1].Students.Add(new Student("Pavel"));
            //db1[2].Students.Add(new Student("Hren"));
            //db.Universities.AddRange(db1);
            //db.SaveChanges();
            //db.Universities.AddRange(unis);
            Console.ReadKey();
        }
    }
}
