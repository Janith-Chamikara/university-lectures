using System;
using System.Windows;

public class Person
{
    private string _name;
    private string _id;

    public string Id
    {
        get { return _id; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Id cannot be empty or null");
            }
        }
    }
    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
            _name = value;
        }
    }

    public Person(string ID, string name)
    {
        _id = ID;
        _name = name;
    }
}
