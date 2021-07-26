using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SuperMarketAPI.Models
{
    public class Word : INotifyPropertyChanged
    {
        public Word(string[] listOfWords)
        {
            _name = listOfWords;
        }

        private string[] _name;
        public string[] Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        #region INotifyProperty Changed Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
