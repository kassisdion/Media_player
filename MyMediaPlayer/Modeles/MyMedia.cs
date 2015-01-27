using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyMediaPlayer.Modele
{
    class MyMedia
    {
        private MediaElement _media;

        private static MyMedia _instance = null;
        public static MyMedia Instance()
        {
            if (_instance == null)
                _instance = new MyMedia();
            return _instance;
        }
        public MyMedia()
        {
            Debug.WriteLine("MediaElement instancié");
            this._media = new MediaElement();
        }

        public MediaElement CurrentMedia
        {
            get
            {
                return _media;
            }
        }


        public Uri Source
        {
            get
            {
                return _media.Source;
            }
            set
            {
                _media.Source = value;
            }
        }
    }
}
