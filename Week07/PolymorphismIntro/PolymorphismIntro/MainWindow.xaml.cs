﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Animal> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();

            //make siome animals
            Frog frog = new Frog(4, "Bart", true, 1);
            Dog dog = new Dog("Labradoodle", 35, "Pax", 155582);
            Duck duck = new Duck(4, "Moo", 1587);
            Dog dog2 = new Dog("Red", 200, "Clifford", 1000);
            Duck duck2 = new Duck(5, "Daffy", 60);
            Frog frog2 = new Frog(3, "Jeremiah", true, 15);

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            Animals.Add(dog2);
            Animals.Add(duck2);
            Animals.Add(frog2);

            lvAnimals.ItemsSource = Animals;

        }


        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal a in Animals)
            {
                a.SayName();
            }
        }
    }
}
