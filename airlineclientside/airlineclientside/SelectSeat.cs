using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace airlineclientside
{
    public partial class SelectSeat : Form
    {
        private string customerID;
        private string flightID;
        string[] first_class_seats;
        string[] eco_class_seats;
        string seatType;
        string seatNumber;
        ListViewItem selected_listview_item;
        Boolean alreadyOrdered = false;
        public SelectSeat(string cid,string fid)
        {
            InitializeComponent();
            this.customerID = cid;
            this.flightID = fid;
            string content = "role:customer\taction:selectSeat\tflightID:" + flightID;
            Network network = new Network(content);
            string xmlresult = network.getResult();
            //MessageBox.Show(xmlresult);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlresult);
            XmlNodeList firstxmllist = doc.GetElementsByTagName("firstclass");
            XmlNodeList ecoxmllist = doc.GetElementsByTagName("ecoclass");
            XmlNode firstseatroot = firstxmllist.Item(0);
            XmlNode ecoseatroot = ecoxmllist.Item(0);

            XmlNodeList seatlist_first = firstseatroot.ChildNodes;
            XmlNodeList seatlist_eco = ecoseatroot.ChildNodes;

            first_class_seats=new string[seatlist_first.Count];
            eco_class_seats = new string[seatlist_eco.Count];

            int index = 0;
            foreach (XmlNode seat in seatlist_first) {
                first_class_seats[index] = (index+1)+":"+seat.InnerText;
                index++;
            }
            int i = 0;
            foreach (XmlNode seat in seatlist_eco) {
                eco_class_seats[i] = (index + 1) + ":" + seat.InnerText;
                index++;
                i++;
            }

            this.firstclasslistview.View = View.Details;
            this.firstclasslistview.GridLines = true;
            this.firstclasslistview.FullRowSelect = true;
            ColumnHeader header = new ColumnHeader();
            header.Width = 150;
            header.Text = "SEAT NO:OCCUPIED";
            this.firstclasslistview.Columns.Add(header);
            for (int j = 0; j < first_class_seats.Length; j++) {
                ListViewItem rowitem = new ListViewItem();
                string[] tuple = first_class_seats[j].Split(':');
                if (tuple[1].Equals("0"))
                {
                    rowitem.Text = tuple[0] + ":" + "O";
                }
                else {
                    rowitem.Text = tuple[0] + ":" + "X";
                }
                this.firstclasslistview.Items.Add(rowitem);

            }


            this.ecoclasslistview.View = View.Details;
            this.ecoclasslistview.GridLines = true;
            this.ecoclasslistview.FullRowSelect = true;
            ColumnHeader header1 = new ColumnHeader();
            header1.Text = "SEAT NO:OCCUPIED";
            header1.Width = 150;
            this.ecoclasslistview.Columns.Add(header1);
            for (int j = 0; j < eco_class_seats.Length; j++)
            {
                ListViewItem rowitem = new ListViewItem();
                string[] tuple = eco_class_seats[j].Split(':');
                if (tuple[1].Equals("0"))
                {
                    rowitem.Text = tuple[0] + ":" + "O";
                }
                else
                {
                    rowitem.Text = tuple[0] + ":" + "X";
                }
                this.ecoclasslistview.Items.Add(rowitem);

            }


        }

        /*
          if (this.availablelist.SelectedIndices != null && this.availablelist.SelectedIndices.Count > 0) {
                 ListView.SelectedIndexCollection c = this.availablelist.SelectedIndices;
                 flight_id = this.availablelist.Items[c[0]].Text;
                // MessageBox.Show(flight_id);
             }


              */

        private void orderbtn_Click(object sender, EventArgs e)
        {
            if (alreadyOrdered == true) {
                MessageBox.Show("Sorry,one passenger can only order one seat,please sign in with other user");
                return;
            }
            //MessageBox.Show(selected_listview_item.Text);
            string content = "role:customer\taction:makeOrder\tflightID:" + flightID + "\tcustomerID:" + customerID + "\tseatType:" + seatType + "\tseatNumber:" + seatNumber;
            Network network = new Network(content);
            String result = network.getResult();
            if (result.Equals("success"))
            {
                alreadyOrdered = true;
                string display = "";
                if (seatType.Equals("1"))
                {
                    display = "Congrats,make order success,seat type:firstclass, number:" + seatNumber;
                }
                else
                {
                    display = "Congrats,make order success,seat type:ecoclass, number:" + seatNumber;
                }
                MessageBox.Show(display);
            }
            else {

                MessageBox.Show("Sorry, this seat already taken by others, please select other one");
            }
            String[] tuple = selected_listview_item.Text.Split(':');
            selected_listview_item.Text = tuple[0] + ":" + "X";
        }

        private void ecoclasslistview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ecoclasslistview.SelectedIndices != null && this.ecoclasslistview.SelectedIndices.Count > 0)
            {
                seatType = "2";
                ListView.SelectedIndexCollection c = this.ecoclasslistview.SelectedIndices;
                selected_listview_item = this.ecoclasslistview.Items[c[0]];
                seatNumber = selected_listview_item.Text.Split(':')[0];
            }
           
        }

        private void firstclasslistview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.firstclasslistview.SelectedIndices != null && this.firstclasslistview.SelectedIndices.Count > 0)
            {
                seatType = "1";
                ListView.SelectedIndexCollection c = this.firstclasslistview.SelectedIndices;
                selected_listview_item = this.firstclasslistview.Items[c[0]];
                seatNumber = selected_listview_item.Text.Split(':')[0];
            }
        }
    }
}
