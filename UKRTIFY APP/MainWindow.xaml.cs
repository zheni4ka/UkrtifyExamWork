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

namespace UKRTIFY_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel ViewModel { get; set; } = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModel;
        }
    }

    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public UkrtifyDbContext db;
        public IEnumerable<Artist> Artists => db.Artists.ToList();
        
    }
}
