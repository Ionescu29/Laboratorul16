// See https://aka.ms/new-console-template for more information
using Lab16Ex2.Vehicle;
using static System.Runtime.InteropServices.JavaScript.JSType;
//Creeati o functie in care afisati toate autovehiculele in ordine descrescatoare a anului de fabricatie
using var dbContext = new VehicleDbContext();
var s = dbContext.Vehicles.FirstOrDefault(e => e.Year);
dbContext.SaveChanges();
Console.ReadLine();
// Creeati o functie care adauga un autovehicul la baza de date.
//Functia va primi ca parametri numele, seria de sasiu, anul de fabricatie si producatorul, si va returna id-ul entitatii nou creeate.
static void AddVehicle()
{
    Console.WriteLine("Name");
    var name = Console.ReadLine();
    Console.WriteLine("ChassisSeries");
    var chassisseries = Console.ReadLine();
    Console.WriteLine("Year");
    var year = int.Parse(Console.ReadLine());
    Console.WriteLine("Product");
    var product = Enum.Parse<Product>(Console.ReadLine());

    using var dbContext = new Vehicle();
    var e = new Vehicle
    {
        Name = name,
        ChassisSeries = chassisseries,
        Year = year,
        Product = product,
    };
    dbContext.Vehicle.Add(e);
    dbContext.SaveChanges();
}

// Creeati in clasa “main” o functie “Seed” care va popula DB-ul
static void Seed()
{   
    var dbContext = new VehicleDbContext()

    dbContext.Vehicle.Add(new Vehicle { Name = "Avensis", ChassisSeries = "UU1403343", Year = 2016, Product.Toyota });
    dbContext.Vehicle.Add(new Vehicle { Name = "Golf", ChassisSeries = "UU148956", Year = 2010, Product.Wolkswagen });
    dbContext.Vehicle.Add(new Vehicle { Name = "XC60", ChassisSeries = "UU1407896", Year = 2018, Product.Volvo });
    dbContext.Vehicle.Add(new Vehicle { Name = "Camry", ChassisSeries = "UU1405623", Year = 2012, Product.Toyota });
    dbContext.Vehicle.Add(new Vehicle { Name = "PassatCC", ChassisSeries = "UU1406879", Year = 2020, Product.Wolkswagen });
    dbContext.Vehicle.Add(new Vehicle { Name = "V10", ChassisSeries = "UU1405894", Year = 2021, Product.Volvo });

    dbContext.SaveChanges();
}
