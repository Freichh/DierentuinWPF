using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Drawing;

namespace DierentuinWPF.Models
{
    class Animal
    {

        public string Name { get; set; }
        public int Energy { get; set; } = 100;

        public Animal()
        {

        }
        
        public void Eat()
        {
            this.Energy += 25;
        }
    }


}
