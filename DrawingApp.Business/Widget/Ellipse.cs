namespace DrawingApp.BusinessLayer
{
    public class Ellipse : Widget
    {
        public double AxisA { get; set; }
        public double AxisB { get; set; }

        public override string Draw()
        {
            double area = Math.PI * AxisA * AxisB;
            return $"Ellipse (x:{X}, y:{Y}) area={area} horizontal diameter={AxisA} vertical diameter={AxisB}";
        }
    }
}
