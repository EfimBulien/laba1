using laba1.lab1DataSetTableAdapters;
using System.Windows;

namespace laba1
{
    public partial class Cars : Window
    {
        carsTableAdapter carsTableAdapter = new carsTableAdapter();
        public Cars()
        {
            InitializeComponent();
            CarsDataGrid.ItemsSource = carsTableAdapter.GetData();
        }
    }
}
