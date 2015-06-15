namespace HackersUnite
{
    partial class HackersUnite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitbutton = new System.Windows.Forms.Button();
            this.exitbuttonlabel = new System.Windows.Forms.Label();
            this.agentloginbox = new System.Windows.Forms.GroupBox();
            this.agentloginboxlabel = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.Label();
            this.passwordtext = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.agentlist = new System.Windows.Forms.GroupBox();
            this.newagentbutton = new System.Windows.Forms.Button();
            this.newagentlabel = new System.Windows.Forms.Label();
            this.agentlistlabel = new System.Windows.Forms.Label();
            this.createagentbox = new System.Windows.Forms.GroupBox();
            this.createagentlabel = new System.Windows.Forms.Label();
            this.newagentcancelbutton = new System.Windows.Forms.Button();
            this.newagentcancellabel = new System.Windows.Forms.Label();
            this.createusernamelabel = new System.Windows.Forms.Label();
            this.createpasswordlabel = new System.Windows.Forms.Label();
            this.createconfirmpasswordlabel = new System.Windows.Forms.Label();
            this.createusername = new System.Windows.Forms.TextBox();
            this.createpassword = new System.Windows.Forms.TextBox();
            this.createconfirmpassword = new System.Windows.Forms.TextBox();
            this.createagentbutton = new System.Windows.Forms.Button();
            this.createagenterror = new System.Windows.Forms.Label();
            this.agentloginbox.SuspendLayout();
            this.agentlist.SuspendLayout();
            this.createagentbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(923, 283);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(35, 35);
            this.exitbutton.TabIndex = 0;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // exitbuttonlabel
            // 
            this.exitbuttonlabel.AutoSize = true;
            this.exitbuttonlabel.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbuttonlabel.ForeColor = System.Drawing.Color.White;
            this.exitbuttonlabel.Location = new System.Drawing.Point(853, 267);
            this.exitbuttonlabel.Name = "exitbuttonlabel";
            this.exitbuttonlabel.Size = new System.Drawing.Size(64, 59);
            this.exitbuttonlabel.TabIndex = 1;
            this.exitbuttonlabel.Text = "Exit";
            this.exitbuttonlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // agentloginbox
            // 
            this.agentloginbox.BackColor = System.Drawing.Color.Gray;
            this.agentloginbox.Controls.Add(this.login);
            this.agentloginbox.Controls.Add(this.password);
            this.agentloginbox.Controls.Add(this.username);
            this.agentloginbox.Controls.Add(this.passwordtext);
            this.agentloginbox.Controls.Add(this.usernametext);
            this.agentloginbox.Controls.Add(this.agentloginboxlabel);
            this.agentloginbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agentloginbox.Location = new System.Drawing.Point(373, 190);
            this.agentloginbox.Name = "agentloginbox";
            this.agentloginbox.Size = new System.Drawing.Size(350, 150);
            this.agentloginbox.TabIndex = 2;
            this.agentloginbox.TabStop = false;
            // 
            // agentloginboxlabel
            // 
            this.agentloginboxlabel.AutoSize = true;
            this.agentloginboxlabel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentloginboxlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.agentloginboxlabel.Location = new System.Drawing.Point(76, 0);
            this.agentloginboxlabel.Name = "agentloginboxlabel";
            this.agentloginboxlabel.Size = new System.Drawing.Size(191, 35);
            this.agentloginboxlabel.TabIndex = 0;
            this.agentloginboxlabel.Text = "Authorized Personal Only";
            // 
            // usernametext
            // 
            this.usernametext.AutoSize = true;
            this.usernametext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametext.Location = new System.Drawing.Point(6, 52);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(70, 19);
            this.usernametext.TabIndex = 1;
            this.usernametext.Text = "Username";
            // 
            // passwordtext
            // 
            this.passwordtext.AutoSize = true;
            this.passwordtext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtext.Location = new System.Drawing.Point(6, 93);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(69, 19);
            this.passwordtext.TabIndex = 2;
            this.passwordtext.Text = "Password";
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Location = new System.Drawing.Point(82, 56);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(150, 13);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Location = new System.Drawing.Point(82, 97);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(150, 13);
            this.password.TabIndex = 4;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(269, 121);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            // 
            // agentlist
            // 
            this.agentlist.Controls.Add(this.agentlistlabel);
            this.agentlist.Location = new System.Drawing.Point(12, 40);
            this.agentlist.Name = "agentlist";
            this.agentlist.Size = new System.Drawing.Size(200, 300);
            this.agentlist.TabIndex = 3;
            this.agentlist.TabStop = false;
            // 
            // newagentbutton
            // 
            this.newagentbutton.Location = new System.Drawing.Point(923, 242);
            this.newagentbutton.Name = "newagentbutton";
            this.newagentbutton.Size = new System.Drawing.Size(35, 35);
            this.newagentbutton.TabIndex = 4;
            this.newagentbutton.UseVisualStyleBackColor = true;
            this.newagentbutton.Click += new System.EventHandler(this.newagentbutton_Click);
            // 
            // newagentlabel
            // 
            this.newagentlabel.AutoSize = true;
            this.newagentlabel.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newagentlabel.ForeColor = System.Drawing.Color.White;
            this.newagentlabel.Location = new System.Drawing.Point(783, 218);
            this.newagentlabel.Name = "newagentlabel";
            this.newagentlabel.Size = new System.Drawing.Size(134, 59);
            this.newagentlabel.TabIndex = 5;
            this.newagentlabel.Text = "New Agent";
            this.newagentlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // agentlistlabel
            // 
            this.agentlistlabel.AutoSize = true;
            this.agentlistlabel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentlistlabel.ForeColor = System.Drawing.Color.White;
            this.agentlistlabel.Location = new System.Drawing.Point(74, -12);
            this.agentlistlabel.Name = "agentlistlabel";
            this.agentlistlabel.Size = new System.Drawing.Size(62, 35);
            this.agentlistlabel.TabIndex = 6;
            this.agentlistlabel.Text = "Agents";
            this.agentlistlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createagentbox
            // 
            this.createagentbox.BackColor = System.Drawing.Color.Gray;
            this.createagentbox.Controls.Add(this.createagenterror);
            this.createagentbox.Controls.Add(this.createagentbutton);
            this.createagentbox.Controls.Add(this.createconfirmpassword);
            this.createagentbox.Controls.Add(this.createpassword);
            this.createagentbox.Controls.Add(this.createusername);
            this.createagentbox.Controls.Add(this.createconfirmpasswordlabel);
            this.createagentbox.Controls.Add(this.createpasswordlabel);
            this.createagentbox.Controls.Add(this.createusernamelabel);
            this.createagentbox.Controls.Add(this.createagentlabel);
            this.createagentbox.Location = new System.Drawing.Point(642, 34);
            this.createagentbox.Name = "createagentbox";
            this.createagentbox.Size = new System.Drawing.Size(350, 150);
            this.createagentbox.TabIndex = 6;
            this.createagentbox.TabStop = false;
            // 
            // createagentlabel
            // 
            this.createagentlabel.AutoSize = true;
            this.createagentlabel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createagentlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.createagentlabel.Location = new System.Drawing.Point(117, 0);
            this.createagentlabel.Name = "createagentlabel";
            this.createagentlabel.Size = new System.Drawing.Size(104, 35);
            this.createagentlabel.TabIndex = 0;
            this.createagentlabel.Text = "Create Agent";
            // 
            // newagentcancelbutton
            // 
            this.newagentcancelbutton.Location = new System.Drawing.Point(923, 201);
            this.newagentcancelbutton.Name = "newagentcancelbutton";
            this.newagentcancelbutton.Size = new System.Drawing.Size(35, 35);
            this.newagentcancelbutton.TabIndex = 7;
            this.newagentcancelbutton.UseVisualStyleBackColor = true;
            this.newagentcancelbutton.Click += new System.EventHandler(this.newagentcancelbutton_Click);
            // 
            // newagentcancellabel
            // 
            this.newagentcancellabel.AutoSize = true;
            this.newagentcancellabel.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newagentcancellabel.ForeColor = System.Drawing.Color.White;
            this.newagentcancellabel.Location = new System.Drawing.Point(783, 177);
            this.newagentcancellabel.Name = "newagentcancellabel";
            this.newagentcancellabel.Size = new System.Drawing.Size(92, 59);
            this.newagentcancellabel.TabIndex = 8;
            this.newagentcancellabel.Text = "Cancel";
            this.newagentcancellabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createusernamelabel
            // 
            this.createusernamelabel.AutoSize = true;
            this.createusernamelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createusernamelabel.Location = new System.Drawing.Point(11, 31);
            this.createusernamelabel.Name = "createusernamelabel";
            this.createusernamelabel.Size = new System.Drawing.Size(70, 19);
            this.createusernamelabel.TabIndex = 6;
            this.createusernamelabel.Text = "Username";
            // 
            // createpasswordlabel
            // 
            this.createpasswordlabel.AutoSize = true;
            this.createpasswordlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createpasswordlabel.Location = new System.Drawing.Point(12, 60);
            this.createpasswordlabel.Name = "createpasswordlabel";
            this.createpasswordlabel.Size = new System.Drawing.Size(69, 19);
            this.createpasswordlabel.TabIndex = 6;
            this.createpasswordlabel.Text = "Password";
            // 
            // createconfirmpasswordlabel
            // 
            this.createconfirmpasswordlabel.AutoSize = true;
            this.createconfirmpasswordlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createconfirmpasswordlabel.Location = new System.Drawing.Point(12, 89);
            this.createconfirmpasswordlabel.Name = "createconfirmpasswordlabel";
            this.createconfirmpasswordlabel.Size = new System.Drawing.Size(122, 19);
            this.createconfirmpasswordlabel.TabIndex = 7;
            this.createconfirmpasswordlabel.Text = "Confirm Password";
            // 
            // createusername
            // 
            this.createusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createusername.Location = new System.Drawing.Point(140, 35);
            this.createusername.Name = "createusername";
            this.createusername.Size = new System.Drawing.Size(150, 13);
            this.createusername.TabIndex = 6;
            this.createusername.TextChanged += new System.EventHandler(this.createusername_TextChanged);
            // 
            // createpassword
            // 
            this.createpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createpassword.Location = new System.Drawing.Point(140, 64);
            this.createpassword.Name = "createpassword";
            this.createpassword.PasswordChar = '*';
            this.createpassword.Size = new System.Drawing.Size(150, 13);
            this.createpassword.TabIndex = 8;
            // 
            // createconfirmpassword
            // 
            this.createconfirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createconfirmpassword.Location = new System.Drawing.Point(140, 93);
            this.createconfirmpassword.Name = "createconfirmpassword";
            this.createconfirmpassword.PasswordChar = '*';
            this.createconfirmpassword.Size = new System.Drawing.Size(150, 13);
            this.createconfirmpassword.TabIndex = 9;
            // 
            // createagentbutton
            // 
            this.createagentbutton.Location = new System.Drawing.Point(264, 121);
            this.createagentbutton.Name = "createagentbutton";
            this.createagentbutton.Size = new System.Drawing.Size(80, 23);
            this.createagentbutton.TabIndex = 6;
            this.createagentbutton.Text = "Create Agent";
            this.createagentbutton.UseVisualStyleBackColor = true;
            this.createagentbutton.Click += new System.EventHandler(this.createagentbutton_Click);
            // 
            // createagenterror
            // 
            this.createagenterror.AutoSize = true;
            this.createagenterror.ForeColor = System.Drawing.Color.Red;
            this.createagenterror.Location = new System.Drawing.Point(12, 126);
            this.createagenterror.Name = "createagenterror";
            this.createagenterror.Size = new System.Drawing.Size(0, 13);
            this.createagenterror.TabIndex = 10;
            // 
            // HackersUnite
            // 
            this.AccessibleName = "HackersUnite";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 352);
            this.Controls.Add(this.newagentcancellabel);
            this.Controls.Add(this.newagentcancelbutton);
            this.Controls.Add(this.createagentbox);
            this.Controls.Add(this.newagentlabel);
            this.Controls.Add(this.newagentbutton);
            this.Controls.Add(this.agentlist);
            this.Controls.Add(this.agentloginbox);
            this.Controls.Add(this.exitbuttonlabel);
            this.Controls.Add(this.exitbutton);
            this.Name = "HackersUnite";
            this.Text = "Hackers Unite";
            this.Load += new System.EventHandler(this.HackersUnite_Load);
            this.agentloginbox.ResumeLayout(false);
            this.agentloginbox.PerformLayout();
            this.agentlist.ResumeLayout(false);
            this.agentlist.PerformLayout();
            this.createagentbox.ResumeLayout(false);
            this.createagentbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label exitbuttonlabel;
        private System.Windows.Forms.GroupBox agentloginbox;
        private System.Windows.Forms.Label agentloginboxlabel;
        private System.Windows.Forms.Label passwordtext;
        private System.Windows.Forms.Label usernametext;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.GroupBox agentlist;
        private System.Windows.Forms.Button newagentbutton;
        private System.Windows.Forms.Label newagentlabel;
        private System.Windows.Forms.Label agentlistlabel;
        private System.Windows.Forms.GroupBox createagentbox;
        private System.Windows.Forms.Label createagentlabel;
        private System.Windows.Forms.Button newagentcancelbutton;
        private System.Windows.Forms.Label newagentcancellabel;
        private System.Windows.Forms.Button createagentbutton;
        private System.Windows.Forms.TextBox createconfirmpassword;
        private System.Windows.Forms.TextBox createpassword;
        private System.Windows.Forms.TextBox createusername;
        private System.Windows.Forms.Label createconfirmpasswordlabel;
        private System.Windows.Forms.Label createpasswordlabel;
        private System.Windows.Forms.Label createusernamelabel;
        private System.Windows.Forms.Label createagenterror;
    }
}

