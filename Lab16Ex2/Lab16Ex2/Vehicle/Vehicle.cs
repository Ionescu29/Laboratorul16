using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Ex2.Vehicle
{
    /* Un autovehicul este caracterizat de urmatoarele proprietati
        • Id:int
        • Nume :string
        • Serie de sasiu: string
        • An de fabricatie :int
        • Producator:string*/
    internal class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChassisSeries { get; set; }
        public int Year { get; set; }
        public  Product Product { get; set; }
    }
}
