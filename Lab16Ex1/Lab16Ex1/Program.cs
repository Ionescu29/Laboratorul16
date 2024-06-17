// See https://aka.ms/new-console-template for more information
using Lab16Ex1.Student;
using System.Net.Cache;

//Creeati in clasa “main” o functie “Seed” care va popula DB-ul

//Afisati toti studentii din DB in ordine alfabetica
using var dbContext = new StudentDbContext();
var s = dbContext.Students.OrderBy(e => e.Name);
dbContext.SaveChanges();
Console.ReadLine();

// Afisati cel mai tanar student de la constructii cu varsta de peste 20 de ani
using var dbContext = new StudentDbContext();
var s = dbContext.Students.FirstOrDefault(e => e.Age && Age>20);
dbContext.SaveChanges();
Console.ReadLine();
static void AddStudent()
{
    Console.WriteLine("Name");
    var name = Console.ReadLine();
    Console.WriteLine("FirstName");
    var firstname = Console.ReadLine();
    Console.WriteLine("Age");
    var age =int.Parse(Console.ReadLine());
    Console.WriteLine("Profile");
    var profile = Enum.Parse<Profile>(Console.ReadLine());

    using var dbContext = new StudentDbContext();
    var e= new Student
    {
        Name = name,
        FirstName = firstname,
        Age = age,
        Profile = profile,
    };
    dbContext.Students.Add(e);
    dbContext.SaveChanges();
}
static void Seed()
{
    var dbContext = new StudentDbContext();

    dbContext.Students.Add(new Student { Name = "Chiriac", FirstName = "Cosmin", Age = 25, Profile = Profile.Info });
    dbContext.Students.Add(new Student { Name = "Briceag", FirstName = "Leontin", Age = 30, Profile = Profile.UrbanEngineer });
    dbContext.Students.Add(new Student { Name = "Hapca", FirstName = "Silviu", Age = 18, Profile = Profile.Literature });
    dbContext.Students.Add(new Student { Name = "Barbu", FirstName = "Marin", Age = 28, Profile = Profile.Info });
    dbContext.Students.Add(new Student { Name = "Voiculescu", FirstName = "Dan", Age = 35, Profile = Profile.Literature });
    dbContext.Students.Add(new Student { Name = "Nistor", FirstName = "Sorin", Age = 20, Profile = Profile.UrbanEngineer });
    
    dbContext.SaveChanges();
}
