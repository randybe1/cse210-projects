using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation1
{
  using System;

public class Comment
{
    private string _name;
    private string _comment;

    // Constructor
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    // Method to display comment
    public void Display()
    {
        Console.WriteLine($"{_name}: {_comment}");
    }

    // Properties to encapsulate data
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Text
    {
        get { return _comment; }
        set { _comment = value; }
    }
}

 }
