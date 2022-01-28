using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Searcher_student_in_VK.Model;
using Searcher_student_in_VK.Model.Entity;

namespace Searcher_student_in_VK.Infrastructure.Data.EntityDbContext
{
    public class UniversityDB : DbContext
    {
        private readonly StreamWriter logStream = new StreamWriter("mylog.txt", true);
        private readonly string connectionString = @"Server = (localdb)\MSSQLLocalDB;Initial Catalog=SSVK; Integrated Security = True";
        //Набор объектов в БД
        public DbSet<University> Universities { get; set; }


        public UniversityDB(): base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.LogTo(logStream.WriteLine);
        }



        public override void Dispose()
        {
            base.Dispose();
            logStream.Dispose();
        }

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }

        

    }
}
