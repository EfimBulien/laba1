using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace laba1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// DataSet
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CarsTableButton_Click(object sender, RoutedEventArgs e)
        {
            Cars cars = new Cars();
            cars.ShowDialog();
        }

        private void DriversTableButton_Click(object sender, RoutedEventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.ShowDialog();
        }
    }
}
