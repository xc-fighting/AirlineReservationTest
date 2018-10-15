namespace airlineclientside
{
    partial class availableflights
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
            this.customeridlable = new System.Windows.Forms.Label();
            this.selectseatbtn = new System.Windows.Forms.Button();
            this.availablelist = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome,customer:";
            // 
            // customeridlable
            // 
            this.customeridlable.AutoSize = true;
            this.customeridlable.Location = new System.Drawing.Point(263, 22);
            this.customeridlable.Name = "customeridlable";
            this.customeridlable.Size = new System.Drawing.Size(41, 12);
            this.customeridlable.TabIndex = 1;
            this.customeridlable.Text = "label2";
            // 
            // selectseatbtn
            // 
            this.selectseatbtn.Location = new System.Drawing.Point(971, 176);
            this.selectseatbtn.Name = "selectseatbtn";
            this.selectseatbtn.Size = new System.Drawing.Size(161, 63);
            this.selectseatbtn.TabIndex = 3;
            this.selectseatbtn.Text = "SELECT SEAT";
            this.selectseatbtn.UseVisualStyleBackColor = true;
            this.selectseatbtn.Click += new System.EventHandler(this.selectseatbtn_Click);
            // 
            // availablelist
            // 
            this.availablelist.Location = new System.Drawing.Point(13, 48);
            this.availablelist.Name = "availablelist";
            this.availablelist.Size = new System.Drawing.Size(952, 447);
            this.availablelist.TabIndex = 4;
            this.availablelist.UseCompatibleStateImageBehavior = false;
            this.availablelist.SelectedIndexChanged += new System.EventHandler(this.availablelist_SelectedIndexChanged);
            // 
            // availableflights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 507);
            this.Controls.Add(this.availablelist);
            this.Controls.Add(this.selectseatbtn);
            this.Controls.Add(this.customeridlable);
            this.Controls.Add(this.label1);
            this.Name = "availableflights";
            this.Text = "availableflights";
            this.Load += new System.EventHandler(this.availableflights_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customeridlable;
        private System.Windows.Forms.Button selectseatbtn;
        private System.Windows.Forms.ListView availablelist;
    }
}