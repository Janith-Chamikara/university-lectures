using ShapeNameSpace;

namespace RectangleNameSpace;

public class Rectangle:Shape
{
    public Rectangle(){
        Console.WriteLine("Creating a rectangle from Child-Rectangle class.");
    }

    public override void Draw(){
        Console.WriteLine("Drawing Rectangle.");
    }
}
