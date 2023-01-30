
namespace DrawingApp.BusinessLayer
{
    public class Square : Widget
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override string Draw()
        {
            return $"Square (x:{X}, y:{Y}) height={Height} width={Width}";
        }
    }
}
