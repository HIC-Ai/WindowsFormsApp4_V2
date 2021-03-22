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
            send();
        }


        void send()
        {
            if (bunifuTextBox1.Text.Trim().Length == 0) return;
            AddOutgoing(bunifuTextBox1.Text);
            bunifuTextBox1.Text = string.Empty;
            Label5.Text = "typing...";
            timer1.Start();
        }

        void AddIncomming(string message)
        {
            chat.Incomming bubble = new chat.Incomming();
            PnlContainer.Controls.Add(value: bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
        }

        void AddOutgoing(string message)
        {
            var bubble = new chat.Outgoing();
            PnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            bubble.Focus();
        }

      

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Return)
            {
                
               AddOutgoing(bunifuTextBox1.Text);
                bunifuTextBox1.Text = string.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Label5.Text = "OOFline";
            AddIncomming("Sorry,I don't Know the answer");
        }

        

        private void Form2_Shown(object sender, EventArgs e)
        {
            AddIncomming("Hello" +Environment.UserName+", Ask anything :).");
        }
    }
}
