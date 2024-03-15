using laba1.lab1DataSetTableAdapters;
using System.Windows;

namespace laba1
{
    public partial class Drivers : Window
    {
        driversTableAdapter driversTableAdapter = new driversTableAdapter();
        public Drivers()
        {
            InitializeComponent();
            DriversDataGrid.ItemsSource = driversTableAdapter.GetData();
        }
    }
}
