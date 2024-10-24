using System.Diagnostics;
using CircleNameSpace;
using RectangleNameSpace;
using ShapeNameSpace;
using TriangleNameSpace;

// Circle [] circles = new Circle[4];

// for(int i = 0; i < 4 ; i++){
//     circles[i] = new Circle();
// }

// for(int i = 0 ; i < circles.Length ; i++){
//     circles[i].Draw();
// }

// List<Rectangle> rectangles = new List<Rectangle>();

// for(int i = 0; i < 4 ; i++){
//     rectangles.Add(new Rectangle());
// }

// foreach(Rectangle rectangle in rectangles){
//     rectangle.Draw();
// }

List<Shape> shapes = new List<Shape>();

Circle circle = new Circle();
Rectangle rectangle = new Rectangle();
Triangle triangle = new Triangle();

shapes.Add(circle);
shapes.Add(rectangle);
shapes.Add(triangle);

foreach(Shape shape in shapes){
    shape.Draw();
}


