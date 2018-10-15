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
    public partial class customerregister : Form
    {
        public customerregister()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string username = this.usernameinput.Text;
            string lastname = this.lastnameinput.Text;
            string firstname = this.firstnameinput.Text;
            string age = this.ageinput.Text;
            string realID = this.realidinput.Text;
            string content = "role:customer\taction:register\tfirstname:" + firstname + "\tlastname:" + lastname + "\tusername:" + username + "\trealID:" + realID + "\tage:" + age;
            Network network = new Network(content);
            String result = network.getResult();
            if (result.Equals("success"))
            {
                MessageBox.Show("customer register success");
            }
            else {
                MessageBox.Show("customer regiser fail,duplicate record");
            }
        }
    }
}
