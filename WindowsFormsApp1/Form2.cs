using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
//using Microsoft.VisualBasic.TextFieldParser;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int x = 0;
        double realtime;
        int numberOfZoom=0;
        int numberOfZoomSunLight = 0;
        int numberOfZoomPosition = 0;

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
                        real_length = i + 5;// after dot digit and the code "W,M,T"
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

                    dp = new DataPoint(realtime, Convert.ToDouble(temp_string));
                    if (chartPosition.Series.FindByName(datetimePower.Text) == null)
                    {
                        chartPosition.Series.Add(datetimePower.Text);
                        chartPosition.Series[datetimePower.Text].ChartType = SeriesChartType.Line;
                    }
                    chartPosition.Series[datetimePower.Text].Points.Add(dp);
                    chartPosition.Series[datetimePower.Text].MarkerStyle = MarkerStyle.Diamond;
                    chartPosition.Series[datetimePower.Text].MarkerSize = 10;
                    chartPosition.ChartAreas[0].AxisX.Maximum = 17;
                    chartPosition.ChartAreas[0].AxisX.Minimum = 7;
                    chartPosition.ChartAreas[0].AxisX.Interval = 0.5;
                    //chartPosition.ResetAutoValues();
                    Console.WriteLine("I am at Position Chart");

                }
                // Sunlight Chart 
                else if (encoded[0] == 'L')
                {
                    light = (Convert.ToDouble(temp_string)*1.5648-53.194);
                    dp = new DataPoint(realtime,light>0?light:0);
                    if (chartSunLight.Series.FindByName(datetimePower.Text) == null)
                    {
                        chartSunLight.Series.Add(datetimePower.Text);
                        chartSunLight.Series[datetimePower.Text].ChartType = SeriesChartType.Line;
                    }

                    //pwm_time(us)=0.623*light(w/m2)+55.581
                    chartSunLight.Series[datetimePower.Text].Points.Add(dp);
                    chartSunLight.ResetAutoValues();

                    chartSunLight.ChartAreas[0].AxisX.Maximum = 17;
                    chartSunLight.ChartAreas[0].AxisX.Minimum = 7;
                    chartSunLight.ChartAreas[0].AxisX.Interval = 0.5;
                    chartSunLight.Series[datetimePower.Text].MarkerStyle = MarkerStyle.Diamond;
                    chartSunLight.Series[datetimePower.Text].MarkerSize = 10;
                    Console.WriteLine("I am at Sun Chart");

                }
                // Power Chart
                else if (encoded[0] == 'W')
                {
                    // 0.07 is the offset value when we measure the Vout with Input current I=0A, 
                    // 5Vcc->2.49Vout, 4.83Vcc->2.42Vout
                    power = 7.2 * (  10* (Convert.ToDouble(temp_string)*4.83/5+0.07)-25    ); 
                    dp = new DataPoint(realtime, power>0?power:0);
                    if (chartPower.Series.FindByName(datetimePower.Text)== null)
                        chartPower.Series.Add(datetimePower.Text);
                    chartPower.Series[datetimePower.Text].ChartType = SeriesChartType.Line;
                    chartPower.Series[datetimePower.Text].Points.Add(dp);
                    chartPower.Series[datetimePower.Text].MarkerStyle = MarkerStyle.Diamond;
                    chartPower.Series[datetimePower.Text].MarkerSize = 10;

                    //chartPower.ResetAutoValues();
                    chartPower.ChartAreas[0].AxisY.Maximum = 60;
                    chartPower.ChartAreas[0].AxisY.Minimum = -1;
                    chartPower.ChartAreas[0].AxisY.Interval = 5;

                    chartPower.ChartAreas[0].AxisX.Maximum = 17;
                    chartPower.ChartAreas[0].AxisX.Minimum = 7;
                    chartPower.ChartAreas[0].AxisX.Interval = 0.5;

                   // chartPower.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                   // chartPower.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                    //chartPower.
                    Console.WriteLine("I am at Power Chart");

                }
                // Power Chart
                else if (encoded[0] == 'J')
                {
                    //label5.Text = encoded+"\0";
                    //e.ReplyLine(string.Format("You Said {0}", e.MessageString));

                    dp = new DataPoint(realtime, Convert.ToDouble(temp_string));
                    if (chartPosition.Series.FindByName(datetimePower.Text+"JP Pos") == null)
                    {
                        chartPosition.Series.Add(datetimePower.Text + "JP Pos");
                        chartPosition.Series[datetimePower.Text + "JP Pos"].ChartType = SeriesChartType.Line;
                    }
                    chartPosition.Series[datetimePower.Text + "JP Pos"].Points.Add(dp);
                    chartPosition.ResetAutoValues();
                    Console.WriteLine("I am at JP Position Chart");

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
            //chartPower.Series.Clear();
            //chartSunLight.Series.Clear();
            //chartPosition.Series.Clear();
            //NumberFormatInfo setPrecision = new NumberFormatInfo();
           // setPrecision. = 2;
            Console.WriteLine("Heloooooooooooooooooooooooooo");

            //datetimePower.Text=dateTimePicker1.Value.ToString("yyyy:MM:dd");
            datetimePower.Text = DateTime.Now.ToString("yyyy:MM:dd");
            datetimePosition.Text = DateTime.Now.ToString("yyyy:MM:dd");
            datetimeSunLight.Text = DateTime.Now.ToString("yyyy:MM:dd");

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            EnableHost_checkBox.Enabled = false;
            ClientConnected_checkBox.Enabled = false;

            //====================================================
            //if (chart1.Series["Power (W)"] == null)
            {
                chartPower.Series.Add(datetimePower.Text);
                chartPower.Series[datetimePower.Text].ChartType = SeriesChartType.Line;
                //chart1.Series[0].XValueMember = "Time";
                //chart1.Series[0].YValueMembers = "Power (W)";
                //var chartArea = new ChartArea("chart1");
                chartPower.ChartAreas[0].AxisX.Title = "Time";
                chartPower.ChartAreas[0].AxisY.Title = "Power(W)";
                chartPower.MouseWheel += chartPower_MouseWheel;
                // list = new List<Entry>();
                //chart1.DataSource = list;

            }


            chartSunLight.Series[0].ChartType = SeriesChartType.Line;
            chartSunLight.Series[0].XValueMember = "Time";
            chartSunLight.Series[0].YValueMembers = "Sun Light";
            chartSunLight.ChartAreas[0].AxisX.Title = "Time";
            chartSunLight.MouseWheel += chartSunLight_MouseWheel;

            chartPosition.Series[0].ChartType = SeriesChartType.Line;
            chartPosition.Series[0].XValueMember = "Time";
            chartPosition.Series[0].YValueMembers = "Sun Light";
            chartPosition.ChartAreas[0].AxisX.Title = "Time";
            chartPosition.ChartAreas[0].AxisY.Title = "Position (mm)";
            chartPosition.MouseWheel += chartPosition_MouseWheel;



        }

        private void chartPosition_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart =(Chart) sender;

            int intervalX = 3;
            int intervalY = 3;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if(e.Delta<0 && numberOfZoomPosition>0)// ZOOM OUT
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - intervalX / Math.Pow(2, numberOfZoomPosition);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + intervalX / Math.Pow(2, numberOfZoomPosition);

                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - intervalY / Math.Pow(2, numberOfZoomPosition);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + intervalY / Math.Pow(2, numberOfZoomPosition);


                    xAxis.ScaleView.Zoom(Math.Round(posXStart, 3), Math.Round(posXFinish, 3));
                    yAxis.ScaleView.Zoom(Math.Round(posYStart, 3), Math.Round(posYFinish, 3));
                    // xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    //yAxis.ScaleView.Zoom(posYStart, posYFinish);
                    chartPosition.ChartAreas[0].AxisX.Interval = 0.1;

                    numberOfZoomPosition--;


                }
                else if(e.Delta>0)
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - intervalX / Math.Pow(2, numberOfZoomPosition);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + intervalX / Math.Pow(2, numberOfZoomPosition);

                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - intervalY / Math.Pow(2, numberOfZoomPosition);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + intervalY / Math.Pow(2, numberOfZoomPosition);


                    xAxis.ScaleView.Zoom(Math.Round(posXStart, 3), Math.Round(posXFinish, 3));
                    yAxis.ScaleView.Zoom(Math.Round(posYStart, 3), Math.Round(posYFinish, 3));
                    // xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    // yAxis.ScaleView.Zoom(posYStart,posYFinish);
                    chartPosition.ChartAreas[0].AxisX.Interval =0.1;

                    numberOfZoomPosition++;

                }
                else if (e.Delta < 0 && numberOfZoom == 0) //Last scrolled dowm
                {
                    yAxis.ScaleView.ZoomReset();
                    xAxis.ScaleView.ZoomReset();
                    chartPosition.ChartAreas[0].AxisX.Interval = 0.5;

                }
                if (numberOfZoomPosition < 0)
                {
                    numberOfZoomPosition = 0;
                    yAxis.ScaleView.ZoomReset();
                    xAxis.ScaleView.ZoomReset();
                    chartPosition.ChartAreas[0].AxisX.Interval = 0.5;

                }

            }
            catch
            { }

        }

        private void chartSunLight_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            int intervalX = 3;
            int intervalY = 3;

            try
            {
                if (e.Delta < 0 && numberOfZoomSunLight > 0)
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - intervalX / Math.Pow(2, numberOfZoomSunLight);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + intervalX / Math.Pow(2, numberOfZoomSunLight);

                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - intervalY / Math.Pow(2, numberOfZoomSunLight);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + intervalY / Math.Pow(2, numberOfZoomSunLight);

                    if (posXStart < 0) posXStart = 0;
                   // if (posYStart < 0) posYStart = 0;

                    xAxis.ScaleView.Zoom(Math.Round(posXStart, 3), Math.Round(posXFinish, 3));
                    yAxis.ScaleView.Zoom(Math.Round(posYStart, 3), Math.Round(posYFinish, 3));

                    numberOfZoomSunLight--;

                }
                else if (e.Delta > 0)
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - intervalX / Math.Pow(2, numberOfZoomSunLight);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + intervalX / Math.Pow(2, numberOfZoomSunLight);
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - intervalY / Math.Pow(2, numberOfZoomSunLight);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + intervalY / Math.Pow(2, numberOfZoomSunLight);

                    xAxis.ScaleView.Zoom(Math.Round(posXStart, 3), Math.Round(posXFinish, 3));
                    yAxis.ScaleView.Zoom(Math.Round(posYStart, 3), Math.Round(posYFinish, 3));
                    numberOfZoomSunLight++;
                }
                else if (numberOfZoomSunLight == 0)
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();

                }
                if (numberOfZoomSunLight < 0) numberOfZoomSunLight = 0;


            }
            catch { }
        }

        private void chartPower_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;
            var yMin = yAxis.ScaleView.ViewMinimum;
            var yMax = yAxis.ScaleView.ViewMaximum;

            int IntervalX = 3;
            int IntervalY = 3;
            try
            {
                // Delta is a sign count of the number of detents the mouse wheel has rotated.
                if (e.Delta < 0 && numberOfZoom > 0) // Scrolled down.
                {
                    //PixelPositionToValue: Converts an absolute pixel position along an axis to an axis value
                    //e.Location:  Gets the location of the mouse during the generating mouse event.
                    // numofZoom variable will change during the mouse wheel event and this will determine the posXStart/Finish and posYStart/Finish.
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX  / Math.Pow(2, numberOfZoom);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX  / Math.Pow(2, numberOfZoom);
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - IntervalY  / Math.Pow(2, numberOfZoom);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + IntervalY / Math.Pow(2, numberOfZoom);

                    if (posXStart < 0) posXStart = 0;
                    //if (posYStart < 0) posYStart = 0;
                    if (posYFinish > yAxis.Maximum) posYFinish = yAxis.Maximum;
                    if (posXFinish > xAxis.Maximum) posYFinish = xAxis.Maximum;
                    xAxis.ScaleView.Zoom(Math.Round(posXStart, 3), Math.Round(posXFinish, 3));
                    yAxis.ScaleView.Zoom(Math.Round(posYStart, 3), Math.Round(posYFinish, 3));
                    numberOfZoom--;
                }
                else if (e.Delta < 0 && numberOfZoom == 0) //Last scrolled dowm
                {
                    yAxis.ScaleView.ZoomReset();
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, numberOfZoom);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, numberOfZoom);
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - IntervalY / Math.Pow(2, numberOfZoom);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + IntervalY / Math.Pow(2, numberOfZoom);
                    xAxis.ScaleView.Zoom(Math.Round(posXStart,3), Math.Round(posXFinish,3));
                    yAxis.ScaleView.Zoom(Math.Round(posYStart,3), Math.Round(posYFinish,3));
                    numberOfZoom++;
                }

                if (numberOfZoom < 0) numberOfZoom = 0;
            }
            catch { }
        }

        private void ClearChart_btn_Click(object sender, EventArgs e)
        {
            chartPower.Series.Clear();
            chartSunLight.Series.Clear();
            chartPosition.Series.Clear();

        }

        private void AaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void ClearRxData_btn_Click(object sender, EventArgs e)
        {
            txtStatus.Text = null;
        }

        private void SaveData_btn_Click(object sender, EventArgs e)
{
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "Text|*.txt";
            //saveFileDialog1.Title = "Save an Text File";
            //saveFileDialog1.ShowDialog();
            //string path, name;
            string folderName = @"C:\Users\designer\Documents";

            // To create a string that specifies the path to a subfolder under your 
            // top-level folder, add a name for the subfolder to folderName.
            string pathString = System.IO.Path.Combine(folderName, "ISPData");

            // You can write out the path name directly instead of using the Combine
            // method. Combine just makes the process easier.
           // string pathString2 = @"c:\Top-Level Folder\SubFolder2";

            // You can extend the depth of your path if you want to.
            //pathString = System.IO.Path.Combine(pathString, "SubSubFolder");

            // Create the subfolder. You can verify in File Explorer that you have this
            // structure in the C: drive.
            //    Local Disk (C:)
            //        Top-Level Folder
            //            SubFolder
            System.IO.Directory.CreateDirectory(pathString);
            //path = pathString + name + ".txt";
            //TextWriter txt = new StreamWriter("C: \\Users\\designer\\Documents\\demo.txt");
            //txt.Write(txtStatus.Text);
            //txt.Close();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.InitialDirectory = @"C:\";      
            saveFileDialog1.Title = "Save text Files";
            //saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //txtStatus.Text = saveFileDialog1.FileName;
                using (File.Create(saveFileDialog1.FileName));
                TextWriter txt = new StreamWriter(saveFileDialog1.FileName);
                txt.Write(txtStatus.Text);
                txt.Close();
            }
        }

        private void SaveChart_btn_Click(object sender, EventArgs e)
        {

                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "JPEG (*.jpeg)|*.png|All files (*.*)|*.*";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.chartPower.SaveImage(dlg.FileName, ChartImageFormat.Jpeg);
            }

        }

        private void SavePosChart_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "JPEG (*.jpeg)|*.png|All files (*.*)|*.*";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.chartPosition.SaveImage(dlg.FileName, ChartImageFormat.Jpeg);
            }
        }

        private void SaveSunLightChart_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "JPEG (*.jpeg)|*.png|All files (*.*)|*.*";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.chartSunLight.SaveImage(dlg.FileName, ChartImageFormat.Jpeg);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //datetimePower.Text = DateTime.Now.ToString("yyyy:MM:dd:hh:mm");
            datetimePower.Text = DateTime.Now.ToString("yyyy:MM:dd");
            datetimePosition.Text = DateTime.Now.ToString("yyyy:MM:dd");
            datetimeSunLight.Text = DateTime.Now.ToString("yyyy:MM:dd");
            textBox1.Text= DateTime.Now.ToString("h:mm:ss tt"); 
        }


        private void SaveCSV(string date, string time, string data)
        {


        }

        private void SavePowerCSV_btn_Click(object sender, EventArgs e)
        {

                //var file = @"C:\Users\designer\Documents\ISPData";
                //int x = 1, y = 3,count=0;
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "CSV(*.csv)|All files (*.*)";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (var stream = File.CreateText(dlg.FileName + ".csv"))
                    {
                    foreach (var dp in chartPower.Series[datetimePower.Text].Points)
                    {
                        string csvRow = string.Format("{0},{1},{2}", DateTime.Now.ToString("yyyy:MM:dd"),  dp.XValue.ToString(), dp.YValues[0].ToString());
                        Console.WriteLine(dp);
                        //count++;
                        stream.WriteLine(csvRow);

                    }
                }

            }
        }

        private void SaveCSVPosition_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var stream=File.CreateText(dlg.FileName+".csv"))
                    foreach(var dp in chartPosition.Series[datetimePosition.Text].Points)
                     {
                        string csvrow = string.Format("{0},{1},{2}", DateTime.Now.ToString("yyyy:MM:dd"),dp.XValue.ToString(),dp.YValues[0].ToString());
                        stream.WriteLine(csvrow);
                    }
            }
        }

        private void SaveCSVSunLight_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var stream = File.CreateText(dlg.FileName+".csv"))
                {
                    foreach (var dp in chartSunLight.Series[datetimeSunLight.Text].Points)
                    {
                        string csvstring = string.Format("{0},{1},{2}", DateTime.Now.ToString("yyyy:MM:dd"), dp.XValue.ToString(), dp.YValues[0].ToString());
                        stream.WriteLine(csvstring);
                    }
                }
            }
        }

        private void OpenPower_btn_Click(object sender, EventArgs e)
        {
            // chartPower.ChartAreas.Clear();
            // Console.WriteLine("Heloooooooooooooooooooooooooo");
            DataPoint dp ;
            OpenFileDialog dlg = new OpenFileDialog();
            //Console.WriteLine(result);
            //Console.WriteLine(DialogResult.OK);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (TextFieldParser parser = new TextFieldParser(dlg.FileName))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        //Process row
                        string[] fields = parser.ReadFields();
                        // chartPower.Series.Add(fields[0]);
                        dp = new DataPoint(Convert.ToDouble(fields[1]), Convert.ToDouble(fields[2]));
                        if (chartPower.Series.FindByName(fields[0]) == null)
                            chartPower.Series.Add(fields[0]);
                        chartPower.Series[fields[0]].ChartType = SeriesChartType.Line;

                        chartPower.Series[fields[0]].Points.Add(dp);
                        Console.WriteLine(fields[2]);
                        chartPower.Series[fields[0]].MarkerStyle = MarkerStyle.Diamond;
                        chartPower.Series[fields[0]].MarkerSize = 10;

                        //chartPower.ResetAutoValues();
                        chartPower.ChartAreas[0].AxisY.Maximum = 60;
                        chartPower.ChartAreas[0].AxisY.Minimum = -1;
                        chartPower.ChartAreas[0].AxisY.Interval = 5;

                        chartPower.ChartAreas[0].AxisX.Maximum = 17;
                        chartPower.ChartAreas[0].AxisX.Minimum = 7;
                        chartPower.ChartAreas[0].AxisX.Interval = 0.5;
                      //  foreach (string field in fields)
                        {
                           // Console.WriteLine(fields[2]);
                        }
                    }
                }

                //StreamReader reader = new StreamReader(dlg.FileName);

                //while (!reader.EndOfStream)
                //{

                //    Console.WriteLine(reader.ReadLine());
                //}
            }
        }

        private void OpenPosition_btn_Click(object sender, EventArgs e)
        {
            DataPoint dp;
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (TextFieldParser parser = new TextFieldParser(dlg.FileName))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        //Process row
                        string[] fields = parser.ReadFields();
                        // chartPower.Series.Add(fields[0]);
                        dp = new DataPoint(Convert.ToDouble(fields[1]), Convert.ToDouble(fields[2]));
                        if (chartPosition.Series.FindByName(fields[0]) == null)
                            chartPosition.Series.Add(fields[0]);
                        chartPosition.Series[fields[0]].ChartType = SeriesChartType.Line;

                        chartPosition.Series[fields[0]].Points.Add(dp);
                        Console.WriteLine(fields[2]);
                        chartPosition.Series[fields[0]].MarkerStyle = MarkerStyle.Diamond;
                        chartPosition.Series[fields[0]].MarkerSize = 10;

                        //chartPower.ResetAutoValues();
                        //chartPosition.ChartAreas[0].AxisY.Maximum = 60;
                        chartPosition.ChartAreas[0].AxisY.Minimum = -1;
                        chartPosition.ChartAreas[0].AxisY.Maximum = 220;

                        //chartPosition.ChartAreas[0].AxisY.Interval = 0.5;

                        chartPosition.ChartAreas[0].AxisX.Maximum = 17;
                        chartPosition.ChartAreas[0].AxisX.Minimum = 7;
                        chartPosition.ChartAreas[0].AxisX.Interval = 0.5;
                        foreach (string field in fields)
                        {
                            // Console.WriteLine(fields[2]);
                        }
                    }
                }

                //StreamReader reader = new StreamReader(dlg.FileName);

                //while (!reader.EndOfStream)
                //{

                //    Console.WriteLine(reader.ReadLine());
                //}
            }
        }

        private void OpenSunLight_btn_Click(object sender, EventArgs e)
        {
            DataPoint dp;
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (TextFieldParser parser = new TextFieldParser(dlg.FileName))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        //Process row
                        string[] fields = parser.ReadFields();
                        // chartPower.Series.Add(fields[0]);
                        dp = new DataPoint(Convert.ToDouble(fields[1]), Convert.ToDouble(fields[2]));
                        if (chartSunLight.Series.FindByName(fields[0]) == null)
                            chartSunLight.Series.Add(fields[0]);


                        chartSunLight.Series[fields[0]].ChartType = SeriesChartType.Line;
                        chartSunLight.Series[fields[0]].Points.Add(dp);
                        Console.WriteLine(fields[2]);
                        chartSunLight.Series[fields[0]].MarkerStyle = MarkerStyle.Diamond;
                        chartSunLight.Series[fields[0]].MarkerSize = 10;

                        //chartPower.ResetAutoValues();
                        //chartPosition.ChartAreas[0].AxisY.Maximum = 60;
                        chartSunLight.ChartAreas[0].AxisY.Minimum = -1;
                        //chartSunLight.ChartAreas[0].AxisY.Interval = 5;

                        chartSunLight.ChartAreas[0].AxisX.Maximum = 17;
                        chartSunLight.ChartAreas[0].AxisX.Minimum = 7;
                        chartSunLight.ChartAreas[0].AxisX.Interval = 0.5;
                        foreach (string field in fields)
                        {
                            // Console.WriteLine(fields[2]);
                        }
                    }
                }

                //StreamReader reader = new StreamReader(dlg.FileName);

                //while (!reader.EndOfStream)
                //{

                //    Console.WriteLine(reader.ReadLine());
                //}
            }
        }
        //private void InsertSQLData()
        //{
        //    string ConnString = "datasource=localhost;port=3306;username=dainguyen;password=root";
        //    string query ="insert into CSharpTestTable(id,number) values (1,2)";
        //    SqlConnection sqlconn = new SqlConnection(ConnString);
        //    SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
        //    sqlconn.Close();

        //}
    }
}
