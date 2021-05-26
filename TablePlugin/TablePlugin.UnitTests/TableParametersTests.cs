using System;
using System.Linq;
using NUnit.Framework;
using TablePlugin.BLL.Enums;
using TablePlugin.BLL.Models;

namespace TablePlugin.UnitTests
{
    /// <summary>
    /// Тесты для проверки TableParameters.
    /// </summary>
    [TestFixture]
    public class TableParametersTests
    {
        /// <summary>
        /// Тест на присваиваение параметров в объект класса TableParameters. Позитивный тест.
        /// </summary>
        [Test, Description("Тест на присваиваение параметров в объект класса TableParameters. Позитивный тест.")]
        public void TableParameters_CorrectValue_CorrectResult()
        {
            // SetUp
            var parameters = new TableParameters();

            // Act
            SetCorrectParameters(parameters);
        }

        /// <summary>
        /// Тест на получение параметров в объект класса TableParameters. Позитивный тест.
        /// </summary>
        [Test, Description("Тест на получение параметров класса TableParameters. Позитивный тест.")]
        public void TableParameters_GetParameters_CorrectResult()
        {
            // SetUp
            var parameters = new TableParameters();

            // Act
            SetCorrectParameters(parameters);
            var top = parameters.TableTop;
            var legs = parameters.TabLegs;

            // Assert
            Assert.NotNull(top);
            Assert.NotNull(legs);
        }

        /// <summary>
        /// Тест на получение списка с дополнительными параметрами. Позитивный тест.
        /// </summary>
        [Test, Description("Тест на получение списка с дополнительными параметрами. Позитивный тест.")]
        public void ListAdditionalParameters_CorrectResult()
        {
            // SetUp
            var parameters = new TableParameters();

            // Act
            var additionalParam = parameters.AdditionalParameters;

            // Assert
            Assert.NotNull(additionalParam);
            Assert.AreEqual(10, additionalParam.Count);
            foreach(var p in additionalParam)
            {
                Assert.NotNull(p.Value);
            }
        }

        /// <param name="value">Присваиваемое значение.</param>
        /// <param name="parameter">В какой параметр будет присваиваться значение.</param>
        [TestCase(700.05d, "Length", 
            TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(700.05d, "Width", 
            TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(60.05d, "Height", 
            TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(-1, "Length", 
            TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(-1, "Width", TestName = 
            "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(-1, "Height", TestName = 
            "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        public void TableTopParameters_WrongArgument_ThrowsExceptionResult(double value, string parameter)
        {
            // SetUp
            var parameters = new TableTopParameters();

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                parameters.Length = parameter == "Length" ? value : 700;
                parameters.Width = parameter == "Width" ? value : 700;
                parameters.Height = parameter == "Height" ? value : 60;
            }, $"Ошибка присвоения неправильного значения в TableTopParameters.{parameter}");
        }

        /// <summary>
        /// Тест на присваивание неправильных значений в поля структуры TableLegsParameters. Негативный тест. 
        /// </summary>
        /// <param name="value">Присваиваемое значение.</param>
        /// <param name="parameter">В какой параметр будет присваиваться значение.</param>
        [TestCase(700.05d, "Height", TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(60.05d, "Length", TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(60.05d, "Width", TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(-1, "Height", TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(-1, "Number", TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        [TestCase(-1, "Value", TestName = "Тестирование присваивания {0} в TableTopParameters.{1}. Негативный тест.")]
        public void TableLegsParameters_WrongArgument_ThrowsExceptionResult(double value, string parameter)
        {
            // SetUp
            var parameters = new TableLegsParameters();

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                parameters.Length = parameter == "Length" ? value : 60;
                parameters.Width = parameter == "Width" ? value : 60;
                parameters.Height = parameter == "Height" ? value : 500;
            }, $"Ошибка присвоения неправильного значения в TableLegsParameters.{parameter}");
        }

        /// <summary>
        /// Тест на присваивание неправильных значений в поля класса TableParameters. Негативный тест. 
        /// </summary>
        /// <param name="value">Присваиваемое значение.</param>
        /// <param name="parameter">В какой параметр будет присваиваться значение.</param>
        [TestCase(900, ParametersType.TableTopLength, TestName = "Тестирование присваивания {0} в TableParameters.TableTop.{1}. Негативный тест.")]
        [TestCase(500, ParametersType.TableTopWidth, TestName = "Тестирование присваивания {0} в TableParameters.TableTop.{1}. Негативный тест.")]
        [TestCase(20, ParametersType.TableTopHeight, TestName = "Тестирование присваивания {0} в TableParameters.TableTop.{1}. Негативный тест.")]
        [TestCase(500, ParametersType.TableLegsHeight, TestName = "Тестирование присваивания {0} в TableParameters.TableLegs.{1}. Негативный тест.")]
        public void TableParameters_WrongArgument_ThrowsExceptionResult(double value,  ParametersType parameter)
        {
            // SetUp
            var parameters = new TableParameters();
            var addInfo = parameters.AdditionalParameters.FirstOrDefault(x => x.Key == parameter).Value;
            
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {

                // Act
                parameters.TableTop = new TableTopParameters
                {
                    Length =  parameter == ParametersType.TableTopLength ? value : 700,
                    Width = parameter == ParametersType.TableTopWidth ? value : 700,
                    Height = parameter == ParametersType.TableTopHeight ? value : 60,
                };

                parameters.TabLegs = new TableLegsParameters
                {
                    Length = parameter == ParametersType.TableLegsLength ? value : 60,
                    Width = parameter == ParametersType.TableLegsWidth ? value : 60,
                    Height = parameter == ParametersType.TableLegsHeight ? value : 500,
                };
            }, $"Значение '{addInfo.Name}' должно быть в диапозоне от {addInfo.Min} до {addInfo.Max}." );
        }
       
        /// <summary>
        /// Тест на присвоение неправильного количества ножек. Негативный тест.
        /// </summary>
        [Test, Description("Тест на присваивание неправильного количества ножек. Негативный тест.")]
        public void TableParameters_WrongNumberOfLegs_ThrowsExceptionResult()
        {
            // SetUp
            var parameters = new TableParameters();
            
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                parameters.TableTop = new TableTopParameters
                {
                    Length = 700,
                    Width = 700,
                    Height = 60,
                };

                parameters.TabLegs = new TableLegsParameters
                {
                    Height = 500,
                    Length = 60,
                    Width = 60,
                };
                
            }, "Значение 'Количество ножек' должно быть равно 4" );
        }

        /// <summary>
        /// Метод для заполнение параметров объект класса TableParameters.
        /// </summary>
        /// <param name="parameters">Объект класса TableParameters</param>
        private static void SetCorrectParameters(TableParameters parameters)
        {
            parameters.TableTop = new TableTopParameters
            {
                Length = 700,
                Width = 700,
                Height = 60,
            };

            parameters.TabLegs = new TableLegsParameters
            {
                Length = 60,
                Width = 60,
                Height = 500,
            };
        }
    }
}
