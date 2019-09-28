using Shapes.Abstractions;
using Shapes.Abstractions.Implementors;
using System.Drawing;

namespace Shapes.ConcreteAbstractions
{
    class Rectangle : Shape
    {
        protected PointF Point { get; set; }
        protected SizeF Size { get; set; }
        protected Color Color { get; set; }

        public Rectangle(IDrawing drawing, PointF point, SizeF size, Color color)
            : base(drawing)
        {
            Point = point;
            Size = size;
            Color = color;
        }

        public override void Draw(Graphics graphics)
        {
            DrawLine(graphics, Color, Point, new PointF(Point.X + Size.Width, Point.Y));
            DrawLine(graphics, Color, new PointF(Point.X + Size.Width, Point.Y), new PointF(Point.X + Size.Width, Point.Y + Size.Height));
            DrawLine(graphics, Color, Point, new PointF(Point.X, Point.Y + Size.Height));
            DrawLine(graphics, Color, new PointF(Point.X, Point.Y + Size.Height), new PointF(Point.X + Size.Width, Point.Y + Size.Height));
        }
    }
}
