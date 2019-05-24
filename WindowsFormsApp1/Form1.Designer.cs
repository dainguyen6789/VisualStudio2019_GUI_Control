
using System;

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Start_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Host_label = new System.Windows.Forms.Label();
            this.HostIP_txtbox = new System.Windows.Forms.TextBox();
            this.Port_lbl = new System.Windows.Forms.Label();
            this.Port_txtBox = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(516, 71);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(632, 71);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(75, 23);
            this.Stop_btn.TabIndex = 1;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            // 
            // Host_label
            // 
            this.Host_label.AutoSize = true;
            this.Host_label.Location = new System.Drawing.Point(59, 75);
            this.Host_label.Name = "Host_label";
            this.Host_label.Size = new System.Drawing.Size(29, 13);
            this.Host_label.TabIndex = 2;
            this.Host_label.Text = "Host";
            this.Host_label.Click += new System.EventHandler(this.Label1_Click);
            // 
            // HostIP_txtbox
            // 
            this.HostIP_txtbox.Location = new System.Drawing.Point(94, 71);
            this.HostIP_txtbox.Name = "HostIP_txtbox";
            this.HostIP_txtbox.Size = new System.Drawing.Size(229, 20);
            this.HostIP_txtbox.TabIndex = 3;
            this.HostIP_txtbox.Text = "192.168.11.203";
            // 
            // Port_lbl
            // 
            this.Port_lbl.AutoSize = true;
            this.Port_lbl.Location = new System.Drawing.Point(353, 75);
            this.Port_lbl.Name = "Port_lbl";
            this.Port_lbl.Size = new System.Drawing.Size(26, 13);
            this.Port_lbl.TabIndex = 4;
            this.Port_lbl.Text = "Port";
            // 
            // Port_txtBox
            // 
            this.Port_txtBox.Location = new System.Drawing.Point(385, 71);
            this.Port_txtBox.Name = "Port_txtBox";
            this.Port_txtBox.Size = new System.Drawing.Size(42, 20);
            this.Port_txtBox.TabIndex = 5;
            this.Port_txtBox.Text = "8080";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(94, 116);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(613, 43);
            this.txtStatus.TabIndex = 7;
            this.txtStatus.Text = "";
            // 
            // Send_btn
            // 
            this.Send_btn.Location = new System.Drawing.Point(632, 165);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(75, 23);
            this.Send_btn.TabIndex = 8;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(94, 182);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(532, 228);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 422);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.Port_txtBox);
            this.Controls.Add(this.Port_lbl);
            this.Controls.Add(this.HostIP_txtbox);
            this.Controls.Add(this.Host_label);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Label Host_label;
        private System.Windows.Forms.TextBox HostIP_txtbox;
        private System.Windows.Forms.Label Port_lbl;
        private System.Windows.Forms.TextBox Port_txtBox;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

