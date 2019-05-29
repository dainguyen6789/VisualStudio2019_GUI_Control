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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Start_btn = new System.Windows.Forms.Button();
            this.HostIP_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Port_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.label5 = new System.Windows.Forms.Label();
            this.chartPosition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSunLight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.HostIP_txtBox.Size = new System.Drawing.Size(241, 20);
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 9.638555F;
            legend1.Position.Width = 15F;
            legend1.Position.X = 85F;
            legend1.Position.Y = 5F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(89, 321);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Power (W)";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(472, 250);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title1.Name = "Title1";
            title1.Text = "System Power (W)";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart1.Titles.Add(title1);
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
            this.EnableHost_checkBox.Location = new System.Drawing.Point(6, 19);
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
            this.groupBox1.Size = new System.Drawing.Size(536, 117);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Config";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SetPort_lbl);
            this.groupBox2.Controls.Add(this.SetIP_lbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EnableHost_checkBox);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Location = new System.Drawing.Point(314, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 92);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // SetPort_lbl
            // 
            this.SetPort_lbl.AutoSize = true;
            this.SetPort_lbl.Location = new System.Drawing.Point(78, 69);
            this.SetPort_lbl.Name = "SetPort_lbl";
            this.SetPort_lbl.Size = new System.Drawing.Size(31, 13);
            this.SetPort_lbl.TabIndex = 16;
            this.SetPort_lbl.Text = "0000";
            // 
            // SetIP_lbl
            // 
            this.SetIP_lbl.AutoSize = true;
            this.SetIP_lbl.Location = new System.Drawing.Point(78, 43);
            this.SetIP_lbl.Name = "SetIP_lbl";
            this.SetIP_lbl.Size = new System.Drawing.Size(40, 13);
            this.SetIP_lbl.TabIndex = 15;
            this.SetIP_lbl.Text = "0.0.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 43);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // chartPosition
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPosition.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPosition.Legends.Add(legend2);
            this.chartPosition.Location = new System.Drawing.Point(594, 57);
            this.chartPosition.Name = "chartPosition";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Position (mm)";
            this.chartPosition.Series.Add(series2);
            this.chartPosition.Size = new System.Drawing.Size(472, 250);
            this.chartPosition.TabIndex = 14;
            this.chartPosition.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Motor Position";
            this.chartPosition.Titles.Add(title2);
            // 
            // chartSunLight
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSunLight.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSunLight.Legends.Add(legend3);
            this.chartSunLight.Location = new System.Drawing.Point(594, 321);
            this.chartSunLight.Name = "chartSunLight";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sunlight (W/m2)";
            this.chartSunLight.Series.Add(series3);
            this.chartSunLight.Size = new System.Drawing.Size(472, 250);
            this.chartSunLight.TabIndex = 15;
            this.chartSunLight.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Sun Light (W/m2)";
            this.chartSunLight.Titles.Add(title3);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 584);
            this.Controls.Add(this.chartSunLight);
            this.Controls.Add(this.chartPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostIP_txtBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReceivedData_groupBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPosition;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSunLight;
    }
}