using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TortugaS_Reznichenko.BD;

namespace TortugaS_Reznichenko.Classes
{
    class Basket
    {
        public static List<Dish> dishes = new List<Dish>();
    }

    public interface MenuInterface 
    {
        void ChangeDishCount(int count);
    }

}
