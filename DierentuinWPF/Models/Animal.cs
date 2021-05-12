using System;
using System.Collections.Generic;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace DierentuinWPF.Models
{
    // INotifyPropertyChanged toegevoegd aan Animal
    class Animal : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Energy { get; set; } = 100;

        public static int Eat(int energy)
        {
            energy += 25;
            return energy;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
