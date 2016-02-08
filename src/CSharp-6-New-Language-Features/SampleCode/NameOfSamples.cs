using System.ComponentModel;
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

        private string _searchText;
        private string _firstName;

        /// <summary>
        /// Uses MagicString
        /// </summary>
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                NotifyPropertyChanged("SearchText");
            }
        }

        /// <summary>
        /// Uses nameof() operator
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value; 
                NotifyPropertyChanged(nameof(FirstName));
            }
        }
    }
}