using System;
using System.Windows.Forms;
using TablePlugin.BLL;
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
        /// </summary>
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
    }
}
