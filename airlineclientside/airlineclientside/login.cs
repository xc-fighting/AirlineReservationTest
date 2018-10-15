using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airlineclientside
{
    public partial class login : Form
    {
        private String role = "admin";
        public login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            String pwd = this.passwordinput.Text;
            String username = this.usernameinput.Text;

            //  MessageBox.Show(username + " " + pwd + " " + role);
            /*  Thread thr = new Thread(
                  delegate () {
                      new availableflights().ShowDialog();

                  }

             );
              thr.Start();
              this.Close();*/
            String content = null;
            if (role.Equals("admin"))
            {
                content = "role:admin\taction:login\tpassword:" + pwd + "\tusername:" + username;
            }
            else {
                content= "role:customer\taction:login\trealID:" + pwd + "\tusername:" + username;
            }
            Network network = new Network(content);
            String result = network.getResult();
            if (result.Equals("failure"))
            {
                MessageBox.Show("Login Fail,Check username or password");
                this.passwordinput.Text = "";
                this.usernameinput.Text = "";
            }
            else {
                String[] group = result.Split(';');
                if (role.Equals("admin"))
                {
                  //  MessageBox.Show(group[1]);
                    new addflight(group[1]).Show();
                }
                else {
                  //  MessageBox.Show(group[1]);
                    new availableflights(group[1]).Show();
                }

            }
          
     
        }

        private void roleadmin_CheckedChanged(object sender, EventArgs e)
        {
            role = "admin";
        }

        private void rolecustomer_CheckedChanged(object sender, EventArgs e)
        {
            role = "customer";
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (role.Equals("admin"))
            {
                new adminregister().Show();
            }
            else {
                new customerregister().Show();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
