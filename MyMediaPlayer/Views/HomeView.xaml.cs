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

namespace MyWindowsMediaPlayerV2.Views
{
    public partial class MyView : UserControl
    {
        public MyView()
        {
            InitializeComponent();
            this.DataContext = new MyMediaPlayer.viewModels.HomeViewModel();
        }

        private void seekToMediaPosition(Object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            int sliderValue = (int)SongSlider.Value;
            TimeSpan ts = new TimeSpan(0, 0, sliderValue, 0, 0);
            Console.WriteLine("" + sliderValue);
            MediaElem.Position = ts;
        }
    }
}
