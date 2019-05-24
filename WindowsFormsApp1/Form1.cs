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
    public class Entry
    {
        //public string Segment { get; set; }
        public int Time { get; set; }
        public double Power { get; set; }
    }

    public partial class Form1 : Form
    {
        int x = 0;
        public List<Entry> list;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        SimpleTcpServer server;
       // private object series;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            DataPoint dp;
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString+"\n";
                x++;
                dp=new DataPoint(x, Convert.ToDouble(e.MessageString));
                chart1.Series["Power (W)"].Points.Add(dp);
                chart1.ResetAutoValues(); // Add this line.

                // chart1.DataBind();
                e.ReplyLine(string.Format("You Said {0}", e.MessageString));
                // Frist parameter is X-Axis and Second is Collection of Y- Axis



            }
            );
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(HostIP_txtbox.Text); ;// new System.Net.IPAddress(long.Parse(HostIP_txtbox.Text));
            server.Start(ip, Convert.ToInt32(Port_txtBox.Text));


            //====================================================
            chart1.Series.Add("Power (W)");
            chart1.Series["Power (W)"].ChartType = SeriesChartType.Line;
            chart1.Series["Power (W)"].XValueMember = "Time";
            chart1.Series["Power (W)"].YValueMembers = "Power (W)";
            //list = new List<Entry>();
            //chart1.DataSource = list;
           // chart1.DataBind();

        }


    }
}
