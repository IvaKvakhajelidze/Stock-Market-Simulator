using System.Drawing;

namespace Project_3
{
    partial class StockMarketForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMarketForm));
            this.StockMarketChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.AAPL_button = new System.Windows.Forms.Button();
            this.MSFT_button = new System.Windows.Forms.Button();
            this.AMZN_button = new System.Windows.Forms.Button();
            this.GOOGL_button = new System.Windows.Forms.Button();
            this.TSLA_button = new System.Windows.Forms.Button();
            this.META_button = new System.Windows.Forms.Button();
            this.NFLX_button = new System.Windows.Forms.Button();
            this.NVDA_button = new System.Windows.Forms.Button();
            this.INTC_button = new System.Windows.Forms.Button();
            this.KO_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buy_btn = new System.Windows.Forms.Button();
            this.sell_btn = new System.Windows.Forms.Button();
            this.stockName_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.stockName_TextBox = new System.Windows.Forms.RichTextBox();
            this.quantity_TextBox = new System.Windows.Forms.RichTextBox();
            this.balance_label = new System.Windows.Forms.Label();
            this.balanceAmount = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockMarketChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StockMarketChart
            // 
            this.StockMarketChart.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Snow;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.White;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Snow;
            chartArea1.Name = "ChartArea1";
            this.StockMarketChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.DarkSlateGray;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.StockMarketChart.Legends.Add(legend1);
            this.StockMarketChart.Location = new System.Drawing.Point(379, 90);
            this.StockMarketChart.Name = "StockMarketChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Goldenrod;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Goldenrod;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Goldenrod;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Goldenrod;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Goldenrod;
            series5.Legend = "Legend1";
            series5.Name = "Series5";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Goldenrod;
            series6.Legend = "Legend1";
            series6.Name = "Series6";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Goldenrod;
            series7.Legend = "Legend1";
            series7.Name = "Series7";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Goldenrod;
            series8.Legend = "Legend1";
            series8.Name = "Series8";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Goldenrod;
            series9.Legend = "Legend1";
            series9.Name = "Series9";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Goldenrod;
            series10.Legend = "Legend1";
            series10.Name = "Series10";
            this.StockMarketChart.Series.Add(series1);
            this.StockMarketChart.Series.Add(series2);
            this.StockMarketChart.Series.Add(series3);
            this.StockMarketChart.Series.Add(series4);
            this.StockMarketChart.Series.Add(series5);
            this.StockMarketChart.Series.Add(series6);
            this.StockMarketChart.Series.Add(series7);
            this.StockMarketChart.Series.Add(series8);
            this.StockMarketChart.Series.Add(series9);
            this.StockMarketChart.Series.Add(series10);
            this.StockMarketChart.Size = new System.Drawing.Size(461, 274);
            this.StockMarketChart.TabIndex = 0;
            this.StockMarketChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(531, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRICES";
            // 
            // AAPL_button
            // 
            this.AAPL_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AAPL_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.AAPL_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AAPL_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAPL_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.AAPL_button.Location = new System.Drawing.Point(52, 107);
            this.AAPL_button.Name = "AAPL_button";
            this.AAPL_button.Size = new System.Drawing.Size(114, 40);
            this.AAPL_button.TabIndex = 2;
            this.AAPL_button.Text = "AAPL";
            this.AAPL_button.UseVisualStyleBackColor = false;
            this.AAPL_button.Click += new System.EventHandler(this.AAPL_button_Click);
            // 
            // MSFT_button
            // 
            this.MSFT_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MSFT_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.MSFT_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MSFT_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSFT_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.MSFT_button.Location = new System.Drawing.Point(52, 164);
            this.MSFT_button.Name = "MSFT_button";
            this.MSFT_button.Size = new System.Drawing.Size(114, 40);
            this.MSFT_button.TabIndex = 3;
            this.MSFT_button.Text = "MSFT";
            this.MSFT_button.UseVisualStyleBackColor = false;
            this.MSFT_button.Click += new System.EventHandler(this.MSFT_button_Click);
            // 
            // AMZN_button
            // 
            this.AMZN_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AMZN_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.AMZN_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AMZN_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMZN_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.AMZN_button.Location = new System.Drawing.Point(52, 222);
            this.AMZN_button.Name = "AMZN_button";
            this.AMZN_button.Size = new System.Drawing.Size(114, 40);
            this.AMZN_button.TabIndex = 4;
            this.AMZN_button.Text = "AMZN";
            this.AMZN_button.UseVisualStyleBackColor = false;
            this.AMZN_button.Click += new System.EventHandler(this.AMZN_button_Click);
            // 
            // GOOGL_button
            // 
            this.GOOGL_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GOOGL_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.GOOGL_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GOOGL_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GOOGL_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.GOOGL_button.Location = new System.Drawing.Point(52, 280);
            this.GOOGL_button.Name = "GOOGL_button";
            this.GOOGL_button.Size = new System.Drawing.Size(114, 40);
            this.GOOGL_button.TabIndex = 5;
            this.GOOGL_button.Text = "GOOGL";
            this.GOOGL_button.UseVisualStyleBackColor = false;
            this.GOOGL_button.Click += new System.EventHandler(this.GOOGL_button_Click);
            // 
            // TSLA_button
            // 
            this.TSLA_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TSLA_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TSLA_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSLA_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSLA_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.TSLA_button.Location = new System.Drawing.Point(52, 335);
            this.TSLA_button.Name = "TSLA_button";
            this.TSLA_button.Size = new System.Drawing.Size(114, 40);
            this.TSLA_button.TabIndex = 6;
            this.TSLA_button.Text = "TSLA";
            this.TSLA_button.UseVisualStyleBackColor = false;
            this.TSLA_button.Click += new System.EventHandler(this.TSLA_button_Click);
            // 
            // META_button
            // 
            this.META_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.META_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.META_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.META_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.META_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.META_button.Location = new System.Drawing.Point(203, 107);
            this.META_button.Name = "META_button";
            this.META_button.Size = new System.Drawing.Size(114, 40);
            this.META_button.TabIndex = 7;
            this.META_button.Text = "META";
            this.META_button.UseVisualStyleBackColor = false;
            this.META_button.Click += new System.EventHandler(this.META_button_Click);
            // 
            // NFLX_button
            // 
            this.NFLX_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.NFLX_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.NFLX_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NFLX_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NFLX_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.NFLX_button.Location = new System.Drawing.Point(203, 164);
            this.NFLX_button.Name = "NFLX_button";
            this.NFLX_button.Size = new System.Drawing.Size(114, 40);
            this.NFLX_button.TabIndex = 8;
            this.NFLX_button.Text = "NFLX";
            this.NFLX_button.UseVisualStyleBackColor = false;
            this.NFLX_button.Click += new System.EventHandler(this.NFLX_button_Click);
            // 
            // NVDA_button
            // 
            this.NVDA_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.NVDA_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.NVDA_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NVDA_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NVDA_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.NVDA_button.Location = new System.Drawing.Point(203, 222);
            this.NVDA_button.Name = "NVDA_button";
            this.NVDA_button.Size = new System.Drawing.Size(114, 40);
            this.NVDA_button.TabIndex = 9;
            this.NVDA_button.Text = "NVDA";
            this.NVDA_button.UseVisualStyleBackColor = false;
            this.NVDA_button.Click += new System.EventHandler(this.NVDA_button_Click);
            // 
            // INTC_button
            // 
            this.INTC_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.INTC_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.INTC_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INTC_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTC_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.INTC_button.Location = new System.Drawing.Point(203, 280);
            this.INTC_button.Name = "INTC_button";
            this.INTC_button.Size = new System.Drawing.Size(114, 40);
            this.INTC_button.TabIndex = 10;
            this.INTC_button.Text = "INTC";
            this.INTC_button.UseVisualStyleBackColor = false;
            this.INTC_button.Click += new System.EventHandler(this.INTC_button_Click);
            // 
            // KO_button
            // 
            this.KO_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.KO_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.KO_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KO_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KO_button.ForeColor = System.Drawing.Color.DarkOrange;
            this.KO_button.Location = new System.Drawing.Point(203, 335);
            this.KO_button.Name = "KO_button";
            this.KO_button.Size = new System.Drawing.Size(114, 40);
            this.KO_button.TabIndex = 11;
            this.KO_button.Text = "KO";
            this.KO_button.UseVisualStyleBackColor = false;
            this.KO_button.Click += new System.EventHandler(this.KO_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(84, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "STOCKS";
            // 
            // buy_btn
            // 
            this.buy_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buy_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_btn.ForeColor = System.Drawing.Color.DarkOrange;
            this.buy_btn.Location = new System.Drawing.Point(221, 487);
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Size = new System.Drawing.Size(131, 50);
            this.buy_btn.TabIndex = 13;
            this.buy_btn.Text = "Buy";
            this.buy_btn.UseVisualStyleBackColor = false;
            this.buy_btn.Click += new System.EventHandler(this.buy_btn_Click);
            // 
            // sell_btn
            // 
            this.sell_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sell_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.sell_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sell_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_btn.ForeColor = System.Drawing.Color.DarkOrange;
            this.sell_btn.Location = new System.Drawing.Point(405, 487);
            this.sell_btn.Name = "sell_btn";
            this.sell_btn.Size = new System.Drawing.Size(149, 50);
            this.sell_btn.TabIndex = 14;
            this.sell_btn.Text = "Sell";
            this.sell_btn.UseVisualStyleBackColor = false;
            this.sell_btn.Click += new System.EventHandler(this.sell_btn_Click);
            // 
            // stockName_label
            // 
            this.stockName_label.AutoSize = true;
            this.stockName_label.BackColor = System.Drawing.Color.Transparent;
            this.stockName_label.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockName_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.stockName_label.Location = new System.Drawing.Point(21, 428);
            this.stockName_label.Name = "stockName_label";
            this.stockName_label.Size = new System.Drawing.Size(136, 23);
            this.stockName_label.TabIndex = 15;
            this.stockName_label.Text = "Stock Name:";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.BackColor = System.Drawing.Color.Transparent;
            this.quantity_label.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.quantity_label.Location = new System.Drawing.Point(306, 428);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(220, 23);
            this.quantity_label.TabIndex = 16;
            this.quantity_label.Text = "Quantity of shares:";
            // 
            // stockName_TextBox
            // 
            this.stockName_TextBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.stockName_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockName_TextBox.ForeColor = System.Drawing.Color.White;
            this.stockName_TextBox.Location = new System.Drawing.Point(179, 428);
            this.stockName_TextBox.Name = "stockName_TextBox";
            this.stockName_TextBox.Size = new System.Drawing.Size(121, 23);
            this.stockName_TextBox.TabIndex = 17;
            this.stockName_TextBox.Text = "";
            // 
            // quantity_TextBox
            // 
            this.quantity_TextBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.quantity_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantity_TextBox.ForeColor = System.Drawing.Color.White;
            this.quantity_TextBox.Location = new System.Drawing.Point(561, 428);
            this.quantity_TextBox.Name = "quantity_TextBox";
            this.quantity_TextBox.Size = new System.Drawing.Size(121, 23);
            this.quantity_TextBox.TabIndex = 18;
            this.quantity_TextBox.Text = "";
            // 
            // balance_label
            // 
            this.balance_label.AutoSize = true;
            this.balance_label.BackColor = System.Drawing.Color.Transparent;
            this.balance_label.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.balance_label.Location = new System.Drawing.Point(692, 378);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(101, 23);
            this.balance_label.TabIndex = 19;
            this.balance_label.Text = "Balance:";
            // 
            // balanceAmount
            // 
            this.balanceAmount.AutoSize = true;
            this.balanceAmount.BackColor = System.Drawing.Color.Transparent;
            this.balanceAmount.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceAmount.ForeColor = System.Drawing.Color.DarkOrange;
            this.balanceAmount.Location = new System.Drawing.Point(799, 378);
            this.balanceAmount.Name = "balanceAmount";
            this.balanceAmount.Size = new System.Drawing.Size(0, 23);
            this.balanceAmount.TabIndex = 20;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.DarkOrange;
            this.close_btn.Location = new System.Drawing.Point(712, 514);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(174, 41);
            this.close_btn.TabIndex = 21;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 567);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.balanceAmount);
            this.Controls.Add(this.balance_label);
            this.Controls.Add(this.quantity_TextBox);
            this.Controls.Add(this.stockName_TextBox);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.stockName_label);
            this.Controls.Add(this.sell_btn);
            this.Controls.Add(this.buy_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KO_button);
            this.Controls.Add(this.INTC_button);
            this.Controls.Add(this.NVDA_button);
            this.Controls.Add(this.NFLX_button);
            this.Controls.Add(this.META_button);
            this.Controls.Add(this.TSLA_button);
            this.Controls.Add(this.GOOGL_button);
            this.Controls.Add(this.AMZN_button);
            this.Controls.Add(this.MSFT_button);
            this.Controls.Add(this.AAPL_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockMarketChart);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StockMarketChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StockMarketChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AAPL_button;
        private System.Windows.Forms.Button MSFT_button;
        private System.Windows.Forms.Button AMZN_button;
        private System.Windows.Forms.Button GOOGL_button;
        private System.Windows.Forms.Button TSLA_button;
        private System.Windows.Forms.Button META_button;
        private System.Windows.Forms.Button NFLX_button;
        private System.Windows.Forms.Button NVDA_button;
        private System.Windows.Forms.Button INTC_button;
        private System.Windows.Forms.Button KO_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buy_btn;
        private System.Windows.Forms.Button sell_btn;
        private System.Windows.Forms.Label stockName_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.RichTextBox stockName_TextBox;
        private System.Windows.Forms.RichTextBox quantity_TextBox;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.Label balanceAmount;
        private System.Windows.Forms.Button close_btn;
    }
}