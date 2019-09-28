using Shapes.Abstractions;
using Shapes.Abstractions.Implementors;
using Shapes.ConcreteAbstractions;
using Shapes.ConcreteImplementors;
using Shapes.UserControls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Shapes
{
    public partial class FrmShapes : Form
    {
        public FrmShapes()
        {
            InitializeComponent();

            _graphics = pnlView.CreateGraphics();
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
            _ucCircleInfo.Location = _ucRectangleInfo.Location = new Point(303, 125);
            _ucCircleInfo.Hide();
            _ucRectangleInfo.Hide();
            Controls.Add(_ucCircleInfo);
            Controls.Add(_ucRectangleInfo);
            cbbShape.Text = "Hình tròn";
            cbbStyleDrawing.Text = "Liền nét";
        }

        private Shape _shape = null;
        private IDrawing _drawing = null;
        private UcCircleInfo _ucCircleInfo = new UcCircleInfo();
        private UcRectangleInfo _ucRectangleInfo = new UcRectangleInfo();
        private Graphics _graphics = null;

        private void pnlColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = true;
            DialogResult dialogResult = color.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                pnlColor.BackColor = color.Color;
            }
        }

        private void cbbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int selectedIndex = comboBox.SelectedIndex;
            if (selectedIndex < 0)
                return;

            switch (selectedIndex)
            {
                case 0:
                    _ucCircleInfo.Clear();
                    _ucCircleInfo.Show();
                    _ucRectangleInfo.Hide();
                    break;
                case 1:
                    _ucRectangleInfo.Clear();
                    _ucRectangleInfo.Show();
                    _ucCircleInfo.Hide();
                    break;
                default: break;
            }
        }

        private void cbbStyleDrawing_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int selectedIndex = comboBox.SelectedIndex;
            if (selectedIndex < 0)
                return;

            switch (selectedIndex)
            {
                case 0: _drawing = new SolidDrawing(); break;
                case 1: _drawing = new DottedDrawing(); break;
                default: break;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int selectedIndex = cbbShape.SelectedIndex;
            if (selectedIndex < 0)
                return;

            switch (selectedIndex)
            {
                case 0:
                    _graphics.Clear(Color.White);
                    _shape = new Circle(_drawing,
                            new PointF(
                                _ucCircleInfo.CircleX,
                                _ucCircleInfo.CircleY),
                                _ucCircleInfo.CircleRadius, pnlColor.BackColor);
                    _shape.Draw(_graphics);
                    break;
                case 1:
                    _graphics.Clear(Color.White);
                    _shape = new ConcreteAbstractions.Rectangle(_drawing,
                            new PointF(_ucRectangleInfo.RectX, _ucRectangleInfo.RectY),
                            new SizeF(_ucRectangleInfo.RectWidth, _ucRectangleInfo.RectHeight),
                            pnlColor.BackColor);
                    _shape.Draw(_graphics);
                    break;
                default: break;
            }
        }
    }
}
