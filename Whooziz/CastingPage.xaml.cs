using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using GestureEventArgs = System.Windows.Input.GestureEventArgs;

namespace Whooziz
{
    public partial class CastingPage : PhoneApplicationPage
    {
        public CastingPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            NameBox.Text = NavigationContext.QueryString["name"];
            UrlPosterBox.Source = new BitmapImage(new Uri(NavigationContext.QueryString["urlPoster"], UriKind.Absolute));
            //UrlPosterBox.Source = new BitmapImage(new Uri("http://4.bp.blogspot.com/_TKvTt6_QQP4/S9ADHTrM1mI/AAAAAAAAFQ0/YbFqbDqmFKU/s1600/hr_Iron_Man_poster.jpg", UriKind.Absolute));

            Init();
        }

        private void Init()
        {
            List<Actor> actors = new List<Actor>();
            actors.Add(new Actor
            {
                Name = "Orlando Bloom",
                UrlImages = new List<UrlImage>()
                {
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                                        new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                                        new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                                        new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                                        new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                                        new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"}
                }
            });
            actors.Add(new Actor
            {
                Name = "Viggo Mortensen",
                UrlImages = new List<UrlImage>()
                {
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"}
                }
            });
            actors.Add(new Actor
            {
                Name = "John Rhys-Davies",
                UrlImages = new List<UrlImage>()
                {
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"}
                }
            });
            actors.Add(new Actor
            {
                Name = "Orlando Bloom",
                UrlImages = new List<UrlImage>()
                {
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Orlando_Bloom_Cannes_2013.jpg/220px-Orlando_Bloom_Cannes_2013.jpg"}
                }
            });
            actors.Add(new Actor
            {
                Name = "Viggo Mortensen",
                UrlImages = new List<UrlImage>()
                {
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Viggo_Mortensen_2012.jpg/220px-Viggo_Mortensen_2012.jpg"}
                }
            });
            actors.Add(new Actor
            {
                Name = "John Rhys-Davies",
                UrlImages = new List<UrlImage>()
                {
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"},
                    new UrlImage { Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/John_Rhys-Davies_byVetulani.JPG/220px-John_Rhys-Davies_byVetulani.JPG"}
                }
            });

            CastingBox.ItemsSource = actors;

        }

        private void CastingBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var actor = (CastingBox.SelectedItem as Actor);
            if (actor != null)
            {
                NavigationService.Navigate(new Uri("/ActorPage.xaml?name=" + actor.Name + "&urlPoster=" + actor.UrlImages.First().Source, UriKind.Relative));
            }
        }

    }

    public class Actor
    {
        public string Name { get; set; }
        public List<UrlImage> UrlImages { get; set; }
    }

    public class UrlImage
    {
        public string Source { get; set; }
    }
}