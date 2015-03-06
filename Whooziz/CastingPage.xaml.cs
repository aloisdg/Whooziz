using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

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
            string name = NavigationContext.QueryString["name"];
            string urlPoster = NavigationContext.QueryString["urlPoster"];   
        }

        private void CastingBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var actor = (CastingBox.SelectedItem as Actor);
            if (actor != null)
            {
                NavigationService.Navigate(new Uri("/CastingPage.xaml?name=" + actor.Name + "&urlPoster" + actor.UrlImages.First(), UriKind.Relative));
            }
        }
    }

    public class Actor
    {
        public string Name { get; set; }
        public List<string> UrlImages { get; set; }
    }
}