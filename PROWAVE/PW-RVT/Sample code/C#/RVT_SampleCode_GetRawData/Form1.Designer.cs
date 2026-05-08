namespace ITIR_RVT_SampleCode
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox_COMPort = new System.Windows.Forms.ComboBox();
            this.chart_X = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Y = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Z = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label_OverFlowString = new System.Windows.Forms.Label();
            this.label_NullCount = new System.Windows.Forms.Label();
            this.label_OverFlow = new System.Windows.Forms.Label();
            this.label_NullCountString = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Count = new System.Windows.Forms.Label();
            this.button_Open = new System.Windows.Forms.Button();
            this.label_SampleRateValue = new System.Windows.Forms.Label();
            this.button_Export = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Msg = new System.Windows.Forms.Label();
            this.label_DateTime = new System.Windows.Forms.Label();
            this.label_XString = new System.Windows.Forms.Label();
            this.label_YString = new System.Windows.Forms.Label();
            this.label_ZString = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Z)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_COMPort
            // 
            this.comboBox_COMPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_COMPort.FormattingEnabled = true;
            this.comboBox_COMPort.Location = new System.Drawing.Point(493, 16);
            this.comboBox_COMPort.Name = "comboBox_COMPort";
            this.comboBox_COMPort.Size = new System.Drawing.Size(230, 31);
            this.comboBox_COMPort.TabIndex = 0;
            // 
            // chart_X
            // 
            chartArea1.AxisX.LabelStyle.Format = "D";
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LabelStyle.Format = "N5";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_X.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chart_X, 2);
            this.chart_X.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "X";
            this.chart_X.Legends.Add(legend3);
            this.chart_X.Location = new System.Drawing.Point(6, 147);
            this.chart_X.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.chart_X.Name = "chart_X";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "X";
            series3.MarkerColor = System.Drawing.Color.Blue;
            series3.Name = "Series1";
            this.chart_X.Series.Add(series3);
            this.chart_X.Size = new System.Drawing.Size(1440, 173);
            this.chart_X.TabIndex = 5;
            this.chart_X.Text = "chart1";
            // 
            // chart_Y
            // 
            chartArea3.AxisX.LabelStyle.Format = "D";
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.LabelStyle.Format = "N5";
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart_Y.ChartAreas.Add(chartArea3);
            this.tableLayoutPanel1.SetColumnSpan(this.chart_Y, 2);
            this.chart_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Y";
            this.chart_Y.Legends.Add(legend2);
            this.chart_Y.Location = new System.Drawing.Point(6, 372);
            this.chart_Y.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.chart_Y.Name = "chart_Y";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Y";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.Name = "Series1";
            this.chart_Y.Series.Add(series2);
            this.chart_Y.Size = new System.Drawing.Size(1440, 173);
            this.chart_Y.TabIndex = 6;
            this.chart_Y.Text = "chart2";
            // 
            // chart_Z
            // 
            chartArea2.AxisX.LabelStyle.Format = "D";
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.LabelStyle.Format = "N5";
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_Z.ChartAreas.Add(chartArea2);
            this.tableLayoutPanel1.SetColumnSpan(this.chart_Z, 2);
            this.chart_Z.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Z";
            this.chart_Z.Legends.Add(legend1);
            this.chart_Z.Location = new System.Drawing.Point(6, 599);
            this.chart_Z.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.chart_Z.Name = "chart_Z";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Green;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Z";
            series1.MarkerColor = System.Drawing.Color.Green;
            series1.Name = "Series1";
            this.chart_Z.Series.Add(series1);
            this.chart_Z.Size = new System.Drawing.Size(1440, 176);
            this.chart_Z.TabIndex = 7;
            this.chart_Z.Text = "chart3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart_X, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chart_Z, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.chart_Y, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_COMPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_XString, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_YString, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_ZString, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.295236F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.516121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.74619F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.187817F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.71506F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.71506F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1452, 788);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.label_OverFlowString, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_NullCount, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_OverFlow, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_NullCountString, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(729, 55);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(717, 45);
            this.tableLayoutPanel4.TabIndex = 18;
            // 
            // label_OverFlowString
            // 
            this.label_OverFlowString.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_OverFlowString.AutoSize = true;
            this.label_OverFlowString.Location = new System.Drawing.Point(46, 10);
            this.label_OverFlowString.Name = "label_OverFlowString";
            this.label_OverFlowString.Size = new System.Drawing.Size(130, 24);
            this.label_OverFlowString.TabIndex = 14;
            this.label_OverFlowString.Text = "SecOverFlow:";
            // 
            // label_NullCount
            // 
            this.label_NullCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_NullCount.AutoSize = true;
            this.label_NullCount.Location = new System.Drawing.Point(540, 10);
            this.label_NullCount.Name = "label_NullCount";
            this.label_NullCount.Size = new System.Drawing.Size(21, 24);
            this.label_NullCount.TabIndex = 17;
            this.label_NullCount.Text = "0";
            // 
            // label_OverFlow
            // 
            this.label_OverFlow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_OverFlow.AutoSize = true;
            this.label_OverFlow.Location = new System.Drawing.Point(182, 10);
            this.label_OverFlow.Name = "label_OverFlow";
            this.label_OverFlow.Size = new System.Drawing.Size(21, 24);
            this.label_OverFlow.TabIndex = 15;
            this.label_OverFlow.Text = "0";
            // 
            // label_NullCountString
            // 
            this.label_NullCountString.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_NullCountString.AutoSize = true;
            this.label_NullCountString.Location = new System.Drawing.Point(427, 10);
            this.label_NullCountString.Name = "label_NullCountString";
            this.label_NullCountString.Size = new System.Drawing.Size(107, 24);
            this.label_NullCountString.TabIndex = 16;
            this.label_NullCountString.Text = "NullCount:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label_Count, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_Open, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_SampleRateValue, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_Export, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(729, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(717, 43);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // label_Count
            // 
            this.label_Count.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Count.AutoSize = true;
            this.label_Count.Location = new System.Drawing.Point(540, 9);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(46, 24);
            this.label_Count.TabIndex = 15;
            this.label_Count.Text = "N/A";
            // 
            // button_Open
            // 
            this.button_Open.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Open.Location = new System.Drawing.Point(3, 3);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(156, 37);
            this.button_Open.TabIndex = 12;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // label_SampleRateValue
            // 
            this.label_SampleRateValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_SampleRateValue.AutoSize = true;
            this.label_SampleRateValue.Location = new System.Drawing.Point(361, 9);
            this.label_SampleRateValue.Name = "label_SampleRateValue";
            this.label_SampleRateValue.Size = new System.Drawing.Size(46, 24);
            this.label_SampleRateValue.TabIndex = 12;
            this.label_SampleRateValue.Text = "N/A";
            // 
            // button_Export
            // 
            this.button_Export.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Export.Location = new System.Drawing.Point(182, 3);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(156, 37);
            this.button_Export.TabIndex = 13;
            this.button_Export.Text = "Export";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.38158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.34756F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.31097F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_Msg, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_DateTime, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(717, 45);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "DateTime:";
            // 
            // label_Msg
            // 
            this.label_Msg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Msg.AutoSize = true;
            this.label_Msg.Location = new System.Drawing.Point(388, 10);
            this.label_Msg.Name = "label_Msg";
            this.label_Msg.Size = new System.Drawing.Size(46, 24);
            this.label_Msg.TabIndex = 12;
            this.label_Msg.Text = "N/A";
            // 
            // label_DateTime
            // 
            this.label_DateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_DateTime.AutoSize = true;
            this.label_DateTime.Location = new System.Drawing.Point(143, 10);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Size = new System.Drawing.Size(46, 24);
            this.label_DateTime.TabIndex = 15;
            this.label_DateTime.Text = "N/A";
            // 
            // label_XString
            // 
            this.label_XString.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_XString, 2);
            this.label_XString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_XString.Location = new System.Drawing.Point(6, 103);
            this.label_XString.Name = "label_XString";
            this.label_XString.Size = new System.Drawing.Size(1440, 34);
            this.label_XString.TabIndex = 17;
            this.label_XString.Text = "X";
            this.label_XString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_YString
            // 
            this.label_YString.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_YString, 2);
            this.label_YString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_YString.Location = new System.Drawing.Point(6, 330);
            this.label_YString.Name = "label_YString";
            this.label_YString.Size = new System.Drawing.Size(1440, 32);
            this.label_YString.TabIndex = 18;
            this.label_YString.Text = "Y";
            this.label_YString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ZString
            // 
            this.label_ZString.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_ZString, 2);
            this.label_ZString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ZString.Location = new System.Drawing.Point(6, 555);
            this.label_ZString.Name = "label_ZString";
            this.label_ZString.Size = new System.Drawing.Size(1440, 34);
            this.label_ZString.TabIndex = 19;
            this.label_ZString.Text = "Z";
            this.label_ZString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 788);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RVT_SampleCode_GetRawData";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Z)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_COMPort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_X;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Z;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Msg;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Label label_SampleRateValue;
        private System.Windows.Forms.Label label_XString;
        private System.Windows.Forms.Label label_YString;
        private System.Windows.Forms.Label label_ZString;
        private System.Windows.Forms.Label label_DateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_OverFlow;
        private System.Windows.Forms.Label label_OverFlowString;
        private System.Windows.Forms.Label label_NullCountString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NullCount;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}