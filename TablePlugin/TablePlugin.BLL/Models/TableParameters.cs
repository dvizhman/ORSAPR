using System;
using System.Collections.Generic;
using System.Linq;
using TablePlugin.BLL.Enums;

namespace TablePlugin.BLL.Models
{
    /// <summary>
    /// Класс параметров стола.
    /// </summary>
    public class TableParameters
    {
        /// <summary>
        /// Параметры столешницы.
        /// </summary>
        private TableTopParameters _tableTop;
       
        /// <summary>
        /// Параметры ножек стола.
        /// </summary>
        private TableLegsParameters _tableLegs;

        /// <summary>
        /// Допольнительные параметры стола.
        /// </summary>
        private readonly Dictionary<ParametersType, AdditionalParameters> _additionalParameters;

        public TableParameters()
        {
            _additionalParameters = new Dictionary<ParametersType, AdditionalParameters>
            {

                {
                    ParametersType.TableTopLength, 
                    new AdditionalParameters { Min = 550, Max = 900, Name = "Длина столешницы" }
                },
                {
                    ParametersType.TableTopWidth, 
                    new AdditionalParameters { Min = 550, Max = 900, Name = "Ширина столешницы" }
                },
                {
                    ParametersType.TableTopHeight, 
                    new AdditionalParameters { Min = 50, Max = 80, Name = "Высота столешницы" }
                },
                {
                    ParametersType.TableLegsHeight, 
                    new AdditionalParameters { Min = 400, Max = 600, Name = "Высота ножек" }
                },

                {
                    ParametersType.TableLegsLength,
                    new AdditionalParameters { Min = 50, Max = 225, Name = "Длина основания ножек" }
                },
                {
                    ParametersType.TableLegsWidth,
                    new AdditionalParameters { Min = 50, Max = 225, Name = "Ширина основания ножек" }
                },
            };
        }

        /// <summary>
        /// Параметры столешницы.
        /// </summary>
        public TableTopParameters TableTop
        {
            get => _tableTop;
            set
            {
                CheckRangeOfValues(new Dictionary<ParametersType, double>
                {
                    { ParametersType.TableTopLength, value.Length },
                    { ParametersType.TableTopHeight, value.Height },
                    { ParametersType.TableTopWidth, value.Width },
                });

                _tableTop = value;
            }
        }

        /// <summary>
        /// Параметры ножек.
        /// </summary>
        public TableLegsParameters TabLegs
        {
            get => _tableLegs;
            set
            {
                
                    var lenght = _additionalParameters
                        .FirstOrDefault(x => x.Key == ParametersType.TableLegsLength)
                        .Value;
                    lenght.Max = _tableTop.Length / 4;

                    var width = _additionalParameters
                        .FirstOrDefault(x => x.Key == ParametersType.TableLegsWidth)
                        .Value;
                    width.Max = _tableTop.Width / 4;
               
                var container = new Dictionary<ParametersType, double>
                {
                    {ParametersType.TableLegsHeight, value.Height},
                    {ParametersType.TableLegsLength, value.Length},
                    {ParametersType.TableLegsWidth, value.Width},
 
                };

                CheckRangeOfValues(container);
                _tableLegs = value;
            }
        }

        /// <summary>
        /// Дополнительные параметры стола.
        /// </summary>
        public Dictionary<ParametersType, AdditionalParameters> AdditionalParameters { get => _additionalParameters; }

        /// <summary>
        /// Проверка на допустимый диапозон.
        /// </summary>
        /// <param name="container"></param>
        private void CheckRangeOfValues(Dictionary<ParametersType, double> container)
        {
            foreach (var keyValue in container)
            {
                var param = _additionalParameters
                    .FirstOrDefault(x => x.Key == keyValue.Key)
                    .Value;

                if ((keyValue.Value < param.Min) || (keyValue.Value > param.Max))
                {
                    throw new ArgumentException(
                        $"Значение '{param.Name}' должно быть в диапозоне от {param.Min} до {param.Max}.");
                }
            }
        }
    }
}
