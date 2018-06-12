using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joonas_Praktika3
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string YearBorn { get; set; } = "";

        public override string ToString()
        {
            return Name;
        }
    }
}
