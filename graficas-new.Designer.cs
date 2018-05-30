namespace WindowsFormsApp8
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartCriminal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCriminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMes)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCriminal
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCriminal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCriminal.Legends.Add(legend1);
            this.chartCriminal.Location = new System.Drawing.Point(12, 57);
            this.chartCriminal.Name = "chartCriminal";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Estaciones";
            this.chartCriminal.Series.Add(series1);
            this.chartCriminal.Size = new System.Drawing.Size(267, 230);
            this.chartCriminal.TabIndex = 0;
            this.chartCriminal.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Crimenes por Estacion";
            this.chartCriminal.Titles.Add(title1);
            // 
            // chartMes
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMes.Legends.Add(legend2);
            this.chartMes.Location = new System.Drawing.Point(350, 57);
            this.chartMes.Name = "chartMes";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Mes";
            this.chartMes.Series.Add(series2);
            this.chartMes.Size = new System.Drawing.Size(277, 230);
            this.chartMes.TabIndex = 1;
            this.chartMes.Text = "Mes";
            title2.Name = "Title1";
            title2.Text = "Denuncias por Mes";
            this.chartMes.Titles.Add(title2);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(273, 319);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(100, 38);
            this.Actualizar.TabIndex = 2;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 367);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.chartMes);
            this.Controls.Add(this.chartCriminal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartCriminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCriminal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMes;
        private System.Windows.Forms.Button Actualizar;
    }
}

