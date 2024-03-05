using System.Collections.ObjectModel;
using System.Collections.Specialized;
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

namespace _05_ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> persons = null;
        public MainWindow()
        {
            //INotifyCollectionChanged
            InitializeComponent();
            persons = new ObservableCollection<Person>()
            {
                new Person(){ Name = "Olga", Surname= "Ivanchuk", Birthday = new DateTime(2000,5,17),},
                new Person(){ Name = "Bob", Surname= "Tomson", Birthday = new DateTime(2003,8,21),},
                new Person(){ Name = "Tom", Surname= "Robson", Birthday = new DateTime(2011,3,20),}
            };
            comboBox.Items.Clear();
            //comboBox.SelectedIndex = 0;
            //foreach (Person person in persons)
            //{
            //    comboBox.Items.Add(person);
            //}
            //binding colection to comboBox
            comboBox.ItemsSource = persons;
            //comboBox.DisplayMemberPath = "FullName";
            comboBox.DisplayMemberPath = nameof(Person.FullInfoAboutPerson);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var person = new Person() { Name = "New name", Surname = "New Surname", Birthday = new DateTime(2000, 5, 17), };
            persons.Add(person);
            MessageBox.Show(persons.Count.ToString());
            //comboBox.Items.Add(person);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex != -1)
                persons.RemoveAt(comboBox.SelectedIndex);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            persons.Clear();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBox.SelectedItem != null)
            {
                MessageBox.Show(comboBox.SelectedItem.ToString());
            }
        }
    }
}