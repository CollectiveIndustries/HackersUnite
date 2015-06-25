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

            /***********************************
            * Checks to see if agent subfolder *
            * exists. If not then create       *
            ***********************************/
            string path = @"agents";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            /************************************/
        }

        private void HackersUnite_Load(object sender, EventArgs e)
        {
            /*****************************************
            * Section Sets Window to Fullscreen Mode *
            *****************************************/
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            /********************************************/

            this.BackColor = Color.Black; //Sets the background to Black
            exitbutton.Location = new Point(1100, 500); //Sets Exit Button location
            exitbuttonlabel.Location = new Point(1030, 487); //Sets Exit Button label location
            agentloginbox.Location = new Point(500, 300); //Sets the Agent login Box location
            agentlist.Location = new Point(100, 230); //Sets the Agent List Box location
            newagentbutton.Location = new Point(1100, 400); //Sets the New Agent Button location
            newagentlabel.Location = new Point(960, 387); //Sets the New Agent Label location
            createagentbox.Visible = false; //Sets the Create Agent Box invisable
            newagentcancellabel.Visible = false; //Sets the New Agent Cancel Label invisable
            newagentcancelbutton.Visible = false; //Sets the New Agent Cancel button invisable
            newagentcancelbutton.Location = new Point(1100, 450); //Sets the New Agent Cancel button location
            newagentcancellabel.Location = new Point(1000, 437); //Sets the New Agent Cancel label location
            createagentbox.Location = new Point(500, 300); //Sets the Create Agent Box location
            programversion.Location = new Point(1280, 740); //Sets the Version Number Label location
            deleteagentbutton.Location = new Point(1100, 450); //Sets the Resign Agent button location
            deleteagentlabel.Location = new Point(1005, 437); //Sets the Resign Agent label location
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
            deleteagentlabel.Visible = false; //Sets the Resign Agent label invisable
            deleteagentbutton.Visible = false; //Sets the Resign Agent button invisable
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
            createusername.Text = ""; //Rests the Create Agent Username textbox
            createpassword.Text = ""; //Resets the Create Agent Password textbox
            createconfirmpassword.Text = ""; //Resets the Create Agent Confirm Password textbox
            createagenterror.Text = ""; //Resets the createagenterror label
            deleteagentbutton.Visible = true; //Sets Resign Agent button visable
            deleteagentlabel.Visible = true; //Sets Resign Agent label visable
        }

        private void createagentbutton_Click(object sender, EventArgs e)
        {
            string causer;
            string capass;
            causer = createusername.Text; //Sets causer variable from creatusername textbox
            if (createpassword.Text == createconfirmpassword.Text) //Checks to see if the passwords match
            {
                capass = createpassword.Text; //If passwords match then sets the variable from createpassword textbox
                
                string lines = "name:" + causer + "\r\npassword:" + capass + "\r\nlevel:newbie \r\nmoney:5000c"; //Sets string with info that is going in the saved game file

                /**************************
                * Writes string to a file *
                **************************/
               string curFile = GlobalVariable.savePath + causer + ".hu";

                if (!File.Exists(curFile)) //Checks to see if file exists
                {
                    /*using (FileStream stream = new FileStream(curFile, FileMode.Create))
                    {
                        using (BinaryWriter writer = new BinaryWriter(stream))
                        {
                            writer.Write("name:" + causer);
                            writer.Write("password:" + capass);
                            writer.Write("level:newbie");
                            writer.Write("money:5000c");
                        }
                    }*/

                    StreamWriter file = new StreamWriter(GlobalVariable.savePath + causer + ".hu");
                    file.WriteLine(lines);
                    file.Close();

                    /********************************
                    * Converts Saved Game to binary *
                    ********************************/
                    FileStream fs = new FileStream(GlobalVariable.savePath + causer + ".hu", FileMode.Create);
                    BinaryWriter w = new BinaryWriter(fs);
                    for (int i = 0; i < 100; i++)
                    {
                        w.Write((int)i);
                    }
                    w.Close();
                    fs.Close();
                    fs = new FileStream(GlobalVariable.savePath + causer + ".hu", FileMode.Open, FileAccess.Read);
                    BinaryReader r = new BinaryReader(fs);
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(r.ReadInt32());
                    }
                    r.Close();
                    fs.Close();
                    Console.WriteLine(Console.Read());
                    /********************************************************************************/

                    agentlist.Visible = true; //Sets the Agent List visable
                    agentloginbox.Visible = true; //Sets the Agent Login Box visable
                    newagentbutton.Visible = true; //Sets the New Agent Button visable
                    newagentlabel.Visible = true; //Sets the New Agent Button Label visable
                    newagentcancelbutton.Visible = false; //Sets the New Agent Cancel button invisable
                    newagentcancellabel.Visible = false; //Sets the New Agent Cancel Label invisable
                    createagentbox.Visible = false; //Sets the Create Agent Box invisable
                    createusername.Text = ""; //Rests the Create Agent Username textbox
                    createpassword.Text = ""; //Resets the Create Agent Password textbox
                    createconfirmpassword.Text = ""; //Resets the Create Agent Confirm Password textbox
                    createagenterror.Text = ""; //Resets the createagenterror label
                    deleteagentbutton.Visible = true; //Sets Resign Agent button visable
                    deleteagentlabel.Visible = true; //Sets Resign Agent label visable
                }
                if (File.Exists(curFile))
                {
                    createagenterror.Text = "You are already registered as an Agent.";
                }
                /******************************************************************/
            }
            else //If the passwords do not match
            {
                createagenterror.Text = "Your password did not match."; //Sets createagenterror label
            }
        }

        private static string[] GetFileNames(string filePath, string filter) // Searches directory for all the files within the filter
        {
            string[] files = Directory.GetFiles(filePath, filter);
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileNameWithoutExtension(files[i]);
            }
            return files;
        }

        private void createusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void agentlist_Enter(object sender, EventArgs e)
        {
            /******************************************
            * Places the File names in the Agent List *
            ******************************************/
            string path = @"agents\";
            if (Directory.Exists(path))
            {
                string[] huFiles = GetFileNames(path, "*.hu");
                agentnamelist.DataSource = huFiles;
            }
            /*************************************************/
        }

        public class GlobalVariable
        {
            public static object curAgent;
            public static string savePath = @"agents\"; // Sets the saved game directory path
            public static string name;
            public static string pass;
        }

        public void Debug(bool debug, string msg)
        {
            if(debug)
            {
                debuglabel.Text = msg;
            }
        }

        private void agentnamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVariable.curAgent = agentnamelist.SelectedItem;
            using (StringReader sr = new StringReader((string)GlobalVariable.curAgent))
            {
                string[] load = Directory.GetFiles(GlobalVariable.savePath + GlobalVariable.curAgent, ".hu");
                string line;
                int i = 0;
                for (i = 0; i >= 0; i++)
                {
                    if (i == 0)
                    {
                        line = sr.ReadLine();
                        //username.Text = line;
                        Debug(true, line);
                    }
                }                
            }
        }

        private void deleteagentbutton_Click(object sender, EventArgs e)
        {
            File.Delete(@"agents\" + (string)GlobalVariable.curAgent + ".hu");
            agentnamelist.Refresh();
        }
    }
}
