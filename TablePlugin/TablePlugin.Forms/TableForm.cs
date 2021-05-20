using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TablePlugin.BLL;
using TablePlugin.BLL.Enums;
using TablePlugin.BLL.Models;

namespace TablePlugin.Forms
{
    public partial class TableForm : Form
    {
        /// <summary>
        /// Объект для построения 3D Модели.
        /// </summary>
        private TableBuilder _builder;

        /// <summary>
        /// Initializes a new instance of the <see cref="TableForm"/> class.
        /// </summary
        public TableForm()
        {
            InitializeComponent();
            LegsTypeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Обработчик кнопки "Построить 3D модель".
        /// </summary>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            var parameters = new TableParameters();
            try
            {
                parameters.TableTop = new TableTopParameters
                {
                    Length = (double) tableTopLength.Value,
                    Width = (double) tableTopWidth.Value,
                    Height = (double) tableTopHeight.Value
                };

                parameters.TabLegs = new TableLegsParameters
                {
                    Height = (double) tableLegsHeight.Value,
                    Number = (int) tableLegsNumber.Value,
                    Type = LegsType.SquareLegs,
                    Value = (double) SizeValue.Value
                };

                _builder = _builder ?? new TableBuilder();
                _builder.Build(parameters);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Обработчик комбобокса "Тип ножек"
        /// </summary>
        private void LegsTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameOfSize.Text = "Длина стороны основания";
        }

        /// <summary>
        /// Обработчик кнопки "Минимумы".
        /// </summary>
        private void SetMinButton_Click(object sender, EventArgs e)
        {
            SetMinMaxParameters(x => x.Value.Min);
        }

        /// <summary>
        /// Обработчик кнопки "Максимумы".
        /// </summary>
        private void SetMaxButton_Click(object sender, EventArgs e)
        {
            SetMinMaxParameters(x => x.Value.Max);
        }

        /// <summary>
        /// Обработчик кнопки "По умолчанию".
        /// </summary>
        private void DefaultButton_Click(object sender, EventArgs e)
        {
            tableTopLength.Value = 700m;
            tableTopWidth.Value = 700m;
            tableTopHeight.Value = 60m;

            tableLegsHeight.Value = 500m;
            tableLegsNumber.Value = 4m;
            SizeValue.Value = 60m;
        }

        /// <summary>
        /// Метод для установки значений минимума и максимума для полей формы.
        /// </summary>
        /// <param name="expression">Лямбда-выражение.</param>
        private void SetMinMaxParameters(Func<KeyValuePair<ParametersType, AdditionalParameters>, double> expression)
        {
            var parameters = new TableParameters();
            var limits = parameters.AdditionalParameters;

            tableTopLength.Value = (decimal)limits
                .Where(x => x.Key == ParametersType.TableTopLength)
                .Select(expression)
                .FirstOrDefault();

            tableTopWidth.Value = (decimal) limits
                .Where(x => x.Key == ParametersType.TableTopWidth)
                .Select(expression)
                .FirstOrDefault();
            
            tableTopHeight.Value = (decimal) limits
                .Where(x => x.Key == ParametersType.TableTopHeight)
                .Select(expression)
                .FirstOrDefault();

            tableLegsHeight.Value = (decimal) limits
                .Where(x => x.Key == ParametersType.TableLegsHeight)
                .Select(expression)
                .FirstOrDefault();
            
            tableLegsNumber.Value = (decimal) limits
                .Where(x => x.Key == ParametersType.TableLegsNumber)
                .Select(expression)
                .FirstOrDefault();
            
            SizeValue.Value = LegsTypeComboBox.SelectedIndex == 0
                ? (decimal) limits
                    .Where(x => x.Key == ParametersType.TableLegsDiameter)
                    .Select(expression)
                    .FirstOrDefault()
                : (decimal)limits
                    .Where(x => x.Key == ParametersType.TableLegsSideLength)
                    .Select(expression)
                    .FirstOrDefault();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void topGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
