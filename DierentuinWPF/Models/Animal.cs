using System;
using System.Collections.Generic;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace DierentuinWPF.Models
{
   
    abstract class Animal : INotifyPropertyChanged
    {
        public Animal()
        {
            Energy = 100;
        }

        public string Name { get; set; }
        public int EatQuantity { get; set; }
        public int UseQuantity { get; set; }

        private int energy;
        public int Energy
        {
            get { return energy; }
            set 
            { 
                energy = value;
                NotifyPropertyChanged("Energy");
            }
        }

        // Elk dier eet zijn eigen EatQuantity
        public int Eat()
        {
            if (Energy < 100)
            {
                Energy += EatQuantity;
            }
            if (Energy > 100)
            {
                Energy = 100;
            }
            return Energy;
        }

        // Elk dier verbruikt zijn eigen UseQuantity
        public int UseEnergy()
        {
            Energy -= UseQuantity;
            return Energy;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            // ? achter methode kijkt of niet null is, dan roept hij met invoke methode voor het ? aan
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
