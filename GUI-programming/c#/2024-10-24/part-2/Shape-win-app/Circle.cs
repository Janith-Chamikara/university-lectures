using System.Reflection.PortableExecutable;

namespace Shape_win_app;

public class Circle:Shape
{
    public Color ShapeColor {get; set;} 
    public int Radius {get; set;}
    public int cX {get;set;}
    public int cY {get;set;}

    public Circle(Color argColor, int argX, int argY, int argRadius){
         ShapeColor = argColor;
         cX = argX;
         cY = argY;
         Radius = argRadius;
    }
    
    public override void Draw(Graphics graphics){
      base.Draw(graphics);
      Pen pen = new Pen(ShapeColor);
      int x1 = cX - Radius;
      int y1 = cY - Radius;
      graphics.DrawEllipse(pen, x1, y1,Radius+2,Radius+2);
    }
}
