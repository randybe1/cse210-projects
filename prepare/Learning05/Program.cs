using System;

namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>(); // List of Shape, not List of Square

            Square s1 = new Square("Red", 3);
            shapes.Add(s1);

            Rectangle s2 = new Rectangle("Blue", 4, 5);
            shapes.Add(s2);

            Circle s3 = new Circle("Green", 6);
            shapes.Add(s3);

            foreach (Shape s in shapes)
            {
                string color = s.GetColor(); // Accessing the color field directly

                double area = s.GetArea();; // Calling the ComputeArea() method

                Console.WriteLine($"The {color} shape has an area of {area}.");
            }
        }

    }
}

