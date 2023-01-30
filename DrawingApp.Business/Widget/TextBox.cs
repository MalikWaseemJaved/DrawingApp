
namespace DrawingApp.BusinessLayer
{
    public class TextBox : Rectangle
    {
        private const string defaultBackgroudColor = "Red";
        public string Text { get; set; }

        private string backgroundColor;

        private Widget widget;

        public string BackgroundColor
        {
            get {
                if (string.IsNullOrEmpty(this.Text))
                {
                    return defaultBackgroudColor;
                }
                else
                {
                    return backgroundColor; 
                }
            }
            set
            {
                backgroundColor= value;
            }
        }

        public override string Draw()
        {
            return $"TextBox (x:{X}, y:{Y}) height={Height} width={Width} background color={BackgroundColor} text={Text ?? "''"}";
        }
    }
}
