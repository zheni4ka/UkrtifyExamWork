using PropertyChanged;
using Spotify;
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
using Spotify.Interfaces;
using Spotify.Repositories;

namespace UKRTIFY_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IUoW uow = new UnitOfWork();

        public MainWindow()
        {
            InitializeComponent();
            tableView.ItemsSource = uow.ArtistRepo.Get(includeProperties: "Country,Producer").Select(x => new
            {
                x.Nickname,
                Producer = x.Producer.Name,
                Country = x.Country.Name,
                x.OverallRating
            });
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchBox.Text == "")
            {
                tableView.ItemsSource = uow.ArtistRepo.Get(includeProperties: "Country,Producer").Select(x => new
                {
                    x.Nickname,
                    Producer = x.Producer.Name,
                    Country = x.Country.Name,
                    x.OverallRating
                });
            }
            else
            {
                tableView.ItemsSource = uow.ArtistRepo.Get(includeProperties: "Country,Producer").Select(x => new
                {
                    x.Nickname,
                    Producer = x.Producer.Name,
                    Country = x.Country.Name,
                    x.OverallRating
                }).Where(x => x.Nickname.StartsWith(SearchBox.Text));
            }
        }
    }

    
}
