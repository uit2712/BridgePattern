using System.Windows.Forms;

namespace Shapes.UserControls
{
    public partial class UcRectangleInfo : UserControl
    {
        public UcRectangleInfo()
        {
            InitializeComponent();
        }

        public float RectX
        {
            get
            {
                float result = 0;
                float.TryParse(txtX.Text, out result);

                return result;
            }
        }

        public float RectY
        {
            get
            {
                float result = 0;
                float.TryParse(txtY.Text, out result);

                return result;
            }
        }

        public float RectWidth
        {
            get
            {
                float result = 0;
                float.TryParse(txtWidth.Text, out result);

                return result;
            }
        }

        public float RectHeight
        {
            get
            {
                float result = 0;
                float.TryParse(txtHeight.Text, out result);

                return result;
            }
        }

        public void Clear()
        {
            txtHeight.Clear();
            txtWidth.Clear();
            txtX.Clear();
            txtY.Clear();
        }
    }
}
