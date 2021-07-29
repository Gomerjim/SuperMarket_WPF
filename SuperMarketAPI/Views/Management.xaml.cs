using System.Windows;
using System.Runtime.CompilerServices;
using SuperMarketAPI.Data;
using SuperMarketAPI.ViewModels;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SuperMarketAPI.Models;
using System.Windows.Controls;
using System;
using System.Reflection;

namespace SuperMarketAPI
{
    /// <summary>
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class Management : Window
    {
        private List<DataGridColumn> columns = new List<DataGridColumn>();

        public Management()
        {
            InitializeComponent();

            using (var db = new SuperContext())
            {
                var words = new List<Word>
                {
                    new Word("Janela"),
                    new Word("Botao1"),
                    new Word("Botao2")
                };
                var tabela = db.Sellers.ToList();

                ViewModel viewModel = new ViewModel(words, tabela);

                DataContext = viewModel;
            }
        }

        private void OnAutoGeneratingColumn(object sender, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs e)
        {
            if (columns.Count == 3)
            {
                foreach (var item in columns)
                {
                    switch (item.Header.ToString())
                    {
                        case "SellerName":
                            ManagementDataGrid.Columns[item.DisplayIndex].Header = "Fornecedor";
                            break;
                        case "SellerAge":
                            ManagementDataGrid.Columns[item.DisplayIndex].Header = "Idade";
                            break;
                        case "SellerPhone":
                            ManagementDataGrid.Columns[item.DisplayIndex].Header = "Contacto";
                            break;
                        default:
                            break;
                    }
                }
            }

            if (e.PropertyName == "SellerPass" || e.PropertyName == "User" || e.PropertyName == "UserId")
                e.Column = null;

            else
                columns.Add(e.Column);
        }
    }

}
