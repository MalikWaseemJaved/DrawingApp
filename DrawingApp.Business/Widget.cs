
namespace DrawingApp.BusinessLayer
{
    public abstract class Widget: IDraw
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public abstract string Draw();
    }
}
