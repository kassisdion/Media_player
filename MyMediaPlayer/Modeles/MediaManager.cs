using Microsoft.Win32;
using MyMediaPlayer.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyMediaPlayer.modele
{
    class MediaManager
    {
        internal static void openFile()
        {
            Debug.WriteLine("open");
            OpenFileDialog dlg = new OpenFileDialog();
            if ((bool) dlg.ShowDialog())
            {
                MyMedia.Instance().Source = new Uri(dlg.FileName);
                MyMedia.Instance().CurrentMedia.LoadedBehavior = MediaState.Play;
            }
            else
            {
                //TODO
                //Impossible d'ouvrir le gestionnaire de fichier
            }
        }

        internal static void playFile()
        {
            Debug.WriteLine("play");
            MyMedia.Instance().CurrentMedia.LoadedBehavior = MediaState.Play;
        }

        internal static void stopFile()
        {
            Debug.WriteLine("stop");
            MyMedia.Instance().CurrentMedia.LoadedBehavior = MediaState.Stop;
        }

        internal static void pauseFile()
        {
            Debug.WriteLine("pause");
            MyMedia.Instance().CurrentMedia.LoadedBehavior = MediaState.Pause;
        }
    }
}
