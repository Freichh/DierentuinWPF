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
using System.Windows.Threading;
using System.Diagnostics;

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
        // readonly = referentie mag niet aangepast worden (niet overschrijven)
        readonly ObservableCollection<Animal> zoo = new();

        // Global timer
        readonly DispatcherTimer timer = new();
        const double initialIntervalMilliseconds = 500;

        public MainWindow()
        {
            InitializeComponent();

            // Maak zoo de ItemsSource voor ItemsControl activeAnimals
            activeAnimals.ItemsSource = zoo;


            // Default interval = 500ms
            timer.Interval = TimeSpan.FromMilliseconds(initialIntervalMilliseconds);
            timer.Tick += timer_Tick;
            timer.Start();

            void timer_Tick(object sender, EventArgs e)
            {
                // Als lijst leeg dan uit methode gaan
                if (zoo.Count < 1)
                {
                    return;
                }

                // Waarom geen error met List<T>.Reverse? Indexes blijven hetzelfde met reverse?
                foreach (Animal animal in zoo.Reverse<Animal>())
                {
                    animal.UseEnergy();

                    if (animal.Energy <= 0)
                    {
                        zoo.Remove(animal);
                    }
                }

                /*
                // Kopie maken van originele lijst, Kopie lijst loopen, Uit originele lijst dieren verwijderen
                var copyZoo = zoo.ToList();

                // foreach stelt van te voren al vast hoe vaak hij loopt.
                // Weghalen tijdens loopen geeft crash, want komt niet meer overeen met wat het was
                foreach (var animal in copyZoo)
                {
                    animal.UseEnergy();

                    if (animal.Energy <= 0)
                    {
                        zoo.Remove(animal);
                    }
                }
                // Overschrijf lijst met lijst weggehaalde dieren
                // Overschrijven van lijst werkt niet in dit geval (misschien met INotifyPropertyChanged
                //zoo = new ObservableCollection<Animal>(copyZoo);
                */
            }


        }

        #region Dieren toevoegen buttons
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
        #endregion

        // sender en RoutedEventArgs uitzoeken, generiek instantie creeren

        #region Dieren voeren buttons
        private void FeedMonkeyButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var animal in zoo)
            {
                if (animal is Monkey)
                {
                    animal.Eat();
                }
            }
        }
        private void FeedLionButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var animal in zoo)
            {
                if (animal is Lion)
                {
                    animal.Eat();
                }
            }
        }

        private void FeedElephantButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var animal in zoo)
            {
                if (animal is Elephant)
                {
                    animal.Eat();
                }
            }
        }

        private void FeedAllButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var animal in zoo)
            {
                animal.Eat();
            }
        }



        #endregion

        // Update interval van lopende timer
        private void IntervalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //double intervalMilliseconds = IntervalSlider.Value;
            timer.Interval = TimeSpan.FromMilliseconds(IntervalSlider.Value);
        }

        // Reset all to default values and clear the ObservableCollection
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            zoo.Clear();
            IntervalSlider.Value = initialIntervalMilliseconds;
            timer.Interval = TimeSpan.FromMilliseconds(initialIntervalMilliseconds);
        }
    }
}
