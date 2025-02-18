using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic.FileIO;

namespace CSVData_DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {    
              // 1 open dialog window
            OpenFileDialog openFile = new OpenFileDialog();
              // 2 filter check CSV only 
            openFile.Filter = "Cav Files| *.csv";
             
           
                 //Check if have data from dialog 
            if (openFile.ShowDialog() == true)
            {   
                 // Receive value from Class GetCsvData 
                 // Access to CSVData stucture and GetCsvData funtion and pass value openFile.FileName 
                var csvData = CSVData.GetCsvData(openFile.FileName);

                 // Get data csv to Name CsvDataGrid XAML 
                CsvDataGrid.ItemsSource = csvData;
            }


        }


    }
}