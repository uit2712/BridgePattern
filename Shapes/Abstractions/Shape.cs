using Shapes.Abstractions.Implementors;
using System.Drawing;

namespace Shapes.Abstractions
{
    abstract class Shape : IDrawing
    {
        private IDrawing _drawing;
        public Shape(IDrawing drawing)
        {
            _drawing = drawing;
        }

        public void DrawCircle(Graphics graphics, Color color, PointF centerPoint, float radius)
        {
            _drawing?.DrawCircle(graphics, color, centerPoint, radius);
        }

        public void DrawLine(Graphics graphics, Color color, PointF startPoint, PointF endPoint)
        {
            _drawing?.DrawLine(graphics, color, startPoint, endPoint);
        }

        public abstract void Draw(Graphics graphics);
    }
}
