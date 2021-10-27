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
            List<Student> studs = new List<Student>();
            List<GroupVK> groups = new List<GroupVK>();

            

            for (int i = 0; i < 50; i++)
            {
                studs.Add(new Student(RandomString(random.Next(10))));

                //RandomString(random.Next(3, 10))
            }

            for (int i = 0; i < 5; i++)
            {
                groups.Add(new GroupVK(RandomString(random.Next(10))));
            }


            for (int i = 0; i < 10; i++)
            {
                unis.Add(new University(RandomString(random.Next(10))));
                unis[i].GroupsVK.AddRange(groups);
                unis[i].Students.AddRange(studs);
            }
            db.Universities.AddRange(unis);
            db.SaveChanges();
            Console.ReadKey();
        }
    }
}
