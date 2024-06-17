using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Un student este caracterizat de
• Id (unic)
• Nume
• Prenume
• Varsta
• Specializare*/

namespace Lab16Ex1.Student
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Profile Profile { get; set; }
    }
}
