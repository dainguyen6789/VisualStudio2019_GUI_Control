using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int x = 0;
        double realtime;

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
            int real_length=0;
            string encoded;
            string temp_string;
            double fake_time_step = 0.001,power,light;
            
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
                x++;
                //if(string.Compare(e.MessageString,"Hello from ESP")==1)
                //{
                //    ClientConnected_checkBox.Checked = true;
                //    ClientConnected_panel.BackColor= Color.LightGreen; 
                //}
                for (int i = 0; i < e.MessageString.Length; i++)
                {
                    if (e.MessageString[i] == '.')
                    { 
                        real_length = i + 2;// after dot digit and the code "W,M,T"
                        break;
                    }
                }
                label7.Text = Convert.ToString(real_length);
                encoded = e.MessageString.Substring(real_length);
                temp_string = e.MessageString.Substring(0, real_length);
                label5.Text = temp_string;// Convert.ToString(e.MessageString.Length);

                Console.WriteLine(string.Compare(encoded, "W"));
                label6.Text = encoded;
                // Position Chart
                if (encoded[0] == 'M')
                {
                    //label5.Text = encoded+"\0";
                    //e.ReplyLine(string.Format("You Said {0}", e.MessageString));

                    dp = new DataPoint(realtime+x*fake_time_step, Convert.ToDouble(temp_string));

                    chartPosition.Series[0].Points.Add(dp);
                    chartPosition.ResetAutoValues();
                    Console.WriteLine("I am at Position Chart");

                }
                // Sunlight Chart 
                else if (encoded[0] == 'L')
                {
                    light = (Convert.ToDouble(temp_string) * 4 - 55.581) / 0.623;
                    dp = new DataPoint(realtime + x * fake_time_step,light);
                    //pwm_time(us)=0.623*light(w/m2)+55.581
                    chartSunLight.Series[0].Points.Add(dp);
                    chartSunLight.ResetAutoValues();
                    Console.WriteLine("I am at Sun Chart");

                }
                // Power Chart
                else if (encoded[0] == 'W')
                {
                    power = 7.2 * (   ((Convert.ToDouble(temp_string) / 255 * 5)-2.5)*10    );
                    dp = new DataPoint(realtime + x * fake_time_step, power);

                    chartPower.Series[0].Points.Add(dp);
                    chartPower.ResetAutoValues();
                    Console.WriteLine("I am at Power Chart");

                }
                // Time data
                else if (encoded[0] == 'T')
                {
                    realtime = Convert.ToDouble(e.MessageString.Substring(0, real_length));
                    x = 0;
                }

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
            panelStatus.BackColor = Color.LightGreen;
            //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            //System.Drawing.Graphics formGraphics;
            //formGraphics = this.CreateGraphics();
            //Rectangle rectangle = new Rectangle(500, 80, 10, 10);

            //formGraphics.FillEllipse(myBrush, rectangle);
            //myBrush.Dispose();
            //formGraphics.Dispose();




        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            EnableHost_checkBox.Enabled = false;
            ClientConnected_checkBox.Enabled = false;

            //====================================================
            //if (chart1.Series["Power (W)"] == null)
            {
                //chart1.Series.Add("Power (W)");
                chartPower.Series[0].ChartType = SeriesChartType.Line;
                //chart1.Series[0].XValueMember = "Time";
                //chart1.Series[0].YValueMembers = "Power (W)";
                //var chartArea = new ChartArea("chart1");
                chartPower.ChartAreas[0].AxisX.Title = "Time";
                chartPower.ChartAreas[0].AxisY.Title = "Power(W)";

                // list = new List<Entry>();
                //chart1.DataSource = list;

            }

            chartSunLight.Series[0].ChartType = SeriesChartType.Line;
            chartSunLight.Series[0].XValueMember = "Time";
            chartSunLight.Series[0].YValueMembers = "Sun Light";
            chartSunLight.ChartAreas[0].AxisX.Title = "Time";

            chartPosition.Series[0].ChartType = SeriesChartType.Line;
            chartPosition.Series[0].XValueMember = "Time";
            chartPosition.Series[0].YValueMembers = "Sun Light";
            chartPosition.ChartAreas[0].AxisX.Title = "Time";
            chartPosition.ChartAreas[0].AxisY.Title = "Position (mm)";




        }
    }
}
