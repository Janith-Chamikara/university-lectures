using ShapeNameSpace;

namespace TriangleNameSpace;

public class Triangle:Shape
{
     public Triangle(){
        Console.WriteLine("Creating a triangle from Child-Triangle class.");
    }

    public override void Draw(){
        Console.WriteLine("Drawing Triangle.");
    }
}
