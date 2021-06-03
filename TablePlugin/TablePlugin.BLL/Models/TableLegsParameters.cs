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
                ValidateValue(value, "Высота ножек");
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
                ValidateValue(value, "Длина ножек");
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
                ValidateValue(value, "Ширина ножек");
                _width = Math.Truncate(value);
            }
        }


        /// <summary>
        /// Проверка присваиваемого значения на double.
        /// </summary>
        /// <param name="value">Присваиваемая переменная.</param>
        /// <param name="name">Имя параметра.</param>
        private static void ValidateValue(double value, string name)
        {
            //TODO: Duplication
            //if (double.IsNaN(value) || double.IsInfinity(value))
            //{
            //    throw new ArgumentException("Значение не является числом типа double");
            //}

            if (Math.Abs(value - Math.Truncate(value)) > 0.001d)
            {
                throw new ArgumentException($"Значение поля '{name}' не может быть дробным");
            }
            
            if (value <= 0)
            {
                throw new ArgumentException($"{name} не может быть меньше или равна нулю!");
            }
        }
    }
}
