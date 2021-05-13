using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DierentuinWPF.Models;

namespace DierentuinWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Pseudocode
        /* Deel 1
        1. Maak base class Animal, inh Monkey, Lion, Elephant
        2. De class heeft ook een methode Eat die de energie van een dier doet toenemen met 25
        3. Maak de GUI
        4. Is, as, OfType<T> experimenten/uitzoeken
        * Deel 2
        5. Methods om dieren te voeren
        6. Dieren kunnen toevoegen aan main veld met knoppen
        * Deel 3
        7. Timer 
        8. Energiebalk
        9. Sterfte/verwijderen uit verzameling
        */
        #endregion

        // Ongeveer zelfde als een List, maar deze update de UI realtime i.c.m. INotifyPropertyChanged
        ObservableCollection<Animal> zoo = new ObservableCollection<Animal>();

        public MainWindow()
        {
            InitializeComponent();

            
            /*
            // Testdieren toevoegen aan ObservableCollection zoo
            zoo.Add(new Monkey());
            zoo.Add(new Lion());
            zoo.Add(new Elephant());
            */

            // Maak zoo de ItemsSource voor ItemsControl activeAnimals
            activeAnimals.ItemsSource = zoo;
        }

        
        private void AddMonkeyButton_Click(object sender, RoutedEventArgs e)
        {
            zoo.Add(new Monkey());
        }

        private void AddLionButton_Click(object sender, RoutedEventArgs e)
        {
            zoo.Add(new Lion());
        }

        private void AddElephantButton_Click(object sender, RoutedEventArgs e)
        {
            zoo.Add(new Elephant());
        }
    }
}
