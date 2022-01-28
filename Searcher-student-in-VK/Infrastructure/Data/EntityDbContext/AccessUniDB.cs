using Microsoft.EntityFrameworkCore;
using Searcher_student_in_VK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Searcher_student_in_VK.Infrastructure.Data.EntityDbContext
{
    static public class AccessUniDB
    {

        static public void Save()
        {
            using UniversityDB db = new UniversityDB();
            db.SaveChanges();
        }

        static public void Add(University university)
        {

            using UniversityDB db = new UniversityDB();
            db.Universities.Add(university);
            db.SaveChanges();
            
        }

        static public void Remove(University university)
        {
            
            using (UniversityDB db = new UniversityDB())
            {

                db.Universities.Remove(university);
                db.SaveChanges();
            }
            
        }

        static public ObservableCollection<University> GetUniversities()
        {

            using UniversityDB db = new UniversityDB();
            ObservableCollection<University> list = new ObservableCollection<University> (db.Universities.Include(i=>i.Students));
            return list;
        }

        static public void Edit(int ind, string name)
        {
            using UniversityDB db = new UniversityDB();
            db.Universities.Load();
            db.Universities.Find(ind).Name = name;
            db.SaveChanges();
        }
    }
}
