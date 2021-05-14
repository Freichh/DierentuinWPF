using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierentuinWPF.Models
{
    // Sealed can't be inherited
    sealed class Lion : Animal
    {
        public Lion()
        {
            Name = "Lion";
            EatQuantity = 25;
            UseQuantity = 10;
        }
    }
}
