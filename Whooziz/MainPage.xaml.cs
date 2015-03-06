using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Whooziz.Resources;

namespace Whooziz
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            List<Film> films = new List<Film>();
            for (int i = 0; i < 5; i++)
            {
                films.Add(new Film
                {
                    UrlPoster = "http://www.impawards.com/2001/posters/lord_of_the_rings_the_fellowship_of_the_ring_ver4.jpg",
                    Name = "Le Seigneur des Anneaux 1"
                });
                films.Add(new Film
                {
                    UrlPoster = "https://www.movieposter.com/posters/archive/main/70/MPW-35483",
                    Name = "Le Seigneur des Anneaux 2"
                });
                films.Add(new Film
                {
                    UrlPoster = "https://www.movieposter.com/posters/archive/main/16/MPW-8295",
                    Name = "Le Seigneur des Anneaux 3"
                });
            }
            FilmsBox.ItemsSource = films;
        }

        private void FilmsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var film = (FilmsBox.SelectedItem as Film);
            if (film != null)
            {
                NavigationService.Navigate(new Uri("/CastingPage.xaml?name=" + film.Name + "&urlPoster=" + film.UrlPoster, UriKind.Relative));
            }
        }
    }

    public class Film
    {
        public string UrlPoster { get; set; }
        public string Name { get; set; }
    }
}