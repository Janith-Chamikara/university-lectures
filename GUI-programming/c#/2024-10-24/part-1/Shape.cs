namespace ShapeNameSpace;

public class Shape
{
    public string Colour{get; set;}
    
    public Shape(){
        Console.WriteLine("Creating shape from parent class.");
    }
    public virtual void Draw(){
        Console.WriteLine("Drawing Shape.");
    }
}
