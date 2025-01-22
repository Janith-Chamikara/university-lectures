using System.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Intro_to_WPF.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _id;

        public ObservableCollection<Person> Persons { get; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        public ICommand AddPersonCommand { get; }

        public PersonViewModel()
        {
            Persons = new ObservableCollection<Person>();

            AddPersonCommand = new RelayCommand(AddPerson);
        }

        private void AddPerson()
        {
            // Add a new person to the collection
            var person = new Person
            {
                Name = Name,
                ID = ID
            };

            // Add the person to the ObservableCollection
            Persons.Add(person);

            MessageBox.Show($"Person Added: Name = {Name}, ID = {ID}");
            // Clear the input fields after adding
            Name = string.Empty;
            ID = string.Empty;

            // Optionally, show a message
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // Person class to hold the individual person data
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }

    // Basic ICommand implementation (RelayCommand)
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;

        public RelayCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _execute();

        public event EventHandler CanExecuteChanged;
    }
}
