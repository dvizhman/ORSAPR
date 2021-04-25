using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelParameters
{
    public class TableParameters
    {
        /// <summary>
        /// Лист параметров
        /// </summary>
        private List<Parameter> parameters = new List<Parameter>();

        /// <summary>
        /// Поле, содержащее длину столешницы 
        /// </summary>
        public Parameter LengthTop { get; set; }

        /// <summary>
        /// Поле, содержащее ширину столешницы
        /// </summary>
        public Parameter WidthTop { get; set; }

        /// <summary>
        /// Поле, содержащее высоту столешницы
        /// </summary>
        public Parameter HeigthTop { get; set; }

        /// <summary>
        /// Поле, содержащее длину ножек стола
        /// </summary>
        public Parameter LengthLegs { get; set; }

        /// <summary>
        /// Поле, содержащее ширину ножек стола
        /// </summary>
        public Parameter WidthLegs { get; set; }

        /// <summary>
        /// Поле, содержащее высоту ножек стола
        /// </summary>
        public Parameter HeightLegs { get; set; }


        public void MaxValue()
        {
            LengthTop.Value = LengthTop.MaximumValue;
            WidthTop.Value = WidthTop.MaximumValue;
            HeigthTop.Value = HeigthTop.MaximumValue;
            LengthLegs.Value = LengthLegs.MaximumValue;
            WidthLegs.Value = WidthLegs.MaximumValue;
            HeightLegs.Value = HeightLegs.MaximumValue;
        }
        public void MinValue()
        {
            LengthTop.Value = LengthTop.MimimumValue;
            WidthTop.Value = WidthTop.MimimumValue;
            HeigthTop.Value = HeigthTop.MimimumValue;
            LengthLegs.Value = LengthLegs.MimimumValue;
            WidthLegs.Value = WidthLegs.MimimumValue;
            HeightLegs.Value = HeightLegs.MimimumValue;
        }
        /// <summary>
        /// Свойство, присваивающее значение по умолчанию для зависимых параметров
        /// </summary>
        public void DefaultValue()
        {
            LengthTop.Value = LengthTop.DefaultValue;
            WidthTop.Value = WidthTop.DefaultValue;
            HeigthTop.Value = HeigthTop.DefaultValue;
            LengthLegs.Value = LengthLegs.DefaultValue;
            WidthLegs.Value = WidthLegs.DefaultValue;
            HeightLegs.Value = HeightLegs.DefaultValue;
        }
        public TableParameters()
        {
            this.LengthTop  = new Parameter("Длина столешницы", 550, 900, 600);
            this.WidthTop = new Parameter("Ширина столешницы", 550, 900, 600);
            this.HeigthTop = new Parameter("Толщина столешницы", 50, 80, 60);
            this.LengthLegs = new Parameter("Длина ножек", 50, (this.LengthTop.DefaultValue/2), 50);
            this.WidthLegs = new Parameter("Ширина ножек", 50, (this.WidthTop.DefaultValue/2), 50);
            this.HeightLegs = new Parameter("Высота ножек", 400, 600, 500);



            parameters.Add(LengthTop);
            parameters.Add(WidthTop);
            parameters.Add(HeigthTop);
            parameters.Add(LengthLegs);
            parameters.Add(WidthLegs);
            parameters.Add(HeightLegs);
            
        }
    }
}
