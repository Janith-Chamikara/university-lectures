namespace Shape_win_app;

public partial class Form1 : Form
{
    List<Shape> shapes;
    public Form1()
    {
        InitializeComponent();
        shapes = new List<Shape>();
        Circle circle1 = new Circle(Color.Red,300,300,200);
        Circle circle2 = new Circle(Color.Red,600,300,200);
        shapes.Add(circle1);
        shapes.Add(circle2);
    }

    protected override void OnPaint(PaintEventArgs e){
        base.OnPaint(e);
        Pen pen = new Pen(Color.Red,2);
        Font font = new Font("Arial", 16, FontStyle.Bold);
        PointF point = new PointF(0, 0);
        SolidBrush brush = new SolidBrush(Color.Black);
        Graphics graphics = e.Graphics;
        graphics.DrawString("SHAPE-WIN-APP",font,brush,point);
        graphics.DrawRectangle(pen,10,50,100,100);
        graphics.FillRectangle(brush,10,50,100,100);

        
        foreach(Shape shape in shapes){
            shape.Draw(graphics);
        }
                                       
    }
}
