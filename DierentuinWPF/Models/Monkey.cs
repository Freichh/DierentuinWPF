using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierentuinWPF.Models
{
    // Sealed can't be inherited
    sealed class Monkey : Animal
    {
        public Monkey()
        {
            Energy = 60;
            Name = "Monkey";
            EatQuantity = 10;
            UseQuantity = 2;
        }
    }
}
