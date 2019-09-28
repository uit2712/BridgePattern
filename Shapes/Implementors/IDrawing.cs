using System.Drawing;

namespace Shapes.Abstractions.Implementors
{
    interface IDrawing
    {
        void DrawLine(Graphics graphics, Color color, PointF startPoint, PointF endPoint);
        void DrawCircle(Graphics graphics, Color color, PointF centerPoint, float radius);
    }
}
