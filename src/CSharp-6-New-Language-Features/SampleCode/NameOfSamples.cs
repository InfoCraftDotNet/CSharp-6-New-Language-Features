﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using SampleCode.Annotations;

namespace SampleCode
{
    public class NameOfSamples : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info )
        {
            if(PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        private string _searchMyText;
        private string _lastName;

        /// <summary>
        /// Uses MagicString
        /// </summary>
        public string SearchMyText
        {
            get { return _searchMyText; }
            set
            {
                _searchMyText = value;
                NotifyPropertyChanged("SearchText");
            }
        }

        /// <summary>
        /// Uses nameof() operator
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value; 
                NotifyPropertyChanged(nameof(LastName));
            }
        }
    }
}