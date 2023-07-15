using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp16.ViewModels;
using WpfApp3.Command;

namespace WpfApp3.Views
{

    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          

                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

   

            MainViewModel? viewModel = DataContext as MainViewModel;
            if (viewModel != null)
            {
                int selectedIndex = combo.SelectedIndex;



              
                marka.Text = viewModel.markaNames[selectedIndex];
                model.Text = viewModel.modelNames[selectedIndex];
                year.Text = viewModel.yearNames[selectedIndex];
            }

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainViewModel? viewModel = DataContext as MainViewModel;
            if (viewModel != null)
            {
                int selectedIndex = combo.SelectedIndex;

                viewModel.markaNames.RemoveAt(selectedIndex);
                viewModel.modelNames.RemoveAt(selectedIndex);
                viewModel.yearNames.RemoveAt(selectedIndex);



                marka.Text = "";
                model.Text = "";
                year.Text = "";
            }
        }
    }
}
