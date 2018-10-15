namespace airlineclientside
{
    partial class customerregister
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
            this.usernameinput = new System.Windows.Forms.TextBox();
            this.firstnameinput = new System.Windows.Forms.TextBox();
            this.lastnameinput = new System.Windows.Forms.TextBox();
            this.ageinput = new System.Windows.Forms.TextBox();
            this.realidinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameinput
            // 
            this.usernameinput.Location = new System.Drawing.Point(420, 111);
            this.usernameinput.Name = "usernameinput";
            this.usernameinput.Size = new System.Drawing.Size(142, 21);
            this.usernameinput.TabIndex = 0;
            // 
            // firstnameinput
            // 
            this.firstnameinput.Location = new System.Drawing.Point(420, 170);
            this.firstnameinput.Name = "firstnameinput";
            this.firstnameinput.Size = new System.Drawing.Size(142, 21);
            this.firstnameinput.TabIndex = 1;
            // 
            // lastnameinput
            // 
            this.lastnameinput.Location = new System.Drawing.Point(420, 248);
            this.lastnameinput.Name = "lastnameinput";
            this.lastnameinput.Size = new System.Drawing.Size(142, 21);
            this.lastnameinput.TabIndex = 2;
            // 
            // ageinput
            // 
            this.ageinput.Location = new System.Drawing.Point(420, 306);
            this.ageinput.Name = "ageinput";
            this.ageinput.Size = new System.Drawing.Size(69, 21);
            this.ageinput.TabIndex = 3;
            // 
            // realidinput
            // 
            this.realidinput.Location = new System.Drawing.Point(420, 367);
            this.realidinput.Name = "realidinput";
            this.realidinput.Size = new System.Drawing.Size(142, 21);
            this.realidinput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "user name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "first name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "realID";
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(356, 449);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(75, 23);
            this.registerbtn.TabIndex = 10;
            this.registerbtn.Text = "register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // customerregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.realidinput);
            this.Controls.Add(this.ageinput);
            this.Controls.Add(this.lastnameinput);
            this.Controls.Add(this.firstnameinput);
            this.Controls.Add(this.usernameinput);
            this.Name = "customerregister";
            this.Text = "customerregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameinput;
        private System.Windows.Forms.TextBox firstnameinput;
        private System.Windows.Forms.TextBox lastnameinput;
        private System.Windows.Forms.TextBox ageinput;
        private System.Windows.Forms.TextBox realidinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registerbtn;
    }
}