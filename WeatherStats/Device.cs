using System;
using System.Collections.Generic;

namespace WeatherStats
{
    public class Device
    {
        private string _name;       // Название прибора

        public Device(string name)
        {
            _name = name;
        }

        public Dictionary<string, List<string>> DeviceData { get; set; } = new Dictionary<string, List<string>>();  // Данные
        public List<string> ValuesList { get; set; } = new List<string>();                                          // Типы данных
        public bool IsChecked { get; set; } = false;                                                                // Смотрели ли уже этот прибор

        public override string ToString()
        {
            return _name;
        }
    }
}