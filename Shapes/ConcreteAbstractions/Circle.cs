using Shapes.Abstractions;
using Shapes.Abstractions.Implementors;
using System.Drawing;

namespace Shapes.ConcreteAbstractions
{
    class Circle : Shape
    {
        protected PointF CenterPoint { get; set; }
        protected float Radius { get; set; }
        protected Color Color { get; set; }

        public Circle(IDrawing drawing, PointF centerPoint, float radius, Color color)
            : base(drawing)
        {
            CenterPoint = centerPoint;
            Radius = radius;
            Color = color;
        }

        public override void Draw(Graphics graphics)
        {
            DrawCircle(graphics, Color, CenterPoint, Radius);
        }
    }
}
