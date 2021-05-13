using System;
using System.Collections.Generic;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace DierentuinWPF.Models
{
    // INotifyPropertyChanged toegevoegd aan Animal
    abstract class Animal : INotifyPropertyChanged
    {
        public Animal()
        {
            // waarom werkt energy = 100; ook?
            Energy = 100;
        }

        public string Name { get; set; }
        public int EatQuantity { get; set; }

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

        public virtual int Eat()
        {
            if (Energy < 100)
            {
                Energy += EatQuantity;
            }
            return Energy;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
