using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlanetaryApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public class Planet
        {
            public string Name { get; set; }
            public string Distance { get; set; }
        }

        public MainPage()
        {
            InitializeComponent();

            // create and populate a list of planetary names
            var planets = new ObservableCollection<Planet>()
            {
                new Planet
                {
                    Name = "Mercury",
                    Distance = "Distance from Earth: 77 million kilometers"
                },
                new Planet
                {
                    Name = "Venus",
                    Distance = "Distance from Earth: 261 million kilometers"
                },
                new Planet
                {
                    Name = "Earth",
                    Distance = "Distance from Sun: 149.6 million kilometers"
                },
                new Planet
                {
                    Name = "Mars",
                    Distance = "Distance from Earth: 54.6 million kilometers"
                },
                new Planet
                {
                    Name = "Saturn",
                    Distance = "Distance from Eearth: 1.2 billion kilometers"
                },
                new Planet
                {
                    Name = "Uranus",
                    Distance = "Distance from Earth: 2.6 billion kilometers"
                },
                new Planet
                {
                    Name = "Neptune",
                    Distance = "Distance from Earth: 4.3 billion kilometers"
                }
            };

            planetsListView.ItemsSource = planets;
        }
    }
}
