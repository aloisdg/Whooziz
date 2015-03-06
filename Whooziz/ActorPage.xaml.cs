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

namespace Whooziz
{
    public partial class ActorPage : PhoneApplicationPage
    {
        public ActorPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            NameBox.Text = NavigationContext.QueryString["name"];
            UrlPosterBox.Source = new BitmapImage(new Uri(NavigationContext.QueryString["urlPoster"], UriKind.Absolute));
            //UrlPosterBox.Source = new BitmapImage(new Uri("http://4.bp.blogspot.com/_TKvTt6_QQP4/S9ADHTrM1mI/AAAAAAAAFQ0/YbFqbDqmFKU/s1600/hr_Iron_Man_poster.jpg", UriKind.Absolute));
        }
    }
}