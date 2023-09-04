using Spotify.Repositories;
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
using System.Windows.Shapes;

namespace UKRTIFY_APP
{
    /// <summary>
    /// Interaction logic for AddPlaylistMenu.xaml
    /// </summary>
    public partial class AddPlaylistMenu : Window
    {
        IUoW un = new UnitOfWork();
        public AddPlaylistMenu()
        {
            InitializeComponent();

            CategoriesItems.ItemsSource = un.CategoryRepo.Get().Select(x => x.Name);
        }
    }
}
