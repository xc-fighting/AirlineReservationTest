using System;
using System.Collections;
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
    public partial class availableflights : Form
    {
        private String customer_id;
        private String flight_id;
        public ArrayList display_list;
        public int  selectIndex=-1;
        public availableflights(String id)
        {
            InitializeComponent();
            customer_id = id;
        }

        private void availableflights_Load(object sender, EventArgs e)
        {
            this.customeridlable.Text = customer_id;
            String content = "role:customer\taction:getAvailableFlight";
            Network network = new Network(content);
            String result = network.getResult();
          //    MessageBox.Show(result);
            display_list = new ArrayList();
            string[] group = result.Split('\t');
            for (int i = 1; i < group.Length; i++) {
                string line = group[i];
                if (line.Length == 0) {
                    continue;
                }
                string[] items = line.Split('~');
             //   MessageBox.Show(items[0] + " " + items[1] + " " + items[2] + " " + items[3] + " " + items[4] + " " + items[5] + " " + items[6]);
                AirlineItem item = new AirlineItem(items[0], items[1], items[2], items[3], items[4], Int32.Parse(items[5]), Int32.Parse(items[6]));
                display_list.Add(item);

            }
            if (display_list.Count == 0)
            {
                MessageBox.Show("no available airline now");
            }
            else {
                // AirlineItem obj = (AirlineItem)display_list.ToArray()[0];
                ColumnHeader[] ch = new ColumnHeader[7];
                for (int i = 0; i < 7; i++) {
                    ch[i] = new ColumnHeader();
                }
                this.availablelist.View = View.Details;
                this.availablelist.GridLines = true;
                this.availablelist.FullRowSelect = true;
                ch[0].Text = "flight ID";
                ch[0].Width = 130;
                ch[1].Text = "departure place";
                ch[1].Width = 130;
                ch[2].Text = "arrival place";
                ch[2].Width = 130;
                ch[3].Text = "departure time";
                ch[3].Width = 130;
                ch[4].Text = "arrival time";
                ch[4].Width = 130;
                ch[5].Text = "1st class price";
                ch[5].Width = 130;
                ch[6].Text = "eco class price";
                ch[6].Width = 130;
                for (int i = 0; i < 7; i++) {
                    this.availablelist.Columns.Add(ch[i]);
                }
                object[] array = display_list.ToArray();
                for (int i = 0; i < array.Length; i++) {
                    ListViewItem row_item = new ListViewItem();
                    AirlineItem obj = (AirlineItem)(array[i]);
                    row_item.Text=obj.flightID;
                    row_item.SubItems.Add(obj.departurePlace);
                    row_item.SubItems.Add(obj.arrivalPlace);
                    row_item.SubItems.Add(obj.departureTime);
                    row_item.SubItems.Add(obj.arrivalTime);
                    row_item.SubItems.Add(obj.price_first+"");
                    row_item.SubItems.Add(obj.price_eco + "");
                    this.availablelist.Items.Add(row_item);

                }
                
               
            }
        }

       
      

        private void selectseatbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("now select the seat");
              Thread thr = new Thread(
                  delegate () {
                      new SelectSeat(customer_id,flight_id).ShowDialog();

                  }

             );
              thr.Start();
              this.Close();

        }

        private void availablelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("select");
            if (this.availablelist.SelectedIndices != null && this.availablelist.SelectedIndices.Count > 0) {
                ListView.SelectedIndexCollection c = this.availablelist.SelectedIndices;
                flight_id = this.availablelist.Items[c[0]].Text;
               // MessageBox.Show(flight_id);
            }
        }
    }
}
