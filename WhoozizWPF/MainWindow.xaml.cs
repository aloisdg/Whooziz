using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.TMDb;
using System.Text;
using System.Threading;
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

namespace WhoozizWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var cancelToken = new CancellationTokenSource();
            var token = cancelToken.Token;
            // Create a task and pass the cancellation token
            var t1 = Task.Factory.StartNew(() => Sample(token), token);

            //token.Register(() => cancelNotification());

            //this stops the Task:
            //cancelToken.Cancel(false); //false indicates that no exceptions will be thrown.

        }

        //private void cancelNotification()
        //{
        //    Debug.WriteLine("Cancellation request made!!");
        //}

        List<ImageItem> l = new List<ImageItem>();

        private async void Sample(CancellationToken cancellationToken)
        {
            using (var client = new ServiceClient("apikey"))
            {
                for (int i = 1, count = 1000; i <= count; i++)
                {
                    var movies = await client.Movies.GetTopRatedAsync(null, i, cancellationToken);
                    count = movies.PageCount; // keep track of the actual page count

                    foreach (Movie m in movies.Results)
                    {
                        var movie = await client.Movies.GetAsync(m.Id, null, true, cancellationToken);

                        var personIds = movie.Credits.Cast.Select(s => s.Id);
                            //.Union(movie.Credits.Crew.Select(s => s.Id));

                        foreach (var id in personIds)
                        {
                            var person = await client.People.GetAsync(id, true, cancellationToken);

                            var a = person.Images.Results;
                            if (a.Any())
                            {
                                this.Dispatcher.Invoke((Action)(() =>
                                    ImagesBox.Items.Add(new ImageItem
                                    {
                                        Source = "http://image.tmdb.org/t/p/w342" + a.First().FilePath
                                    })));
                                
                            }

                            //foreach (var img in person.Images.Results)
                            //{
                            //    string filepath = System.IO.Path.Combine("People", img.FilePath.TrimStart('/'));
                            //    //await DownloadImage(img.FilePath, filepath, cancellationToken);

                            //    this.Dispatcher.Invoke((Action)(() =>
                            //        ImagesBox.Items.Add(new ImageItem
                            //        {
                            //            Source = "http://image.tmdb.org/t/p/w342" + img.FilePath
                            //        })));
                            //}
                        }
                    }
                }
            }
        }

        static async Task DownloadImage(string filename, string localpath, CancellationToken cancellationToken)
        {
            if (!File.Exists(localpath))
            {
                string folder = System.IO.Path.GetDirectoryName(localpath);
                Directory.CreateDirectory(folder);

                var storage = new StorageClient();
                using (var fileStream = new FileStream(localpath, FileMode.Create,
                    FileAccess.Write, FileShare.None, short.MaxValue, true))
                {
                    try { await storage.DownloadAsync(filename, fileStream, cancellationToken); }
                    catch (Exception ex) { System.Diagnostics.Trace.TraceError(ex.ToString()); }
                }
            }
        }
    }
}
