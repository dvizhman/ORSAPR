﻿namespace TablePlugin.BLL.Models
{
    /// <summary>
    /// Дополнительных параметров для стола.
    /// </summary>
    public class AdditionalParameters
    {
        private double _min;
        private double _max;
        private string _name;

        /// <summary>
        /// Минимальное значение.
        /// </summary>
        public double Min { get => _min; internal set => _min = value; }

        /// <summary>
        /// Максимальное значение.
        /// </summary>
        public double Max { get => _max; internal set => _max = value; }

        /// <summary>s6
        /// Имя имя параметра.
        /// </summary>
        public string Name { get => _name; internal set => _name = value; }
    }
}
