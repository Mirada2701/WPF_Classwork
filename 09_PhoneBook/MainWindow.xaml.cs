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

namespace _09_PhoneBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel model = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();         
            this.DataContext = model;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    model.DublicateSelectedContact();
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    model.DeleteSelectedContact();
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    //model.DeleteAllContact();
        //}
    }
}