namespace Lab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.valueUSD = new System.Windows.Forms.NumericUpDown();
            this.valueEUR = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lbDays = new System.Windows.Forms.Label();
            this.lbUSD = new System.Windows.Forms.Label();
            this.lbEUR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueEUR)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX2.Minimum = 0D;
            chartArea2.AxisY.Minimum = 30D;
            chartArea2.AxisY2.Minimum = 30D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 135);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "USD";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Lime;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "EUR";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1265, 449);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Price";
            // 
            // valueUSD
            // 
            this.valueUSD.DecimalPlaces = 2;
            this.valueUSD.Location = new System.Drawing.Point(138, 36);
            this.valueUSD.Name = "valueUSD";
            this.valueUSD.Size = new System.Drawing.Size(120, 22);
            this.valueUSD.TabIndex = 1;
            this.valueUSD.Value = new decimal(new int[] {
            742,
            0,
            0,
            65536});
            // 
            // valueEUR
            // 
            this.valueEUR.DecimalPlaces = 2;
            this.valueEUR.Location = new System.Drawing.Point(310, 36);
            this.valueEUR.Name = "valueEUR";
            this.valueEUR.Size = new System.Drawing.Size(120, 22);
            this.valueEUR.TabIndex = 2;
            this.valueEUR.Value = new decimal(new int[] {
            7928,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "USD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "EUR";
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(1100, 17);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(132, 55);
            this.btCalculate.TabIndex = 5;
            this.btCalculate.Text = "START/STOP";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbEUR);
            this.panel1.Controls.Add(this.lbUSD);
            this.panel1.Controls.Add(this.lbDays);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btCalculate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.valueEUR);
            this.panel1.Controls.Add(this.valueUSD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 89);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Days";
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(647, 42);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(16, 16);
            this.lbDays.TabIndex = 7;
            this.lbDays.Text = "...";
            // 
            // lbUSD
            // 
            this.lbUSD.AutoSize = true;
            this.lbUSD.Location = new System.Drawing.Point(726, 42);
            this.lbUSD.Name = "lbUSD";
            this.lbUSD.Size = new System.Drawing.Size(16, 16);
            this.lbUSD.TabIndex = 8;
            this.lbUSD.Text = "...";
            // 
            // lbEUR
            // 
            this.lbEUR.AutoSize = true;
            this.lbEUR.Location = new System.Drawing.Point(801, 42);
            this.lbEUR.Name = "lbEUR";
            this.lbEUR.Size = new System.Drawing.Size(16, 16);
            this.lbEUR.TabIndex = 9;
            this.lbEUR.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 618);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueEUR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown valueUSD;
        private System.Windows.Forms.NumericUpDown valueEUR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbEUR;
        private System.Windows.Forms.Label lbUSD;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label label4;
    }
}

