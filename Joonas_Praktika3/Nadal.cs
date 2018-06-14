using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joonas_Praktika3
{
    public class Nadal
    {
        public int NadalNumber { get; set; }
        public List<Toode> Tooted = new List<Toode>();

        public void AddToode(Toode toode)
        {
            Tooted.Add(toode);
        }
        public override string ToString()
        {
            return NadalNumber.ToString();
        }
    }
}
