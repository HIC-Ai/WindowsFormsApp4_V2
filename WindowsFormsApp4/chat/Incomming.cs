﻿using System;
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
                return Label1.Text;
            }

            set
            {
               Label1.Text = value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {
            gunaCirclePictureBox1.Location = new Point(4, 3);
            Label1.Height = utils.GetTextHeight(Label1) + 10;
            bunifuUserControl1.Height = Label1.Top + bunifuUserControl1.Top + Label1.Height;
            this.Height = bunifuUserControl1.Bottom + 10;

        }

        public Image Avatar { get => gunaCirclePictureBox1.Image; set => gunaCirclePictureBox1.Image = value; }

        private void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void Incomming_Load(object sender, EventArgs e)
        {

        }
    }
}
