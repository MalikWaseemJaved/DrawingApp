namespace DrawingApp.BusinessLayer
{
    public class Circle : Widget
    {
        public double Radius { get; set; }

        public override string Draw()
        {
            return $"Circle (x:{X}, y:{Y}) area={Math.PI * Radius * Radius}";
        }
    }
}
