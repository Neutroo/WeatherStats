using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace WeatherStats
{
    public partial class Form1 : Form
    {
        Dictionary<string, Device> devices = new Dictionary<string, Device>();  // Приборы
        string device = null;                                                   // Название прибора
        bool active = false;
        
        public Form1()
        {
            InitializeComponent();

            comboBoxGraphicType.SelectedIndex = 0;                              // Чтобы выбрался первый тип графика

            devices.Add("РОСА К-2 (01) 448 аудитория",          new Device("РОСА К-2 (01) 448 аудитория"));
            devices.Add("Тест Студии (schHome) г. Пушкино",     new Device("Тест Студии (schHome) г. Пушкино"));
            devices.Add("Сервер СЕВ (01) информационный центр", new Device("Сервер СЕВ (01) информационный центр"));
            devices.Add("Сервер СЕВ (02) информационный центр", new Device("Сервер СЕВ (02) информационный центр"));
            devices.Add("Сервер СЕВ (03) информационный центр", new Device("Сервер СЕВ (03) информационный центр"));
            devices.Add("Hydra-L (01) 447 аудитория",           new Device("Hydra-L (01) 447 аудитория"));
            devices.Add("Hydra-L (02) 449 аудитория",           new Device("Hydra-L (02) 449 аудитория"));
            devices.Add("Hydra-L (03) 446 аудитория",           new Device("Hydra-L (03) 446 аудитория"));
            devices.Add("Hydra-L (04) 448 аудитория",           new Device("Hydra-L (04) 448 аудитория"));
            devices.Add("Hydra-L (05) 451 аудитория",           new Device("Hydra-L (05) 451 аудитория"));
            devices.Add("Hydra-L (06) 453 аудитория",           new Device("Hydra-L (06) 453 аудитория"));
            devices.Add("Hydra-L (07) 445 аудитория",           new Device("Hydra-L (07) 445 аудитория"));
            devices.Add("Hydra-L (08) 451 аудитория",           new Device("Hydra-L (08) 451 аудитория"));
            devices.Add("Опорный барометр (01) 448 аудитория",  new Device("Опорный барометр (01) 448 аудитория"));
            devices.Add("Тест воздуха (01)",                    new Device("Тест воздуха (01)"));
        }

        private void Form1Load(object sender, EventArgs e)
        {
            comboBoxDevice.SelectedIndex = 0;                                   // Выбираем первый прибор в комбобоксе
            comboBoxChartType.SelectedIndex = 0;                                // Выбраем первый тип для чарта 
            comboBoxShowIn.SelectedIndex = 0;                                   // Выбираем Default type для данных

            dateTimePicker1.CustomFormat = " MMM dd, yyyy       HH:mm";
            dateTimePicker2.CustomFormat = " MMM dd, yyyy       HH:mm"; 
        }

        private void ButtonCreate(object sender, EventArgs e)
        {
            // <<-- Выбираем тип графика -->> //
            if (comboBoxGraphicType.SelectedItem.ToString() == "Default")
            {
                for (int i = 0; i < devices[device].ValuesList.Count - 1; ++i)
                    switch (comboBoxChartType.SelectedItem.ToString())
                    {
                        case "Line":
                            chart1.Series[devices[device].ValuesList[i + 1]].ChartType = SeriesChartType.Line;
                            break;
                        case "Column":
                            chart1.Series[devices[device].ValuesList[i + 1]].ChartType = SeriesChartType.Column;
                            break;
                        case "Bar":
                            chart1.Series[devices[device].ValuesList[i + 1]].ChartType = SeriesChartType.Bar;
                            break;
                    }

                for (int i = 0; i < checkedListBox1.Items.Count; ++i)
                    chart1.Series[devices[device].ValuesList[i + 1]].Points.Clear();        // Удаляем кривые
            }
            else
            {
                switch (comboBoxChartType.SelectedItem.ToString())
                {
                    case "Line":
                        chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].ChartType = SeriesChartType.Line;
                        break;
                    case "Column":
                        chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].ChartType = SeriesChartType.Column;
                        break;
                    case "Bar":
                        chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].ChartType = SeriesChartType.Bar;
                        break;
                }
                chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].Points.Clear();        // Удаляем кривые
            }

            int hour;                   // Начальный час
            int day;                    // Начальны день
            int month;                  // Начальный месяц

            var dataForInterval = new List<double>();                                   // Лист для измерения данных поинтервально 

            if (comboBoxGraphicType.SelectedItem.ToString() == "Default")
                for (int i = 0; i < checkedListBox1.CheckedIndices.Count; ++i)
                {
                    hour = dateTimePicker1.Value.Hour;
                    day = dateTimePicker1.Value.Day;
                    month = dateTimePicker1.Value.Month;
                    for (int j = 0; j < devices[device].DeviceData["Date"].Count; ++j)
                    {
                        var strTime = devices[device].DeviceData["Date"][j];
                        var time = DateTime.Parse(strTime);                      

                        if (dateTimePicker1.Value <= time && dateTimePicker2.Value.AddMinutes(1) >= time)           // Берем время из заданных промежутков
                            switch (comboBoxShowIn.SelectedItem.ToString())                                         // Смотрим с каким осреднением работать
                            {
                                // <<-- Рисуем график -->> //
                                // chart1.Series[*название серии*], чтобы получить название серии мы закидываем valuesList с индексом текущего отмеченного элемента и +1, потому что пропускаем дату
                                // .Points.AddXY(x, y): первым параметром вставляем дату, вторым параметром закидываем данные из словаря

                                case "Default":
                                    chart1.Series[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]].Points.AddXY(time.ToString(),
                                        devices[device].DeviceData[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]][j]);
                                    break;

                                case "Hour":
                                    if (time.Hour == hour + 1 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))     // Проверяем не перешли ли мы на новый час
                                    {
                                        // Если перешли, то рисуем кривую по серии
                                        chart1.Series[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]].Points.AddXY(time.ToString(), dataForInterval.Average());
                                        dataForInterval.Clear();        // Очищаем лист с данными, которые осредняем, чтобы работать со следующим интервалом
                                        ++hour;                         // Переходим на следующий час
                                        if (hour == 23) hour = 0;       // Если прошли сутки, то обнуляем часы
                                    }
                                    // Добавляем данные в лист текущего интервала
                                    dataForInterval.Add(Convert.ToDouble(devices[device].DeviceData[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]][j]));
                                    break;

                                case "3 hours":
                                    if (time.Hour == hour + 3 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))
                                    {
                                        chart1.Series[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]].Points.AddXY(time.ToString(), dataForInterval.Average());
                                        dataForInterval.Clear();
                                        hour += 3;
                                    }
                                    else if (day != time.Day) { hour = time.Hour; day = time.Day; }
                                    dataForInterval.Add(Convert.ToDouble(devices[device].DeviceData[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]][j]));
                                    break;

                                case "Day":
                                    if (time.Day == day + 1 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))
                                    {
                                        chart1.Series[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]].Points.AddXY(time.ToString(), dataForInterval.Average());
                                        dataForInterval.Clear();
                                        ++day;
                                    }
                                    else if (month != time.Month) { day = time.Day; month = time.Month; }
                                    dataForInterval.Add(Convert.ToDouble(devices[device].DeviceData[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]][j]));
                                    break;

                                case "Max per day":
                                    if (time.Day == day + 1 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))
                                    {
                                        chart1.Series[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]].Points.AddXY(time.ToString(), dataForInterval.Max());
                                        dataForInterval.Clear();
                                        ++day;
                                    }
                                    else if (month != time.Month) { day = time.Day; month = time.Month; }
                                    dataForInterval.Add(Convert.ToDouble(devices[device].DeviceData[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]][j]));
                                    break;

                                case "Min per day":
                                    if (time.Day == day + 1 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))
                                    {
                                        chart1.Series[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]].Points.AddXY(time.ToString(), dataForInterval.Min());
                                        dataForInterval.Clear();
                                        ++day;
                                    }
                                    else if (month != time.Month) { day = time.Day; month = time.Month; }
                                    dataForInterval.Add(Convert.ToDouble(devices[device].DeviceData[devices[device].ValuesList[checkedListBox1.CheckedIndices[i] + 1]][j]));
                                    break;
                            }
                    }
                }
            else
            {
                hour = dateTimePicker1.Value.Hour;
                day = dateTimePicker1.Value.Day;
                month = dateTimePicker1.Value.Month;

                for (int j = 0; j < devices[device].DeviceData["Date"].Count; ++j)
                {
                    var strTime = devices[device].DeviceData["Date"][j];
                    var time = DateTime.Parse(strTime);

                    double formula = Convert.ToDouble(devices[device].DeviceData[$"{comboBoxTemp.SelectedItem}"][j]) - 0.4 * (Convert.ToDouble(devices[device].DeviceData[$"{comboBoxTemp.SelectedItem}"][j]) - 10.0) * (1 - Convert.ToDouble(devices[device].DeviceData[$"{comboBoxHumidity.SelectedItem}"][j]) / 100);

                    if (dateTimePicker1.Value <= time && dateTimePicker2.Value.AddMinutes(1) >= time)           // Берем время из заданных промежутков
                        switch (comboBoxShowIn.SelectedItem.ToString())
                        {
                            case "Default":
                                    chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].Points.AddXY(time.ToString(), formula);                              
                                break;

                            case "Hour":
                                if (time.Hour == hour + 1 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))
                                {
                                    chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].Points.AddXY(time.ToString(), dataForInterval.Average());
                                    dataForInterval.Clear();
                                    ++hour;
                                    if (hour == 23) hour = 0;
                                }
                                dataForInterval.Add(formula);
                                break;

                            case "3 hours":
                                if (time.Hour == hour + 3 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))
                                {
                                    chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].Points.AddXY(time.ToString(), dataForInterval.Average());
                                    dataForInterval.Clear();
                                    hour += 3;
                                }
                                else if (day != time.Day) { hour = time.Hour; day = time.Day; }
                                dataForInterval.Add(formula);
                                break;

                            case "Day":
                                if (time.Day == day + 1 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))
                                {
                                    chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].Points.AddXY(time.ToString(), dataForInterval.Average());
                                    dataForInterval.Clear();
                                    ++day;
                                }
                                else if (month != time.Month) { day = time.Day; month = time.Month; }
                                dataForInterval.Add(formula);
                                break;

                            case "Max per day":
                                if (time.Day == day + 1 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))
                                {
                                    chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].Points.AddXY(time.ToString(), dataForInterval.Max());
                                    dataForInterval.Clear();
                                    ++day;
                                }
                                else if (month != time.Month) { day = time.Day; month = time.Month; }
                                dataForInterval.Add(formula);
                                break;

                            case "Min per day":
                                if (time.Day == day + 1 || time == DateTime.Parse(devices[device].DeviceData["Date"].Last()))
                                {
                                    chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].Points.AddXY(time.ToString(), dataForInterval.Min());                                 
                                    dataForInterval.Clear();
                                    ++day;
                                }
                                else if (month != time.Month) { day = time.Day; month = time.Month; }
                                dataForInterval.Add(formula);
                                break;
                        }
                }
            }
        }
        private void ComboBoxDeviceSelectedIndexChanged(object sender, EventArgs e)
        {
            active = true;

            device = comboBoxDevice.SelectedItem.ToString();                     // device = выбранный прибор               
            checkedListBox1.Items.Clear();
            if (!devices[device].IsChecked)
            {
                string filePath = $@"devicedata\{device}.csv";
                using (var fileStream = new FileStream(filePath, FileMode.Open))
                {
                    using (var reader = new StreamReader(fileStream))
                    {
                        reader.ReadLine();                                      // Просто читаем, потому что первая строчка бесполезна
                        var line = reader.ReadLine();                           // Получаем строку с ключами
                        var values = line.Split(';');                           // Разбиваем строку с ключами
                        devices[device].ValuesList = values.ToList<string>();
                        devices[device].ValuesList.Remove("");                  // Лишний символ

                        var data = new List<List<string>>();
                        foreach (var elem in devices[device].ValuesList)
                            data.Add(new List<string>());                       // Выделяем новый лист под новый тип данных

                        while (!reader.EndOfStream)
                        {
                            var lineOfData = reader.ReadLine();                 // Получаем строку с данными
                            var subsOfData = lineOfData.Split(';');             // Разбиваем строку на данные под ключами
                            var subsOfDataList = subsOfData.ToList<string>();
                            subsOfDataList.Remove("");                          // Лишний символ

                            for (int i = 0; i < devices[device].ValuesList.Count; ++i)
                                data[i].Add(subsOfDataList[i]);                 // Добавляем данные                                                              
                        }
                        for (int i = 0; i < devices[device].ValuesList.Count; ++i)
                            devices[device].DeviceData.Add(devices[device].ValuesList[i], data[i]);     // Добавляем данные о приборе в словарь, 1й параметр - тип данных, 
                                                                                                        // 2й параметр - лист данных
                    }
                }
                devices[device].IsChecked = true;
            }

            comboBoxTemp.Items.Clear();
            comboBoxHumidity.Items.Clear();
            // <<-- Собираем комбобоксы только из температуры и влажности -->> //
            for (int i = 0; i < devices[device].ValuesList.Count - 1; ++i) 
            {
                if (devices[device].ValuesList[i + 1].Contains("temp"))
                    comboBoxTemp.Items.Add(devices[device].ValuesList[i + 1]);
                if (devices[device].ValuesList[i + 1].Contains("humidity"))
                    comboBoxHumidity.Items.Add(devices[device].ValuesList[i + 1]);
            }

            if (comboBoxTemp.Items.Count != 0 && comboBoxHumidity.Items.Count != 0)     // Если есть датчики температуры и влажности, то выбираем первые
            {
                comboBoxTemp.SelectedIndex = 0;
                comboBoxHumidity.SelectedIndex = 0;
            }
            else                                                                        // Иначе выбираем пустые строчки
            {
                comboBoxTemp.Items.Add("");
                comboBoxHumidity.Items.Add("");
                comboBoxTemp.SelectedIndex = 0;
                comboBoxHumidity.SelectedIndex = 0;
            }

            // <<-- Рисуем series -->> //
            if (comboBoxGraphicType.SelectedItem.ToString() == "Default")
            {
                for (int i = 0; i < devices[device].ValuesList.Count - 1; ++i)
                    checkedListBox1.Items.Add(devices[device].ValuesList[i + 1]);       // Добавляем типы данных в чеклистбокс

                chart1.Series.Clear();
                for (int i = 0; i < devices[device].ValuesList.Count - 1; ++i)
                {
                    chart1.Series.Add(devices[device].ValuesList[i + 1]);
                    chart1.Series[devices[device].ValuesList[i + 1]].BorderWidth = 2;
                }
            }
            else
            {
                chart1.Series.Clear();
                chart1.Series.Add($"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}");
                chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].BorderWidth = 2;
            }
        }

        private void ComboBoxGraphicTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGraphicType.SelectedItem.ToString() == "Default")        // Смотрим на тип графика
            {
                chart1.Series.Clear();
                if (active)
                    for (int i = 0; i < devices[device].ValuesList.Count - 1; ++i)
                    {
                        chart1.Series.Add(devices[device].ValuesList[i + 1]);               // Добавляем серию
                        chart1.Series[devices[device].ValuesList[i + 1]].BorderWidth = 2;   // Толщина кривой
                        checkedListBox1.Items.Add(devices[device].ValuesList[i + 1]);       // Добавляем итем в чеклистбокс
                    }

                // <<-- Меняем видимость используемых и неиспользуемых элементов -->> //
                checkedListBox1.Visible = true;
                labelTemp.Visible = false;
                labelHumidity.Visible = false;
                comboBoxTemp.Visible = false;
                comboBoxHumidity.Visible = false;
            }
            else 
            {
                chart1.Series.Clear();
                checkedListBox1.Items.Clear();
                if (comboBoxTemp.Items.Count != 0 && comboBoxHumidity.Items.Count != 0)
                {
                    comboBoxTemp.SelectedIndex = 0;
                    comboBoxHumidity.SelectedIndex = 0;
                    chart1.Series.Add($"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}");
                    chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].BorderWidth = 2;
                }
                else
                {
                    comboBoxTemp.Items.Add("");
                    comboBoxHumidity.Items.Add("");
                    comboBoxTemp.SelectedIndex = 0;
                    comboBoxHumidity.SelectedIndex = 0;
                }
                checkedListBox1.Visible = false;
                labelTemp.Visible = true;
                labelHumidity.Visible = true;
                comboBoxTemp.Visible = true;
                comboBoxHumidity.Visible = true;
            }     
        }
        private void ComboBoxTempSelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add($"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}");
            chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].BorderWidth = 2;
        }
        private void ComboBoxHumiditySelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add($"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}");
            chart1.Series[$"{comboBoxTemp.SelectedItem},\n{comboBoxHumidity.SelectedItem}"].BorderWidth = 2;
        }
    }
}