using Searcher_student_in_VK.Model;
using Searcher_student_in_VK.Infrastructure;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Searcher_student_in_VK.Infrastructure.Data.EntityDbContext;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Searcher_student_in_VK_Console
{


    class Program
    {




        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        static void Main(string[] args)
        {
            UniversityDB db = new UniversityDB();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            List<University> unis = new List<University>();

            for (int i = 0; i < 10; i++)
            {
                unis.Add(new University("University " + RandomString(random.Next(3, 10))));

                for (int j = 0; j < 50; j++)
                {
                    unis[i].Students.Add(new Student("Student "+RandomString(random.Next(3, 10))));

                }

                for (int j = 0; j < 5; j++)
                {
                    unis[i].GroupsVK.Add(new GroupVK("GroupsVK " + RandomString(random.Next(3, 10))));
                }

            }
            db.Universities.AddRange(unis);
            db.SaveChanges();
            Console.ReadKey();
        }
    }
}
