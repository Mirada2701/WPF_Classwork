using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace _09_PhoneBook
{
    [AddINotifyPropertyChangedInterface]
    class ViewModel
    {
        private ObservableCollection<Contact> contacts;
        private RelayCommand dublicateCommand;
        private RelayCommand removeCommand;
        private RelayCommand clearCommand;
        private RelayCommand addCommand;
        public ViewModel()
        {
            contacts = new ObservableCollection<Contact>();
            dublicateCommand = new RelayCommand((o) => DublicateSelectedContact(),(o) => SelectedContact!=null);
            removeCommand = new RelayCommand((o) => DeleteSelectedContact(),(o)=> SelectedContact!=null);
            clearCommand = new RelayCommand((o) => contacts.Clear(),(o)=> contacts.Any());
            addCommand = new RelayCommand((o) => contacts.Add(new Contact() {Name = "No name",Surname= "No surname",Age = 0, Phone ="0", IsMale = false}));

            contacts.Add(new Contact() { Name = "Vova", Age = 30, Surname = "Pupkin", Phone = "+3807575828", IsMale = true });
            contacts.Add(new Contact() { Name = "Marusia", Age = 25, Surname = "Shishik", Phone = "+380771244", IsMale = false });
            contacts.Add(new Contact() { Name = "Olga", Age = 33, Surname = "Shelesh", Phone = "+38067285792", IsMale = false });

        }
        public IEnumerable<Contact> Contacts => contacts;//get
        public ICommand DublicateCmd => dublicateCommand;//get
        public ICommand RemoveCmd => removeCommand;//get
        public ICommand ClearCmd => clearCommand;//get
        public ICommand AddCmd => addCommand;//get
        public Contact SelectedContact { get; set; }        
        public void DeleteSelectedContact()
        {
            if (SelectedContact != null)
                contacts.Remove(SelectedContact);
        }
        //public void DeleteAllContact()
        //{
        //    if (contacts.Any())
        //        contacts.Clear();
        //}
        public void DublicateSelectedContact()
        {
            if (SelectedContact != null)
                contacts.Add(SelectedContact.Clone());
        }        
    }
}