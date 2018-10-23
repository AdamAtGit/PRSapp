using System;
using System.ComponentModel;
using Windows.ApplicationModel;

namespace PRSapp.Models
{
    public class M_Speech : INotifyPropertyChanged
    {
        public M_Speech()
        {
            if (DesignMode.DesignModeEnabled)
            {
                IsCmdMode = false;
                Title = "942_DT";
                Category = "SED IB";
                Description = "descript...";
                MediaElementVolume = 95;
                ProsidyRate = "medium";
                VoiceGender = "female";
                ForceRepeats = 3;
            }
            else
            {
                Title = "";
                Category = "";
            }
        }

        private int mediaElementVolume;
        public int MediaElementVolume
        {
            get => MediaElementVolume;
            set
            {
                mediaElementVolume = value;
                OnPropertyChanged("MediaElementVolume");
            }
        }

        private string prosidyRate;
        public string ProsidyRate
        {
            get => prosidyRate;
            set
            {
                prosidyRate = value;
                OnPropertyChanged("ProsidyRate");
            }
        }

        private string voiceGender;
        public string VoiceGender
        {
            get => voiceGender;
            set
            {
                voiceGender = value;
                OnPropertyChanged("VoiceGender");
            }
        }

        private bool isCmdMode;
        public bool IsCmdMode
        {
            get => isCmdMode;
            set
            {
                isCmdMode = value;
                OnPropertyChanged("IsCmdMode");

            }
        }      

        private TimeSpan playTime;
        public TimeSpan PlayTime
        {
            get => playTime;
            set
            {
                playTime = value;
                OnPropertyChanged("PlayTime");
            }
        }

        private string splayTime;
        public string SPlayTime
        {
            get => splayTime;
            set
            {
                splayTime = value;
                OnPropertyChanged("SPlayTime");
            }
        }

        private string currentTime;
        public string CurrentTime
        {
            get => currentTime;
            set
            {
                currentTime = value;
                OnPropertyChanged("CurrentTime");
            }
        }

        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
                OnPropertyChanged("TitleAndDescription");
            }
        }

        private string description;
        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
                OnPropertyChanged("TitleAndDescription");
            }
        }

        private string TitleAndDescription;
        public string titleAndDescription
        {
            get { return Title + " - " + Description; }
            set
            {
                titleAndDescription = value;
                OnPropertyChanged("TitleAndDescription");
            }

        }
        private string category;
        public string Category
        {
            get => category; 
            set
            {
                category = value;
                OnPropertyChanged("Category");
            }
        }    

        public int ForceRepeats { get; set; }

        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        #endregion       
    }
}

