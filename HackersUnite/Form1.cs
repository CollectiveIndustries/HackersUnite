using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
            exitbutton.Location = new Point(1100, 500); //Sets Exit Button location
            exitbuttonlabel.Location = new Point(1030, 487); //Sets Exit Button label location
            agentloginbox.Location = new Point(500, 300); //Sets the Agent login Box location
            agentlist.Location = new Point(100, 230); //Sets the Agent List Box location
            newagentbutton.Location = new Point(1100, 450); //Sets the New Agent Button location
            newagentlabel.Location = new Point(960, 437); //Sets the New Agent Label location
            createagentbox.Visible = false; //Sets the Create Agent Box invisable
            newagentcancellabel.Visible = false; //Sets the New Agent Cancel Label invisable
            newagentcancelbutton.Visible = false; //Sets the New Agent Cancel button invisable
            newagentcancelbutton.Location = new Point(1100, 450); //Sets the New Agent Cancel button location
            newagentcancellabel.Location = new Point(1000, 437); //Sets the New Agent Cancel label location
            createagentbox.Location = new Point(500, 300); //Sets the Create Agent Box location
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close(); //Closes the Window
        }

        private void newagentbutton_Click(object sender, EventArgs e)
        {
            agentlist.Visible = false; //Sets the Agent List invisable
            agentloginbox.Visible = false; //Sets the Agent Login Box invisable
            newagentbutton.Visible = false; //Sets the New Agent Button invisable
            newagentlabel.Visible = false; //Sets the New Agent Button Label invisable
            newagentcancelbutton.Visible = true; //Sets the New Agent Cancel button visable
            newagentcancellabel.Visible = true; //Sets the New Agent Cancel Label visable
            createagentbox.Visible = true; //Sets the Create Agent Box visable            
        }

        private void newagentcancelbutton_Click(object sender, EventArgs e)
        {
            agentlist.Visible = true; //Sets the Agent List visable
            agentloginbox.Visible = true; //Sets the Agent Login Box visable
            newagentbutton.Visible = true; //Sets the New Agent Button visable
            newagentlabel.Visible = true; //Sets the New Agent Button Label visable
            newagentcancelbutton.Visible = false; //Sets the New Agent Cancel button invisable
            newagentcancellabel.Visible = false; //Sets the New Agent Cancel Label invisable
            createagentbox.Visible = false; //Sets the Create Agent Box invisable
            createusername.Text = "";
            createpassword.Text = "";
            createconfirmpassword.Text = "";
        }

        private void createagentbutton_Click(object sender, EventArgs e)
        {
            string causer;
            string capass;
            causer = createusername.Text; //Sets causer variable from creatusername textbox
            if (createpassword.Text == createconfirmpassword.Text) //Checks to see if the passwords match
            {
                capass = createpassword.Text; //If passwords match then sets the variable from createpassword textbox
                File.WriteAllText("agents/" + causer + ".hu", "Name:" + causer + "\r\n Password:" + capass + "\r\n Level:Newbie \r\n Money:5000c");
            }
            else //If the passwords do not match
            {
                createagenterror.Text = "Your password did not match."; //Sets createagenterror label
            }
        }

        private void createusername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
