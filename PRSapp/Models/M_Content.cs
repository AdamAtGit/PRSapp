using System;
using System.ComponentModel;
using Windows.ApplicationModel;

namespace PRSapp.Models
{
    public class M_Content : INotifyPropertyChanged
    {

        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        #endregion     

        public M_Content()
        {
            if (DesignMode.DesignModeEnabled)
            {               
                Title = "942_DT";
                Category = "SED IB";              
            }
            else
            {
                Title = "";
                Category = "";
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
  
    }
}
