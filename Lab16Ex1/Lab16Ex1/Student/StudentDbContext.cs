using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Creeati modelul, adaugati EF, Adaugati DB 
namespace Lab16Ex1.Student
{
    internal class StudentDbContext:DbContext
    {
        private const string DbUrl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ionut\source\repos\Lab16Ex1\Lab16Ex1\StudentsDb.mdf;Integrated Security=True";
        public DbSet<Student> Students { get; set; }
        public StudentDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder Builder)
        {
            Builder.UseSqlServer(DbUrl);
        }
    }
}
