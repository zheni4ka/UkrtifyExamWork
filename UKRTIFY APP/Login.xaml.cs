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
using System.Windows.Shapes;

namespace UKRTIFY_APP
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        UkrtifyDbContext context = new();
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tmp = context.Users;
            if (tmp.Where(x => x.Nickname == LoginInput.Text).First() != null) 
            {
                if(tmp.Where(x => x.Nickname == LoginInput.Text).First().Password == PasswordInput.Text)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.PlaylistView.ItemsSource = tmp.Where(x => x.Nickname == LoginInput.Text && x.Password == PasswordInput.Text).FirstOrDefault().Playlists;
                    mainWindow.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
