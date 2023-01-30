namespace DrawingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = Canvas.Instance;
            canvas.AddWidget(new Square { X = 10, Y = 10, Height = 50, Width = 50 });
            canvas.AddWidget(new Circle { X = 20, Y = 20, Radius = 5 });
            canvas.AddWidget(new Rectangle { X = 30, Y = 30, Height = 40, Width = 60 });
            canvas.AddWidget(new Ellipse { X = 40, Y = 40, AxisA = 5, AxisB = 10 });
            canvas.AddWidget(new TextBox { X = 50, Y = 50, Height = 30, Width = 70, Text = "Hello World", BackgroundColor = "Green" });
            
            Console.Write(canvas.Draw());
        }
    }
}