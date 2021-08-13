using System.Windows;
using System.Runtime.CompilerServices;
using SuperMarketAPI.Data;
using SuperMarketAPI.ViewModels;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public Management()
        {
            InitializeComponent();

            ViewModel viewModel = new ViewModel();

            
            DataContext = viewModel;

            viewModel.ListViewSize = ListViewColumn.Width.Value;
        }


    }

}
