using MyMediaPlayer.Modele;
using MyMediaPlayer.Modeles.lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyMediaPlayer.ViewModels.lib
{
    public class LibViewModel : ModelBase
    {

        private string path;
        private string extension;
        public LibViewModel(String path, String extension)
        {
            this.path = path;
            this.extension = extension;
            setFiles();
        }

        private FileObject selectedFileObjects = null;
        public FileObject SelectedFileObject
        {
            get
            {
                return selectedFileObjects;
            }
            set
            {
                if (value != this.selectedFileObjects)
                    selectedFileObjects = value;
                this.SetPropertyChanged("SelectedFileObject");
            }
        }

        private ObservableCollection<FileObject> fileObjectCollection;
        public ObservableCollection<FileObject> FileObjectCollection
        {
            get { return fileObjectCollection; }
            set
            {
                if (value != this.fileObjectCollection)
                    fileObjectCollection = value;
                this.SetPropertyChanged("FileObjectCollection");
            }
        }

        public string Path
        {
            get { return path; }
            set
            {
                if (value != this.path)
                    path = value;
                this.SetPropertyChanged("Path");
            }
        }
        private void setFiles()
        {
            if (this.path != string.Empty)
            {
                DirectoryInfo dInfo = new DirectoryInfo(this.path);
                FileInfo[] fInfo = dInfo.EnumerateFiles().Where(f => extension.Contains(f.Extension.ToLower())).ToArray();
                fInfo.Cast<FileInfo>().ToList().ForEach(setFileObjectCollection());
            }
        }
        private Action<FileInfo> setFileObjectCollection()
        {
            this.fileObjectCollection = new ObservableCollection<FileObject>();
            return f => this.fileObjectCollection.Add(new FileObject { FileName = f.Name, Location = f.DirectoryName });
        }
    }
}
