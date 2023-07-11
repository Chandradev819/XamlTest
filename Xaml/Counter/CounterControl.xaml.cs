using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace XamlTest.Xaml.Counter
{
    public partial class CounterControl : UserControl
    {
        readonly ViewModel _viewModel = new();
        public CounterControl()
        {
            this.InitializeComponent();
            this.DataContext = _viewModel;
        }
        private void ButtonIncrementCount_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.CurrentCount++;
        }
    }
}
