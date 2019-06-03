namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea34 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend34 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title34 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea35 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend35 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title35 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea36 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend36 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title36 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Start_btn = new System.Windows.Forms.Button();
            this.HostIP_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Port_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartPower = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.EnableHost_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClientConnected_checkBox = new System.Windows.Forms.CheckBox();
            this.ClientConnected_panel = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.SetPort_lbl = new System.Windows.Forms.Label();
            this.SetIP_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ReceivedData_groupBox = new System.Windows.Forms.GroupBox();
            this.chartPosition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSunLight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearChart_btn = new System.Windows.Forms.Button();
            this.SaveChart_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innovativeSolarPowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit_btn = new System.Windows.Forms.Button();
            this.ClearRxData_btn = new System.Windows.Forms.Button();
            this.SaveSunLightChart_btn = new System.Windows.Forms.Button();
            this.SaveData_btn = new System.Windows.Forms.Button();
            this.SavePosChart_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.datetimePower = new System.Windows.Forms.Label();
            this.datetimePosition = new System.Windows.Forms.Label();
            this.datetimeSunLight = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartPower)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ReceivedData_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSunLight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Start_btn.Location = new System.Drawing.Point(13, 77);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Init Host";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // HostIP_txtBox
            // 
            this.HostIP_txtBox.Location = new System.Drawing.Point(58, 19);
            this.HostIP_txtBox.Name = "HostIP_txtBox";
            this.HostIP_txtBox.Size = new System.Drawing.Size(100, 20);
            this.HostIP_txtBox.TabIndex = 1;
            this.HostIP_txtBox.Text = "192.168.11.203";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host IP";
            // 
            // Port_txtBox
            // 
            this.Port_txtBox.Location = new System.Drawing.Point(58, 42);
            this.Port_txtBox.Name = "Port_txtBox";
            this.Port_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Port_txtBox.TabIndex = 3;
            this.Port_txtBox.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // chartPower
            // 
            chartArea34.Name = "ChartArea1";
            this.chartPower.ChartAreas.Add(chartArea34);
            legend34.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend34.Name = "Legend1";
            this.chartPower.Legends.Add(legend34);
            this.chartPower.Location = new System.Drawing.Point(13, 19);
            this.chartPower.Name = "chartPower";
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series34.Legend = "Legend1";
            series34.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series34.Name = "Power (W)";
            this.chartPower.Series.Add(series34);
            this.chartPower.Size = new System.Drawing.Size(547, 313);
            this.chartPower.TabIndex = 5;
            this.chartPower.Text = "chart1";
            title34.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title34.Name = "Title1";
            title34.ShadowColor = System.Drawing.SystemColors.ActiveBorder;
            title34.Text = "System Power (W)";
            title34.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartPower.Titles.Add(title34);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(13, 47);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(547, 87);
            this.txtStatus.TabIndex = 6;
            this.txtStatus.Text = "";
            // 
            // EnableHost_checkBox
            // 
            this.EnableHost_checkBox.AutoSize = true;
            this.EnableHost_checkBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnableHost_checkBox.Location = new System.Drawing.Point(170, 23);
            this.EnableHost_checkBox.Name = "EnableHost_checkBox";
            this.EnableHost_checkBox.Size = new System.Drawing.Size(84, 17);
            this.EnableHost_checkBox.TabIndex = 9;
            this.EnableHost_checkBox.Text = "Enable Host";
            this.EnableHost_checkBox.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.Quit_btn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.HostIP_txtBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ClearChart_btn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Start_btn);
            this.groupBox1.Controls.Add(this.Port_txtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Config";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.ClientConnected_checkBox);
            this.groupBox2.Controls.Add(this.ClientConnected_panel);
            this.groupBox2.Controls.Add(this.panelStatus);
            this.groupBox2.Controls.Add(this.SetPort_lbl);
            this.groupBox2.Controls.Add(this.SetIP_lbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EnableHost_checkBox);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Location = new System.Drawing.Point(247, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 70);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // ClientConnected_checkBox
            // 
            this.ClientConnected_checkBox.AutoSize = true;
            this.ClientConnected_checkBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientConnected_checkBox.Location = new System.Drawing.Point(170, 46);
            this.ClientConnected_checkBox.Name = "ClientConnected_checkBox";
            this.ClientConnected_checkBox.Size = new System.Drawing.Size(107, 17);
            this.ClientConnected_checkBox.TabIndex = 18;
            this.ClientConnected_checkBox.Text = "Client Connected";
            this.ClientConnected_checkBox.UseVisualStyleBackColor = false;
            // 
            // ClientConnected_panel
            // 
            this.ClientConnected_panel.BackColor = System.Drawing.Color.Red;
            this.ClientConnected_panel.Location = new System.Drawing.Point(147, 46);
            this.ClientConnected_panel.Name = "ClientConnected_panel";
            this.ClientConnected_panel.Size = new System.Drawing.Size(17, 17);
            this.ClientConnected_panel.TabIndex = 17;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.Red;
            this.panelStatus.Location = new System.Drawing.Point(147, 23);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(17, 17);
            this.panelStatus.TabIndex = 16;
            // 
            // SetPort_lbl
            // 
            this.SetPort_lbl.AutoSize = true;
            this.SetPort_lbl.Location = new System.Drawing.Point(50, 33);
            this.SetPort_lbl.Name = "SetPort_lbl";
            this.SetPort_lbl.Size = new System.Drawing.Size(31, 13);
            this.SetPort_lbl.TabIndex = 16;
            this.SetPort_lbl.Text = "0000";
            // 
            // SetIP_lbl
            // 
            this.SetIP_lbl.AutoSize = true;
            this.SetIP_lbl.Location = new System.Drawing.Point(50, 17);
            this.SetIP_lbl.Name = "SetIP_lbl";
            this.SetIP_lbl.Size = new System.Drawing.Size(40, 13);
            this.SetIP_lbl.TabIndex = 15;
            this.SetIP_lbl.Text = "0.0.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Host IP:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.checkBox2.Location = new System.Drawing.Point(435, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Enable Host";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // ReceivedData_groupBox
            // 
            this.ReceivedData_groupBox.Controls.Add(this.dateTimePicker1);
            this.ReceivedData_groupBox.Controls.Add(this.SaveData_btn);
            this.ReceivedData_groupBox.Controls.Add(this.ClearRxData_btn);
            this.ReceivedData_groupBox.Controls.Add(this.txtStatus);
            this.ReceivedData_groupBox.Location = new System.Drawing.Point(24, 198);
            this.ReceivedData_groupBox.Name = "ReceivedData_groupBox";
            this.ReceivedData_groupBox.Size = new System.Drawing.Size(570, 148);
            this.ReceivedData_groupBox.TabIndex = 12;
            this.ReceivedData_groupBox.TabStop = false;
            this.ReceivedData_groupBox.Text = "Received Data";
            // 
            // chartPosition
            // 
            chartArea35.Name = "ChartArea1";
            this.chartPosition.ChartAreas.Add(chartArea35);
            legend35.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend35.IsDockedInsideChartArea = false;
            legend35.Name = "Legend1";
            this.chartPosition.Legends.Add(legend35);
            this.chartPosition.Location = new System.Drawing.Point(18, 16);
            this.chartPosition.Name = "chartPosition";
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series35.CustomProperties = "LabelStyle=Top";
            series35.Legend = "Legend1";
            series35.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series35.Name = "Position (mm)";
            this.chartPosition.Series.Add(series35);
            this.chartPosition.Size = new System.Drawing.Size(579, 283);
            this.chartPosition.TabIndex = 14;
            this.chartPosition.Text = "chart2";
            title35.Name = "Title1";
            title35.Position.Auto = false;
            title35.Position.Height = 5.384036F;
            title35.Position.Width = 94F;
            title35.Position.X = 3F;
            title35.Position.Y = 1F;
            title35.Text = "Motor Position";
            this.chartPosition.Titles.Add(title35);
            // 
            // chartSunLight
            // 
            chartArea36.Name = "ChartArea1";
            this.chartSunLight.ChartAreas.Add(chartArea36);
            legend36.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend36.Name = "Legend1";
            this.chartSunLight.Legends.Add(legend36);
            this.chartSunLight.Location = new System.Drawing.Point(18, 19);
            this.chartSunLight.Name = "chartSunLight";
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series36.Legend = "Legend1";
            series36.Name = "Sunlight (W/m2)";
            this.chartSunLight.Series.Add(series36);
            this.chartSunLight.Size = new System.Drawing.Size(576, 313);
            this.chartSunLight.TabIndex = 15;
            this.chartSunLight.Text = "chart3";
            title36.Name = "Title1";
            title36.Text = "Sun Light (W/m2)";
            this.chartSunLight.Titles.Add(title36);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Code:";
            // 
            // ClearChart_btn
            // 
            this.ClearChart_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearChart_btn.ForeColor = System.Drawing.Color.Black;
            this.ClearChart_btn.Location = new System.Drawing.Point(148, 77);
            this.ClearChart_btn.Name = "ClearChart_btn";
            this.ClearChart_btn.Size = new System.Drawing.Size(75, 23);
            this.ClearChart_btn.TabIndex = 12;
            this.ClearChart_btn.Text = "Clear Chart";
            this.ClearChart_btn.UseVisualStyleBackColor = false;
            this.ClearChart_btn.Click += new System.EventHandler(this.ClearChart_btn_Click);
            // 
            // SaveChart_btn
            // 
            this.SaveChart_btn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SaveChart_btn.Location = new System.Drawing.Point(229, 334);
            this.SaveChart_btn.Name = "SaveChart_btn";
            this.SaveChart_btn.Size = new System.Drawing.Size(75, 23);
            this.SaveChart_btn.TabIndex = 13;
            this.SaveChart_btn.Text = "Save Power Chart";
            this.SaveChart_btn.UseVisualStyleBackColor = false;
            this.SaveChart_btn.Click += new System.EventHandler(this.SaveChart_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1233, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aaaToolStripMenuItem
            // 
            this.aaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveChartToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.aaaToolStripMenuItem.Name = "aaaToolStripMenuItem";
            this.aaaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aaaToolStripMenuItem.Text = "File";
            this.aaaToolStripMenuItem.Click += new System.EventHandler(this.AaaToolStripMenuItem_Click);
            // 
            // saveChartToolStripMenuItem
            // 
            this.saveChartToolStripMenuItem.Name = "saveChartToolStripMenuItem";
            this.saveChartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveChartToolStripMenuItem.Text = "Save Chart";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.innovativeSolarPowerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // innovativeSolarPowerToolStripMenuItem
            // 
            this.innovativeSolarPowerToolStripMenuItem.Name = "innovativeSolarPowerToolStripMenuItem";
            this.innovativeSolarPowerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.innovativeSolarPowerToolStripMenuItem.Text = "Innovative Solar Power";
            // 
            // Quit_btn
            // 
            this.Quit_btn.Location = new System.Drawing.Point(13, 117);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(75, 23);
            this.Quit_btn.TabIndex = 20;
            this.Quit_btn.Text = "Quit";
            this.Quit_btn.UseVisualStyleBackColor = true;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            // 
            // ClearRxData_btn
            // 
            this.ClearRxData_btn.Location = new System.Drawing.Point(13, 19);
            this.ClearRxData_btn.Name = "ClearRxData_btn";
            this.ClearRxData_btn.Size = new System.Drawing.Size(75, 23);
            this.ClearRxData_btn.TabIndex = 7;
            this.ClearRxData_btn.Text = "Clear Data";
            this.ClearRxData_btn.UseVisualStyleBackColor = true;
            this.ClearRxData_btn.Click += new System.EventHandler(this.ClearRxData_btn_Click);
            // 
            // SaveSunLightChart_btn
            // 
            this.SaveSunLightChart_btn.Location = new System.Drawing.Point(264, 338);
            this.SaveSunLightChart_btn.Name = "SaveSunLightChart_btn";
            this.SaveSunLightChart_btn.Size = new System.Drawing.Size(131, 23);
            this.SaveSunLightChart_btn.TabIndex = 17;
            this.SaveSunLightChart_btn.Text = "Save Sun Light Chart";
            this.SaveSunLightChart_btn.UseVisualStyleBackColor = true;
            this.SaveSunLightChart_btn.Click += new System.EventHandler(this.SaveSunLightChart_btn_Click);
            // 
            // SaveData_btn
            // 
            this.SaveData_btn.Location = new System.Drawing.Point(104, 18);
            this.SaveData_btn.Name = "SaveData_btn";
            this.SaveData_btn.Size = new System.Drawing.Size(75, 23);
            this.SaveData_btn.TabIndex = 18;
            this.SaveData_btn.Text = "Save Data";
            this.SaveData_btn.UseVisualStyleBackColor = true;
            this.SaveData_btn.Click += new System.EventHandler(this.SaveData_btn_Click);
            // 
            // SavePosChart_btn
            // 
            this.SavePosChart_btn.Location = new System.Drawing.Point(264, 305);
            this.SavePosChart_btn.Name = "SavePosChart_btn";
            this.SavePosChart_btn.Size = new System.Drawing.Size(131, 23);
            this.SavePosChart_btn.TabIndex = 18;
            this.SavePosChart_btn.Text = "Save Position Chart";
            this.SavePosChart_btn.UseVisualStyleBackColor = true;
            this.SavePosChart_btn.Click += new System.EventHandler(this.SavePosChart_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datetimePosition);
            this.groupBox3.Controls.Add(this.SavePosChart_btn);
            this.groupBox3.Controls.Add(this.chartPosition);
            this.groupBox3.Location = new System.Drawing.Point(600, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 334);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datetimeSunLight);
            this.groupBox4.Controls.Add(this.SaveSunLightChart_btn);
            this.groupBox4.Controls.Add(this.chartSunLight);
            this.groupBox4.Location = new System.Drawing.Point(600, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(611, 363);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.datetimePower);
            this.groupBox5.Controls.Add(this.SaveChart_btn);
            this.groupBox5.Controls.Add(this.chartPower);
            this.groupBox5.Location = new System.Drawing.Point(24, 352);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(570, 363);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // datetimePower
            // 
            this.datetimePower.AutoSize = true;
            this.datetimePower.Location = new System.Drawing.Point(455, 303);
            this.datetimePower.Name = "datetimePower";
            this.datetimePower.Size = new System.Drawing.Size(69, 13);
            this.datetimePower.TabIndex = 14;
            this.datetimePower.Text = "MMDDYYYY";
            // 
            // datetimePosition
            // 
            this.datetimePosition.AutoSize = true;
            this.datetimePosition.Location = new System.Drawing.Point(501, 268);
            this.datetimePosition.Name = "datetimePosition";
            this.datetimePosition.Size = new System.Drawing.Size(69, 13);
            this.datetimePosition.TabIndex = 15;
            this.datetimePosition.Text = "MMDDYYYY";
            // 
            // datetimeSunLight
            // 
            this.datetimeSunLight.AutoSize = true;
            this.datetimeSunLight.Location = new System.Drawing.Point(501, 303);
            this.datetimeSunLight.Name = "datetimeSunLight";
            this.datetimeSunLight.Size = new System.Drawing.Size(69, 13);
            this.datetimeSunLight.TabIndex = 15;
            this.datetimeSunLight.Text = "MMDDYYYY";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1233, 743);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReceivedData_groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chartPower)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ReceivedData_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSunLight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.TextBox HostIP_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPower;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.CheckBox EnableHost_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox ReceivedData_groupBox;
        private System.Windows.Forms.Label SetPort_lbl;
        private System.Windows.Forms.Label SetIP_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPosition;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSunLight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ClientConnected_checkBox;
        private System.Windows.Forms.Panel ClientConnected_panel;
        private System.Windows.Forms.Button ClearChart_btn;
        private System.Windows.Forms.Button SaveChart_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innovativeSolarPowerToolStripMenuItem;
        private System.Windows.Forms.Button Quit_btn;
        private System.Windows.Forms.Button ClearRxData_btn;
        private System.Windows.Forms.Button SaveData_btn;
        private System.Windows.Forms.Button SaveSunLightChart_btn;
        private System.Windows.Forms.Button SavePosChart_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label datetimePower;
        private System.Windows.Forms.Label datetimePosition;
        private System.Windows.Forms.Label datetimeSunLight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}