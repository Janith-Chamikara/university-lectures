using ShapeNameSpace;

namespace CircleNameSpace;

public class Circle:Shape
{
    public Circle(){
        Console.WriteLine("Creating a circle from Child-Circle class.");
    }

     public override void Draw(){
        Console.WriteLine("Drawing Circle.");
    }
}
