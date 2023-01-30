
namespace DrawingApp.BusinessLayer
{
    public class Rectangle : Widget
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override string Draw()
        {
            return $"Rectangle (x:{X}, y:{Y}) height={Height} width={Width}";
        }
    }
}
