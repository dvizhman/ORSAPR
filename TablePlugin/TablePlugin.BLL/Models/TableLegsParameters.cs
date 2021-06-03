using System;
using TablePlugin.BLL.Enums;

namespace TablePlugin.BLL.Models
{
    /// <summary>
    /// Параметры ножек стола.
    /// </summary>
    public struct TableLegsParameters
    {
        private double _height;
        private double _length;
        private double _width;

        /// <summary>
        /// Высота ножек.
        /// </summary>
        public double Height
        {
            get => _height;
            set
            {
                TableParameters.ValidateValue(value, "Высота ножек");
                _height = Math.Truncate(value);
            }
        }

        /// <summary>
        /// Длина ножек.
        /// </summary>
        public double Length
        {
            get => _length;
            set
            {
                TableParameters.ValidateValue(value, "Длина ножек");
                _length = Math.Truncate(value);
            }
        }

        /// <summary>
        /// Ширина ножек.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                TableParameters.ValidateValue(value, "Ширина ножек");
                _width = Math.Truncate(value);
            }
        }

    }
}
