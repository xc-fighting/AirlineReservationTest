using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airlineclientside
{
    public partial class adminregister : Form
    {
        public adminregister()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string username = usernameinput.Text;
            string password = passwordinput.Text;
            string lastname = lastnameinput.Text;
            string firstname = firstnameinput.Text;

            string content = "role:admin\taction:register\tfirstname:" + firstname + "\tlastname:" + lastname + "\tpassword:" + password + "\tusername:" + username;
            Network network = new Network(content);
            string result = network.getResult();

            if (result.Equals("fail"))
            {
                MessageBox.Show("admin register failed,record duplicate");
            }
            else {
                MessageBox.Show("admin register success");
            }
        }
    }
}
