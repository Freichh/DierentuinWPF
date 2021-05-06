using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierentuinWPF.Models
{
    class Animal
    {

        public string Name { get; set; }
        public int Energy { get; set; } = 100;

        
        public static int Eat(int energy)
        {
            energy += 25;
            return energy;
        }

    }


}
