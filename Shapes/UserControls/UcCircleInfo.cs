using System.Windows.Forms;

namespace Shapes.UserControls
{
    public partial class UcCircleInfo : UserControl
    {
        public UcCircleInfo()
        {
            InitializeComponent();

            
        }

        public float CircleX
        {
            get
            {
                float result = 0;
                float.TryParse(txtX.Text, out result);

                return result;
            }
        }

        public float CircleY
        {
            get
            {
                float result = 0;
                float.TryParse(txtCenterPointY.Text, out result);

                return result;
            }
        }

        public float CircleRadius
        {
            get
            {
                float result = 0;
                float.TryParse(txtRadius.Text, out result);

                return result;
            }
        }

        public void Clear()
        {
            txtX.Clear();
            txtCenterPointY.Clear();
            txtRadius.Clear();
        }
    }
}
