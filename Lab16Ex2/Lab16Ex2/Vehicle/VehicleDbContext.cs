using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Ex2.Vehicle
//  Creeati modelul, adaugati EF, Adaugati DB 
{
    internal class VehicleDbContext:DbContext
    {
        private const string DbUrl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ionut\source\repos\Lab16Ex1\Lab16Ex1\StudentsDb.mdf;Integrated Security=True";
        public DbSet<Vehicle> Vehicles { get; set; }
        public VehicleDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder Builder)
        {
            Builder.UseSqlServer(DbUrl);
        }
    }

}
