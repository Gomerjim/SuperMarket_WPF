using System.Windows;
using System.Runtime.CompilerServices;
using SuperMarketAPI.Data;
using SuperMarketAPI.ViewModels;


namespace SuperMarketAPI
{
    /// <summary>
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class Management : Window
    {
        public Management()
        {
            InitializeComponent();

            //Teste MVVM

            string word1 = "Nome da Window";
            string word2 = "Botão 1";
            string word3 = "Botão 2";
            string[] arrayOfWords = new string[]{ word1, word2, word3 };

            DataContext = new WordViewModel(arrayOfWords);

            //Teste da base de dados SuperDataBase

            //using (var db = new SuperContext())
            //{
            //    var seller = new Seller() { SellerName = "Teste1", User=new User()};
            //    db.Sellers.Add(seller);
            //    db.SaveChanges();
            //}
        }

    }
}
