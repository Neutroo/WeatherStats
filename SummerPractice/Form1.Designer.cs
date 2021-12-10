
namespace WeatherStats
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.labelChartType = new System.Windows.Forms.Label();
            this.labelDevice = new System.Windows.Forms.Label();
            this.comboBoxShowIn = new System.Windows.Forms.ComboBox();
            this.labelShowIn = new System.Windows.Forms.Label();
            this.comboBoxGraphicType = new System.Windows.Forms.ComboBox();
            this.labelGraphicType = new System.Windows.Forms.Label();
            this.comboBoxTemp = new System.Windows.Forms.ComboBox();
            this.comboBoxHumidity = new System.Windows.Forms.ComboBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(1066, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonCreate);
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDevice.BackColor = System.Drawing.Color.White;
            this.comboBoxDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Items.AddRange(new object[] {
            "РОСА К-2 (01) 448 аудитория",
            "Тест Студии (schHome) г. Пушкино",
            "Сервер СЕВ (01) информационный центр",
            "Сервер СЕВ (02) информационный центр",
            "Сервер СЕВ (03) информационный центр",
            "Hydra-L (01) 447 аудитория",
            "Hydra-L (02) 449 аудитория",
            "Hydra-L (03) 446 аудитория",
            "Hydra-L (04) 448 аудитория",
            "Hydra-L (05) 451 аудитория",
            "Hydra-L (06) 453 аудитория",
            "Hydra-L (07) 445 аудитория",
            "Hydra-L (08) 451 аудитория",
            "Опорный барометр (01) 448 аудитория",
            "Тест воздуха (01)"});
            this.comboBoxDevice.Location = new System.Drawing.Point(340, 590);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(282, 23);
            this.comboBoxDevice.TabIndex = 2;
            this.comboBoxDevice.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeviceSelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chart1.BackSecondaryColor = System.Drawing.Color.DeepSkyBlue;
            this.chart1.BorderlineColor = System.Drawing.Color.DimGray;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Empty;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.Empty;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 8;
            legend1.BorderColor = System.Drawing.Color.DimGray;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 10);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Size = new System.Drawing.Size(1050, 559);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBox1.BackColor = System.Drawing.Color.White;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.Location = new System.Drawing.Point(1066, 10);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(130, 559);
            this.checkedListBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 590);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 4, 12, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 21);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 12, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(55, 622);
            this.dateTimePicker2.MaxDate = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2021, 4, 12, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(168, 21);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Value = new System.DateTime(2021, 5, 9, 0, 0, 0, 0);
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(10, 593);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(39, 15);
            this.labelFrom.TabIndex = 7;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.Location = new System.Drawing.Point(10, 625);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(39, 15);
            this.labelTo.TabIndex = 8;
            this.labelTo.Text = "To:     ";
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxChartType.BackColor = System.Drawing.Color.White;
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChartType.FormattingEnabled = true;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "Line",
            "Column",
            "Bar"});
            this.comboBoxChartType.Location = new System.Drawing.Point(943, 590);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(118, 23);
            this.comboBoxChartType.TabIndex = 9;
            // 
            // labelChartType
            // 
            this.labelChartType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChartType.AutoSize = true;
            this.labelChartType.BackColor = System.Drawing.Color.DarkTurquoise;
            this.labelChartType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChartType.Location = new System.Drawing.Point(873, 593);
            this.labelChartType.Name = "labelChartType";
            this.labelChartType.Size = new System.Drawing.Size(64, 15);
            this.labelChartType.TabIndex = 10;
            this.labelChartType.Text = "Chart type:";
            // 
            // labelDevice
            // 
            this.labelDevice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDevice.AutoSize = true;
            this.labelDevice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDevice.Location = new System.Drawing.Point(256, 593);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(77, 15);
            this.labelDevice.TabIndex = 11;
            this.labelDevice.Text = "Device:          ";
            // 
            // comboBoxShowIn
            // 
            this.comboBoxShowIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxShowIn.BackColor = System.Drawing.Color.White;
            this.comboBoxShowIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxShowIn.FormattingEnabled = true;
            this.comboBoxShowIn.Items.AddRange(new object[] {
            "Default",
            "Hour",
            "3 hours",
            "Day",
            "Max per day",
            "Min per day"});
            this.comboBoxShowIn.Location = new System.Drawing.Point(943, 622);
            this.comboBoxShowIn.Name = "comboBoxShowIn";
            this.comboBoxShowIn.Size = new System.Drawing.Size(118, 23);
            this.comboBoxShowIn.TabIndex = 12;
            // 
            // labelShowIn
            // 
            this.labelShowIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelShowIn.AutoSize = true;
            this.labelShowIn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.labelShowIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowIn.Location = new System.Drawing.Point(873, 625);
            this.labelShowIn.Name = "labelShowIn";
            this.labelShowIn.Size = new System.Drawing.Size(63, 15);
            this.labelShowIn.TabIndex = 13;
            this.labelShowIn.Text = "Show in:   ";
            // 
            // comboBoxGraphicType
            // 
            this.comboBoxGraphicType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGraphicType.BackColor = System.Drawing.Color.White;
            this.comboBoxGraphicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGraphicType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGraphicType.FormattingEnabled = true;
            this.comboBoxGraphicType.Items.AddRange(new object[] {
            "Default",
            "Effective temperature"});
            this.comboBoxGraphicType.Location = new System.Drawing.Point(340, 622);
            this.comboBoxGraphicType.Name = "comboBoxGraphicType";
            this.comboBoxGraphicType.Size = new System.Drawing.Size(282, 23);
            this.comboBoxGraphicType.TabIndex = 14;
            this.comboBoxGraphicType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGraphicTypeSelectedIndexChanged);
            // 
            // labelGraphicType
            // 
            this.labelGraphicType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGraphicType.AutoSize = true;
            this.labelGraphicType.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGraphicType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraphicType.Location = new System.Drawing.Point(256, 625);
            this.labelGraphicType.Name = "labelGraphicType";
            this.labelGraphicType.Size = new System.Drawing.Size(78, 15);
            this.labelGraphicType.TabIndex = 15;
            this.labelGraphicType.Text = "Graphic type:";
            // 
            // comboBoxTemp
            // 
            this.comboBoxTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTemp.BackColor = System.Drawing.Color.White;
            this.comboBoxTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTemp.FormattingEnabled = true;
            this.comboBoxTemp.Location = new System.Drawing.Point(717, 590);
            this.comboBoxTemp.Name = "comboBoxTemp";
            this.comboBoxTemp.Size = new System.Drawing.Size(126, 23);
            this.comboBoxTemp.TabIndex = 16;
            this.comboBoxTemp.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTempSelectedIndexChanged);
            // 
            // comboBoxHumidity
            // 
            this.comboBoxHumidity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxHumidity.BackColor = System.Drawing.Color.White;
            this.comboBoxHumidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxHumidity.FormattingEnabled = true;
            this.comboBoxHumidity.Location = new System.Drawing.Point(717, 622);
            this.comboBoxHumidity.Name = "comboBoxHumidity";
            this.comboBoxHumidity.Size = new System.Drawing.Size(126, 23);
            this.comboBoxHumidity.TabIndex = 17;
            this.comboBoxHumidity.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHumiditySelectedIndexChanged);
            // 
            // labelTemp
            // 
            this.labelTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemp.Location = new System.Drawing.Point(654, 593);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(57, 15);
            this.labelTemp.TabIndex = 18;
            this.labelTemp.Text = "Temp:     ";
            // 
            // labelHumidity
            // 
            this.labelHumidity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.BackColor = System.Drawing.Color.DarkTurquoise;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHumidity.Location = new System.Drawing.Point(654, 625);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(58, 15);
            this.labelHumidity.TabIndex = 19;
            this.labelHumidity.Text = "Humidity:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1206, 679);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.comboBoxHumidity);
            this.Controls.Add(this.comboBoxTemp);
            this.Controls.Add(this.labelGraphicType);
            this.Controls.Add(this.comboBoxGraphicType);
            this.Controls.Add(this.labelShowIn);
            this.Controls.Add(this.comboBoxShowIn);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.labelChartType);
            this.Controls.Add(this.comboBoxChartType);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Stats";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Label labelChartType;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.ComboBox comboBoxShowIn;
        private System.Windows.Forms.Label labelShowIn;
        private System.Windows.Forms.ComboBox comboBoxGraphicType;
        private System.Windows.Forms.Label labelGraphicType;
        private System.Windows.Forms.ComboBox comboBoxTemp;
        private System.Windows.Forms.ComboBox comboBoxHumidity;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelHumidity;
    }
}

