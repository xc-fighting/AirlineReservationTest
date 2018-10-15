using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airlineclientside
{
    public partial class addflight : Form
    {
        string adminID = null;
        public addflight(string id)
        {
            InitializeComponent();
            this.adminID = id;
        }
        public string getAdminID() {
            return adminID;
        }

        private void addflightbtn_Click(object sender, EventArgs e)
        {
            String departure_time = this.departuretimeinput.Text;
            String departure_place = this.departureplaceinput.Text;
            String arrival_time = this.arrivaltimeinput.Text;
            String arrival_place = this.arrivalplaceinput.Text;
            int seats = Int32.Parse(this.seatsinput.Text);
            int firstclassseats = Int32.Parse(this.firstclassinput.Text);
            int ecoclassseats = seats - firstclassseats;
            int pricefirst = Int32.Parse(this.pricefirstinput.Text);
            int priceeco = Int32.Parse(this.priceecoinput.Text);

            string content = "role:admin\taction:addFlight\tdeparturePlace:" + departure_place + "\tarrivalPlace:" + arrival_place
                + "\tdepartureTime:" + departure_time + "\tarrivalTime:" + arrival_time + "\tSeats:" + seats + "\tfirstSeats:" + firstclassseats
                + "\tecoSeats:" + ecoclassseats + "\tpriceFirstClass:" + pricefirst + "\tpriceEcoClass:" + priceeco;

            Network network = new Network(content);

            String result = network.getResult();
            if (result.Equals("success")) {
                MessageBox.Show("add the flight success");
            }
            


        }

        private void addflight_Load(object sender, EventArgs e)
        {
            this.adminidlabel.Text = this.adminID;
        }
    }
}
