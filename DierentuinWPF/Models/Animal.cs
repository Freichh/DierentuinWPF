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
            // waarom werkt energy = 100; ook?
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
                this.NotifyPropertyChanged("Energy");
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

        // (Abstracte method volgens opdracht) Elk dier verbruikt zijn eigen UseQuantity
        public abstract int UseEnergy();


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
