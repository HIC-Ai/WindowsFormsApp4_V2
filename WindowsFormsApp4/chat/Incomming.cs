using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                return label1.Text;
            }
            set
            {
                label1.Text = value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {

        }

        public Image Avatar { get; set; }
    }
}
