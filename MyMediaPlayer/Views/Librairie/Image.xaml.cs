using MyMediaPlayer.Modele;
using MyMediaPlayer.Modeles.lib;
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

namespace MyMediaPlayer.Views.librairie
{
    /// <summary>
    /// Logique d'interaction pour image.xaml
    /// </summary>
    public partial class image : UserControl
    {
        public image()
        {
            InitializeComponent();
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            String extension = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png";
            this.DataContext = new MyMediaPlayer.ViewModels.lib.LibViewModel(path, extension);
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (myListBox.SelectedItem != null)
            {
                FileObject tmp = (FileObject)myListBox.SelectedItem;
                String path = tmp.Location + "\\" + tmp.FileName;
                MyMedia.Instance().Source = new Uri(path);
                NavigationCommands.GoToPage.Execute("/Views/HomeView.xaml", null);
            }
        }
    }
}
