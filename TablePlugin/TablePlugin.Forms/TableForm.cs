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
                    Type = LegsTypeComboBox.SelectedIndex == 0 ? LegsType.RoundLegs : LegsType.SquareLegs,
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
            switch (LegsTypeComboBox.SelectedIndex)
            {
                case 0:
                    NameOfSize.Text = "Диаметр основания";
                    break;
                case 1:
                    NameOfSize.Text = "Длина стороны основания";
                    break;
            }
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
            tableTopLength.Value = 1500m;
            tableTopWidth.Value = 700m;
            tableTopHeight.Value = 35m;

            tableLegsHeight.Value = 650m;
            tableLegsNumber.Value = 4m;
            SizeValue.Value = 50m;
        }

        /// <summary>
        /// Метод для установки значений минимума и максимума для полей формы.
        /// </summary>
        /// <param name="predicate">Предикат.</param>
        private void SetMinMaxParameters(Func<KeyValuePair<ParametersType, AdditionalParameters>, double> predicate)
        {
            var parameters = new TableParameters();
            var limits = parameters.AdditionalParameters;

            tableTopLength.Value = (decimal)limits.Where(x => x.Key == ParametersType.TableTopLength).Select(predicate).FirstOrDefault();
            tableTopWidth.Value = (decimal)limits.Where(x => x.Key == ParametersType.TableTopWidth).Select(predicate).FirstOrDefault();
            tableTopHeight.Value = (decimal)limits.Where(x => x.Key == ParametersType.TableTopHeight).Select(predicate).FirstOrDefault();

            tableLegsHeight.Value = (decimal)limits.Where(x => x.Key == ParametersType.TableLegsHeight).Select(predicate).FirstOrDefault();
            tableLegsNumber.Value = (decimal)limits.Where(x => x.Key == ParametersType.TableLegsNumber).Select(predicate).FirstOrDefault();
            SizeValue.Value = LegsTypeComboBox.SelectedIndex == 0
                ? (decimal)limits.Where(x => x.Key == ParametersType.TableLegsDiameter).Select(predicate).FirstOrDefault()
                : (decimal)limits.Where(x => x.Key == ParametersType.TableLegsSideLength).Select(predicate).FirstOrDefault();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
