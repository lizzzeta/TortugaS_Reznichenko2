using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TortugaS_Reznichenko.BD;

namespace TortugaS_Reznichenko.Classes
{
    class ClassEntities
    {
        public static TortugaS_FinishEntities context { get; set; } = new TortugaS_FinishEntities();
    }
}
