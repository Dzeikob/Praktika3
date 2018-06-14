using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joonas_Praktika3
{
    public class Toode
    {
        public int TooteID { get; set; }
        public string TooteGrupp { get; set; }
        public string Tootja { get; set; }
        public string TooteKirjeldus { get; set; }
        public string Hind { get; set; }

        public override string ToString()
        {
            return TooteID.ToString();
        }
    }
}
