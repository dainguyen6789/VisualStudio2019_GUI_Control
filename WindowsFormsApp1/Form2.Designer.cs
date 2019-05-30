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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.SetPort_lbl = new System.Windows.Forms.Label();
            this.SetIP_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ReceivedData_groupBox = new System.Windows.Forms.GroupBox();
            this.chartPosition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSunLight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClientConnected_panel = new System.Windows.Forms.Panel();
            this.ClientConnected_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartPower)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSunLight)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(58, 83);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Init Host";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // HostIP_txtBox
            // 
            this.HostIP_txtBox.Location = new System.Drawing.Point(89, 82);
            this.HostIP_txtBox.Name = "HostIP_txtBox";
            this.HostIP_txtBox.Size = new System.Drawing.Size(100, 20);
            this.HostIP_txtBox.TabIndex = 1;
            this.HostIP_txtBox.Text = "192.168.11.203";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host IP";
            // 
            // Port_txtBox
            // 
            this.Port_txtBox.Location = new System.Drawing.Point(58, 55);
            this.Port_txtBox.Name = "Port_txtBox";
            this.Port_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Port_txtBox.TabIndex = 3;
            this.Port_txtBox.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // chartPower
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPower.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            legend4.Position.Auto = false;
            legend4.Position.Height = 9.638555F;
            legend4.Position.Width = 15F;
            legend4.Position.X = 85F;
            legend4.Position.Y = 5F;
            this.chartPower.Legends.Add(legend4);
            this.chartPower.Location = new System.Drawing.Point(89, 321);
            this.chartPower.Name = "chartPower";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Power (W)";
            this.chartPower.Series.Add(series4);
            this.chartPower.Size = new System.Drawing.Size(472, 250);
            this.chartPower.TabIndex = 5;
            this.chartPower.Text = "chart1";
            title4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title4.Name = "Title1";
            title4.Text = "System Power (W)";
            title4.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartPower.Titles.Add(title4);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(89, 193);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(472, 96);
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Start_btn);
            this.groupBox1.Controls.Add(this.Port_txtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 117);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Config";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Size = new System.Drawing.Size(283, 99);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
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
            this.ReceivedData_groupBox.Location = new System.Drawing.Point(31, 180);
            this.ReceivedData_groupBox.Name = "ReceivedData_groupBox";
            this.ReceivedData_groupBox.Size = new System.Drawing.Size(536, 117);
            this.ReceivedData_groupBox.TabIndex = 12;
            this.ReceivedData_groupBox.TabStop = false;
            this.ReceivedData_groupBox.Text = "Received Data";
            // 
            // chartPosition
            // 
            chartArea5.Name = "ChartArea1";
            this.chartPosition.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartPosition.Legends.Add(legend5);
            this.chartPosition.Location = new System.Drawing.Point(594, 39);
            this.chartPosition.Name = "chartPosition";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Position (mm)";
            this.chartPosition.Series.Add(series5);
            this.chartPosition.Size = new System.Drawing.Size(472, 250);
            this.chartPosition.TabIndex = 14;
            this.chartPosition.Text = "chart2";
            title5.Name = "Title1";
            title5.Text = "Motor Position";
            this.chartPosition.Titles.Add(title5);
            // 
            // chartSunLight
            // 
            chartArea6.Name = "ChartArea1";
            this.chartSunLight.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartSunLight.Legends.Add(legend6);
            this.chartSunLight.Location = new System.Drawing.Point(594, 321);
            this.chartSunLight.Name = "chartSunLight";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Sunlight (W/m2)";
            this.chartSunLight.Series.Add(series6);
            this.chartSunLight.Size = new System.Drawing.Size(472, 250);
            this.chartSunLight.TabIndex = 15;
            this.chartSunLight.Text = "chart3";
            title6.Name = "Title1";
            title6.Text = "Sun Light (W/m2)";
            this.chartSunLight.Titles.Add(title6);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.Red;
            this.panelStatus.Location = new System.Drawing.Point(130, 7);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(34, 33);
            this.panelStatus.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Code:";
            // 
            // ClientConnected_panel
            // 
            this.ClientConnected_panel.BackColor = System.Drawing.Color.Red;
            this.ClientConnected_panel.Location = new System.Drawing.Point(130, 55);
            this.ClientConnected_panel.Name = "ClientConnected_panel";
            this.ClientConnected_panel.Size = new System.Drawing.Size(34, 33);
            this.ClientConnected_panel.TabIndex = 17;
            // 
            // ClientConnected_checkBox
            // 
            this.ClientConnected_checkBox.AutoSize = true;
            this.ClientConnected_checkBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientConnected_checkBox.Location = new System.Drawing.Point(170, 71);
            this.ClientConnected_checkBox.Name = "ClientConnected_checkBox";
            this.ClientConnected_checkBox.Size = new System.Drawing.Size(107, 17);
            this.ClientConnected_checkBox.TabIndex = 18;
            this.ClientConnected_checkBox.Text = "Client Connected";
            this.ClientConnected_checkBox.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 584);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chartSunLight);
            this.Controls.Add(this.chartPosition);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.chartPower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostIP_txtBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReceivedData_groupBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chartPower)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSunLight)).EndInit();
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
    }
}