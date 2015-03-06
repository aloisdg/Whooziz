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
            for (int i = 0; i < 15; i++)
            {
                films.Add(new Film
                {
                    UrlPoster = "http://4.bp.blogspot.com/_TKvTt6_QQP4/S9ADHTrM1mI/AAAAAAAAFQ0/YbFqbDqmFKU/s1600/hr_Iron_Man_poster.jpg",
                    Name = "Iron Man 2"
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