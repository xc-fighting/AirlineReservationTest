namespace airlineclientside
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.registerbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.roleadmin = new System.Windows.Forms.RadioButton();
            this.rolecustomer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameinput = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(40, 255);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(111, 38);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(255, 255);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(108, 38);
            this.loginbtn.TabIndex = 1;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // roleadmin
            // 
            this.roleadmin.AutoSize = true;
            this.roleadmin.Location = new System.Drawing.Point(75, 180);
            this.roleadmin.Name = "roleadmin";
            this.roleadmin.Size = new System.Drawing.Size(53, 16);
            this.roleadmin.TabIndex = 2;
            this.roleadmin.TabStop = true;
            this.roleadmin.Text = "admin";
            this.roleadmin.UseVisualStyleBackColor = true;
            this.roleadmin.CheckedChanged += new System.EventHandler(this.roleadmin_CheckedChanged);
            // 
            // rolecustomer
            // 
            this.rolecustomer.AutoSize = true;
            this.rolecustomer.Location = new System.Drawing.Point(255, 180);
            this.rolecustomer.Name = "rolecustomer";
            this.rolecustomer.Size = new System.Drawing.Size(71, 16);
            this.rolecustomer.TabIndex = 3;
            this.rolecustomer.TabStop = true;
            this.rolecustomer.Text = "customer";
            this.rolecustomer.UseVisualStyleBackColor = true;
            this.rolecustomer.CheckedChanged += new System.EventHandler(this.rolecustomer_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "user name";
            // 
            // usernameinput
            // 
            this.usernameinput.Location = new System.Drawing.Point(215, 45);
            this.usernameinput.Name = "usernameinput";
            this.usernameinput.Size = new System.Drawing.Size(100, 21);
            this.usernameinput.TabIndex = 5;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(69, 98);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(113, 12);
            this.passwordlabel.TabIndex = 6;
            this.passwordlabel.Text = "password or realID";
            // 
            // passwordinput
            // 
            this.passwordinput.Location = new System.Drawing.Point(215, 98);
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.Size = new System.Drawing.Size(100, 21);
            this.passwordinput.TabIndex = 7;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 354);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernameinput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolecustomer);
            this.Controls.Add(this.roleadmin);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.registerbtn);
            this.Name = "login";
            this.Text = "airline_client";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.RadioButton roleadmin;
        private System.Windows.Forms.RadioButton rolecustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameinput;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox passwordinput;
    }
}

