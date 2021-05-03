using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfApp10
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string surname;
        public string Surname
        {
            get => surname;
            set { surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname")); }
        }

        private int date;
        public int Date
        {
            get => date;
            set { date = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date")); }
        }

        

        public static ObservableCollection<Person> AllPersons { get; set; } = new ObservableCollection<Person>();

        public static void InitPersons()
        {
            AllPersons.Add(new Person
            {
                Name = "Filip",
                Surname = "Kováč",
                Date = 2003,
                
            });

            AllPersons.Add(new Person
            {
                Name = "Michal",
                Surname = "Kováč",
                Date = 1997,
                
            });

            AllPersons.Add(new Person
            {
                Name = "Daniel",
                Surname = "Hyrman",
                Date = 2002,
                
            });

           
        }

    }
}
