using FirstFloor.ModernUI.Windows.Controls;
using MyMediaPlayer.Modele;
using MyMediaPlayer.Modeles.lib;
using MyMediaPlayer.viewModels;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logique d'interaction pour video.xaml
    /// </summary>
    public partial class video : UserControl
    {
        public video()
        {
            InitializeComponent();

            DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            string path = di.FullName.Replace(di.Name, "Videos");
            String extension = "*.dat, *.wmv, *.3g2, *.3gp, *.3gp2, *.3gpp, *.amv, *.asf,  *.avi, *.bin, *.cue, *.divx, *.dv, *.flv, *.gxf, *.iso, *.m1v, *.m2v, *.m2t, *.m2ts, *.m4v *.mkv, *.mov, *.mp2, *.mp2v, *.mp4, *.mp4v, *.mpa, *.mpe, *.mpeg, *.mpeg1, *.mpeg2, *.mpeg4, *.mpg, *.mpv2, *.mts, *.nsv, *.nuv, *.ogg, *.ogm, *.ogv, *.ogx, *.ps, *.rec, *.rm, *.rmvb, *.tod, *.ts, *.tts, *.vob, *.vro, *.webm";
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
