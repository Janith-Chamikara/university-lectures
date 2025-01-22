using System.Collections.ObjectModel;

public class MainViewModel
{
    public ObservableCollection<Person> People { get; set; }

    public MainViewModel()
    {
        People = new ObservableCollection<Person> { new Person("123", "Janith Chamikara"), new Person("456", "John Doe") };
    }
}
