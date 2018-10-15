namespace airlineclientside
{
    partial class adminregister
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstnameinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastnameinput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameinput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "first name";
            // 
            // firstnameinput
            // 
            this.firstnameinput.Location = new System.Drawing.Point(332, 62);
            this.firstnameinput.Name = "firstnameinput";
            this.firstnameinput.Size = new System.Drawing.Size(127, 21);
            this.firstnameinput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "last name";
            // 
            // lastnameinput
            // 
            this.lastnameinput.Location = new System.Drawing.Point(332, 102);
            this.lastnameinput.Name = "lastnameinput";
            this.lastnameinput.Size = new System.Drawing.Size(127, 21);
            this.lastnameinput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "username";
            // 
            // usernameinput
            // 
            this.usernameinput.Location = new System.Drawing.Point(332, 153);
            this.usernameinput.Name = "usernameinput";
            this.usernameinput.Size = new System.Drawing.Size(127, 21);
            this.usernameinput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "password";
            // 
            // passwordinput
            // 
            this.passwordinput.Location = new System.Drawing.Point(332, 216);
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.Size = new System.Drawing.Size(127, 21);
            this.passwordinput.TabIndex = 7;
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(292, 301);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(88, 23);
            this.registerbtn.TabIndex = 8;
            this.registerbtn.Text = "register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // adminregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 517);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernameinput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastnameinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnameinput);
            this.Controls.Add(this.label1);
            this.Name = "adminregister";
            this.Text = "adminregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstnameinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnameinput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameinput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordinput;
        private System.Windows.Forms.Button registerbtn;
    }
}