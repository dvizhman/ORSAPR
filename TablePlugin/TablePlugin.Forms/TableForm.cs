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
                    Length = (double) tableLegsLength.Value,
                    Width = (double) tableLegsWidth.Value,
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
        /// Обработчик кнопки "По умолчанию".
        /// </summary>
        private void DefaultButton_Click(object sender, EventArgs e)
        {
            tableTopLength.Value = 700m;
            tableTopWidth.Value = 700m;
            tableTopHeight.Value = 60m;

            tableLegsHeight.Value = 500m;
            tableLegsLength.Value = 60m;
            tableLegsWidth.Value = 60m;
        }
    }
}
