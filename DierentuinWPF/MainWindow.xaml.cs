using DierentuinWPF.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace DierentuinWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();



            #region To do
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


            AddAnimal
            - Per soort aan list toevoegen
                - ID / Naam / energyvalue
            */
            #endregion
        }

        List<Animal> ZooList = new List<Animal>();



        private void MakeUnit()
        {
            StackPanel Unit = new StackPanel();

            Label AnimalName = new Label();
            AnimalName.Content = "Name";
            AnimalName.HorizontalAlignment = HorizontalAlignment.Center;
            Unit.Children.Add(AnimalName);

            BitmapImage Bmp = new BitmapImage();
            Bmp.BeginInit();
            Bmp.UriSource = new System.Uri(@"C:\Users\rsmar\source\repos\DierentuinWPF\DierentuinWPF\Resources\Monkey.jpg");
            Bmp.EndInit();
            Image Animal = new Image();
            Animal.Width = 50;
            Animal.Height = 50;
            Animal.Source = Bmp;
            Unit.Children.Add(Animal);

            ProgressBar Lifebar = new ProgressBar();
            Lifebar.Width = 50;
            Lifebar.Height = 10;
            Lifebar.Maximum = 100;
            Lifebar.Value = 100;
            Unit.Children.Add(Lifebar);

            DispatcherTimer test = new DispatcherTimer();
            test.Tick += new EventHandler(test_Tick);
            test.Interval = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(TxtBoxTime.Text));
            test.Start();
            DierentuinWrapPanel.Children.Add(Unit);


            void test_Tick(object sender, EventArgs e)
            {
                // Updating the Label which displays the current second
                Lifebar.Value -= 10;
                if (Lifebar.Value <= 0)
                {
                    DierentuinWrapPanel.Children.Remove(Unit);
                }
            }
        }

        private void AddMonkeyButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanel Unit = new StackPanel();

            Label testName = new Label();
            testName.Content = "Naam hier";

            Label testPicture = new Label();
            testPicture.Content = "Plaatje hier";

            Label testEnergy = new Label();
            testEnergy.Content = "100";

            Unit.Children.Add(testName);
            Unit.Children.Add(testPicture);
            Unit.Children.Add(testEnergy);

            DierentuinWrapPanel.Children.Add(Unit);
        }



        private void AddLionButton_Click(object sender, RoutedEventArgs e)
        {
            ControlTemplate pb = new ControlTemplate();
            DierentuinWrapPanel.Children.Add(pb);
        }

        private void AddElephantButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FeedAllButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FeedMonkeyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FeedLionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FeedElephantButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
