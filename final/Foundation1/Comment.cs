using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation1
{
    public class Comment
    {
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }
        string _name;
        string _comment;

    public void DisplayComments()
    {
        Console.WriteLine($"{_name}: {_comment}");
    }

    }
 }
