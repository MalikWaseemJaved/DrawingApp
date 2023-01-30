
using System.Text;

namespace DrawingApp.BusinessLayer
{
    public sealed class Canvas: IDraw
    {
        private static readonly Lazy<Canvas> singleton= new Lazy<Canvas>(() => new Canvas());
        private Canvas()
        {
            Widgets = new List<Widget>();
        }
        public static Canvas Instance { 
            get { 
                return singleton.Value;
            } 
        }

        public List<Widget> Widgets { get; set; }

        public void AddWidget(Widget widget)
        {
            Widgets.Add(widget);
        }

        public string Draw()
        {
            StringBuilder drawResponse = new StringBuilder();
            foreach (var widget in Widgets)
            {
                drawResponse.AppendLine(widget.Draw());
            }
            return drawResponse.ToString();
        }
    }
}
