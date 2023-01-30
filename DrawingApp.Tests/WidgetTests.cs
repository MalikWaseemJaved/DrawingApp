
namespace DrawingApp.Tests
{
    [TestFixture]
    public class WidgetTests
    {
        [Test]
        public void Square_Draw_ReturnsExpectedOutput()
        {
            // Arrange
            var square = new Square { X = 10, Y = 10, Height = 50, Width = 50 };

            // Act
            var result = square.Draw();

            // Assert
            Assert.AreEqual("Square (x:10, y:10) height=50 width=50", result);
        }

        [Test]
        public void Rectangle_Draw_ReturnsExpectedOutput()
        {
            // Arrange
            var rectangle = new Rectangle { X = 15, Y = 20, Height = 60, Width = 80 };

            // Act
            var result = rectangle.Draw();

            // Assert
            Assert.AreEqual("Rectangle (x:15, y:20) height=60 width=80", result);
        }

        [Test]
        public void Circle_Draw_ReturnsExpectedOutput()
        {
            // Arrange
            var circle = new Circle { X = 25, Y = 30, Radius = 40 };

            // Act
            var result = circle.Draw();

            // Assert
            Assert.AreEqual("Circle (x:25, y:30) area=5026.548", result);
        }

        [Test]
        public void Ellipse_Draw_ReturnsExpectedOutput()
        {
            // Arrange
            var ellipse = new Ellipse { X = 35, Y = 40, AxisA = 50, AxisB = 60 };

            // Act
            var result = ellipse.Draw();

            // Assert
            Assert.AreEqual("Ellipse (x:35, y:40) area=4712.388 horizontal diameter=100 vertical diameter=120", result);
        }

        [Test]
        public void TextBox_Draw_ReturnsExpectedOutput()
        {
            // Arrange
            var textBox = new TextBox { X = 45, Y = 50, Height = 70, Width = 90, BackgroundColor = "Green", Text = "Hello World" };

            // Act
            var result = textBox.Draw();

            // Assert
            Assert.AreEqual("TextBox (x:45, y:50) height=70 width=90 background color=Green text='Hello World'", result);
        }

        [Test]
        public void TextBox_Draw_NoTextSupplied_ReturnsBackgroudRed()
        {
            // Arrange
            var textBox = new TextBox { X = 55, Y = 60, Height = 80, Width = 100, BackgroundColor = "Yellow" };

            // Act
            var result = textBox.Draw();

            // Assert
            Assert.AreEqual("TextBox (x:55, y:60) height=80 width=100 background color=Red text=''", result);
        }
    }
}