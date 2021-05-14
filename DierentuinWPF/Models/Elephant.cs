using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierentuinWPF.Models
{
    // Sealed can't be inherited
    sealed class Elephant : Animal
    {
        public Elephant()
        {
            Name = "Elephant";
            EatQuantity = 50;
            UseQuantity = 5;
        }
    }
}
