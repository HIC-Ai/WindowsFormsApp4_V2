using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        [Obsolete]
        public Form2()
        {
            InitializeComponent();
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AddOutgoing(txtMessage.Text);
            txtMessage.Text = string.Empty;
        }

        void AddIncomming(string message)
        {
            var bubble = new chat.Incomming();
            PnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        void AddOutgoing(string message)
        {
            var bubble = new chat.Incomming();
            PnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
