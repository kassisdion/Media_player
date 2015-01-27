using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyMediaPlayer.modele;
using System.ComponentModel;
using System.Windows.Controls;
using FirstFloor.ModernUI.Presentation;
using MyMediaPlayer.Modele;

namespace MyMediaPlayer.viewModels
{
    class HomeViewModel
    {
        private ICommand _openFileCommand = null;
        private ICommand _playFileCommand = null;
        private ICommand _stopFileCommand = null;
        private ICommand _pauseFileCommand = null;

        public ICommand OpenFile
        {
            get
            {
                if (_openFileCommand == null)
                {
                    _openFileCommand = new RelayCommand(param => MediaManager.openFile());
                }
                return _openFileCommand;
            }
        }

        public ICommand PlayFile
        {
            get
            {
                if (_playFileCommand == null)
                {
                    _playFileCommand = new RelayCommand(param => MediaManager.playFile());
                }
                return _playFileCommand;
            }
        }

        public ICommand StopFile
        {
            get
            {
                if (_stopFileCommand == null)
                {
                    _stopFileCommand = new RelayCommand(param => MediaManager.stopFile());
                }
                return _stopFileCommand;
            }
        }
        public ICommand PauseFile
        {
            get
            {
                if (_pauseFileCommand == null)
                {
                    _pauseFileCommand = new RelayCommand(param => MediaManager.pauseFile());
                }
                return _pauseFileCommand;
            }
        }

        public MyMedia Media
        {
            get
            {
                return MyMedia.Instance();
            }
        }
    }
}
