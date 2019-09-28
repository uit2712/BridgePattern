using Shapes.Abstractions.Implementors;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Shapes.ConcreteImplementors
{
    class DottedDrawing : IDrawing
    {
        protected Pen _pen = new Pen(Color.Black, 5);

        public DottedDrawing()
        {
            _pen.DashStyle = DashStyle.Dot;
        }

        public void DrawCircle(Graphics graphics, Color color, PointF centerPoint, float radius)
        {
            if (_pen == null || graphics == null)
                return;

            _pen.Color = color;
            graphics.DrawEllipse(_pen, centerPoint.X, centerPoint.Y, radius, radius);
        }

        public void DrawLine(Graphics graphics, Color color, PointF startPoint, PointF endPoint)
        {
            if (_pen == null || graphics == null)
                return;

            _pen.Color = color;
            graphics.DrawLine(_pen, startPoint, endPoint);
        }
    }
}
