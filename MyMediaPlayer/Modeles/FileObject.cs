using MyMediaPlayer.ViewModels.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaPlayer.Modeles.lib
{
    public class FileObject : ModelBase
    {
        private string location = string.Empty;
        public string Location
        {
            get { return location; }
            set
            {
                if (value != this.location)
                    location = value;
                this.SetPropertyChanged("Location");
            }
        }

        private string fileName = string.Empty;
        public string FileName
        {
            get { return fileName; }
            set
            {
                if (value != this.fileName)
                    fileName = value;
                this.SetPropertyChanged("FileName");
            }
        }

        public override string ToString()
        {
            string returnString = string.Empty;
            if (this.fileName != string.Empty)
                returnString = this.fileName;
            return returnString;
        }
    }
}
