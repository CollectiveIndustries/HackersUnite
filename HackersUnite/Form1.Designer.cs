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
            this.agentloginbox.SuspendLayout();
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
            this.agentloginboxlabel.Location = new System.Drawing.Point(88, 16);
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
            // HackersUnite
            // 
            this.AccessibleName = "HackersUnite";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 352);
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
    }
}

