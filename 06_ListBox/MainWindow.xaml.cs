using System.Collections.ObjectModel;
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

namespace _06_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Student> students;
        public MainWindow()
        {
            InitializeComponent();
            students = new ObservableCollection<Student>()
            {
                 new Student(){Name="Bob", Age = 25},
                 new Student(){Name="Will", Age = 33},
                 new Student(){Name="Tom", Age = 15},
                 new Student(){Name="Jack", Age = 45}
            };
            list.Items.Clear();
            list.ItemsSource = students;
            list.DisplayMemberPath = nameof(Student.FullInfo);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Student() { Name = "Name", Age = 100 });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
                students.Remove((list.SelectedItem as Student)!);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                Student st = (list.SelectedItem as Student)!;
                st.Name = "New Name";
                st.Age = 12;
                //MessageBox.Show(st.Name + " " + st.Age);
            }
        }
    }
}