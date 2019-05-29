using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int x = 0;
        public List<Entry> list;
        public Form2()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        public class Entry
        {
            //public string Segment { get; set; }
            public int Time { get; set; }
            public double Power { get; set; }
        }


        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            DataPoint dp;
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString + "\n";
                //txtStatus.Text[txtStatus.Text.Length] = "0";
                x++;
                //e.ReplyLine(string.Format("You Said {0}", e.MessageString));
                dp = new DataPoint(x, Convert.ToDouble(e.MessageString));

                chart1.Series["Power (W)"].Points.Add(dp);
                chart1.ResetAutoValues();
                // Frist parameter is X-Axis and Second is Collection of Y- Axis
                //list.Add(new Entry { Time = x, Power = 5 });
                //chart1.DataBind();


            }
            );
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {

            server.Stop();

            System.Net.IPAddress ip = System.Net.IPAddress.Parse(HostIP_txtBox.Text); ;// new System.Net.IPAddress(long.Parse(HostIP_txtbox.Text));
            server.Start(ip, Convert.ToInt32(Port_txtBox.Text));

            // server.Start(ip, 8080);
            EnableHost_checkBox.Checked = true;
            EnableHost_checkBox.Enabled = false;
            SetIP_lbl.Text = HostIP_txtBox.Text;
            SetPort_lbl.Text = Port_txtBox.Text;






        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            EnableHost_checkBox.Enabled = false;

            //====================================================
            //if (chart1.Series["Power (W)"] == null)
            {
                //chart1.Series.Add("Power (W)");
                chart1.Series["Power (W)"].ChartType = SeriesChartType.Line;
                chart1.Series["Power (W)"].XValueMember = "Time";
                chart1.Series["Power (W)"].YValueMembers = "Power (W)";
                list = new List<Entry>();
                chart1.DataSource = list;
            }
        }
    }
}
