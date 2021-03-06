using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4.chat
{
    public partial class Incomming : UserControl
    {
        public Incomming()
        {
            InitializeComponent();
        }
        public string Message
        {
            get
            {
                return Label3.Text;
            }

            set
            {
               Label3.Text = value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {
            gunaCirclePictureBox1.Location = new Point(4, 3);
            Label3.Height = utils.GetTextHeight(Label3) + 10;
            bunifuUserControl1.Height = Label3.Top + bunifuUserControl1.Top + Label3.Height;
            this.Height = bunifuUserControl1.Bottom + 10;

        }

        public Image Avatar { get => gunaCirclePictureBox1.Image; set => gunaCirclePictureBox1.Image = value; }

        private void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
