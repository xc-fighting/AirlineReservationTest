namespace airlineclientside
{
    partial class SelectSeat
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
            this.firstclasslistview = new System.Windows.Forms.ListView();
            this.ecoclasslistview = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.orderbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Class Seats";
            // 
            // firstclasslistview
            // 
            this.firstclasslistview.Location = new System.Drawing.Point(46, 50);
            this.firstclasslistview.Name = "firstclasslistview";
            this.firstclasslistview.Size = new System.Drawing.Size(115, 624);
            this.firstclasslistview.TabIndex = 1;
            this.firstclasslistview.UseCompatibleStateImageBehavior = false;
            this.firstclasslistview.SelectedIndexChanged += new System.EventHandler(this.firstclasslistview_SelectedIndexChanged);
            // 
            // ecoclasslistview
            // 
            this.ecoclasslistview.Location = new System.Drawing.Point(328, 50);
            this.ecoclasslistview.Name = "ecoclasslistview";
            this.ecoclasslistview.Size = new System.Drawing.Size(121, 614);
            this.ecoclasslistview.TabIndex = 2;
            this.ecoclasslistview.UseCompatibleStateImageBehavior = false;
            this.ecoclasslistview.SelectedIndexChanged += new System.EventHandler(this.ecoclasslistview_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "eco class seats";
            // 
            // orderbtn
            // 
            this.orderbtn.Location = new System.Drawing.Point(574, 205);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(152, 120);
            this.orderbtn.TabIndex = 4;
            this.orderbtn.Text = "ORDER NOW";
            this.orderbtn.UseVisualStyleBackColor = true;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // SelectSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 686);
            this.Controls.Add(this.orderbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ecoclasslistview);
            this.Controls.Add(this.firstclasslistview);
            this.Controls.Add(this.label1);
            this.Name = "SelectSeat";
            this.Text = "SelectSeat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView firstclasslistview;
        private System.Windows.Forms.ListView ecoclasslistview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button orderbtn;
    }
}