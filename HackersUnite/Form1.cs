using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackersUnite
{
    public partial class HackersUnite : Form
    {
        public HackersUnite()
        {
            InitializeComponent();
        }

        private void HackersUnite_Load(object sender, EventArgs e)
        {
             /*****************************************
             * Section Sets Window to Fullscreen Mode *
             *****************************************/
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.BackColor = ColorTranslator.FromHtml("#181818"); //Sets the background to Charcoal
            exitbutton.Location = new Point(1100, 500); //Sets exit button location
            exitbuttonlabel.Location = new Point(1030, 487); //Sets exit button label location
            agentloginbox.Location = new Point(500, 300); //Sets the Agent login Box location
            agentlist.Location = new Point(100, 230); //Sets the Agent List Box location
            newagentbutton.Location = new Point(1100, 450); //Sets the New Agent Button location
            newagentlabel.Location = new Point(960, 437); //Sets the New Agent Label location
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close(); //Closes the Window
        }
    }
}
