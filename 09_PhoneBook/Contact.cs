using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_PhoneBook
{
    [AddINotifyPropertyChangedInterface]
    public class Contact //: INotifyPropertyChanged
    {
        public string Name { get; set; }
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set
        //    {
        //        name = value;
        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(FullName));
        //    }
        //}
        public string Surname { get; set; }
        //private string surname;
        //public string Surname
        //{
        //    get { return surname; }
        //    set
        //    {
        //        surname = value;
        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(FullName));
        //    }
        //}
        public int Age { get; set; }
        //private int age;

        //public int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //        age = value;
        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(FullName));
        //    }
        //}
        public string Phone { get; set; }
        //private string phone;

        //public string Phone
        //{
        //    get { return phone; }
        //    set
        //    { 
        //        phone = value;
        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(FullName));
        //    }
        //}
        public bool IsMale { get; set; }
        //private bool isMale;

        //public bool IsMale
        //{
        //    get { return isMale; }
        //    set
        //    { 
        //        isMale = value;
        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(FullName));
        //    }
        //}

        public Contact Clone()
        {
            Contact copy = (this.MemberwiseClone() as Contact)!;
            copy.Name = (string)this.Name.Clone();
            copy.Surname = (string)this.Surname.Clone();
            copy.Phone = (string)this.Phone.Clone();
            return copy;
        }
        //public event PropertyChangedEventHandler? PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        public string FullName => Name + " " + Surname + " " + Age + " y.o. Phone " + Phone + " Is Male : " + IsMale;

        public override string ToString()
        {
            return Name + " " + Surname + " " + Age + " y.o. Phone " + Phone + " Is Male : " + IsMale;
        }
    }
}
