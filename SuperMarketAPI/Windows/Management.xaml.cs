using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using SuperMarketAPI.Data;


namespace SuperMarketAPI
{
    /// <summary>
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class Management : INotifyPropertyChanged
    {
        public Management()
        {
            InitializeComponent();
            DataContext = this;

            //Teste da base de dados SuperDataBase

            //using (var db = new SuperContext())
            //{
            //    var seller = new Seller() { SellerName = "Teste1", User = new User() };
            //    db.Sellers.Add(seller);
            //    db.SaveChanges();
            //}
        }

        private string _windowName = "Nome da Window";
        private string _button1 = "Botão 1";
        private string _button2 = "Botão 2";

        public string Button1
        {
            get { return _button1; }
            set
            {
                if (_button1 != value)
                {
                    _button1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Button2
        {
            get { return _button2; }
            set
            {
                if (_button2 != value)
                {
                    _button2 = value;
                    OnPropertyChanged();
                }
            }
        }

        public string WindowName
        {
            get { return _windowName; }
            set
            {
                if (_windowName != value)
                {
                    _windowName = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
