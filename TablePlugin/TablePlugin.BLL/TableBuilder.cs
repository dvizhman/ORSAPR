using Kompas6API5;
using Kompas6Constants3D;
using Kompas6Constants;
using TablePlugin.BLL.Models;

namespace TablePlugin.BLL
{
    /// <summary>
    /// Класс для построение 3D модели.
    /// </summary>
    public class TableBuilder
    {
        /// <summary>
        /// Коннектор для работы с Компас3D.
        /// </summary>
        private KompasConnector _connector;

        /// <summary>
        /// Параметры стола.
        /// </summary>
        private TableParameters _parameters;

        /// <summary>
        /// Метод для построение 3D модели.
        /// </summary>
        /// <param name="parameters">Параметры стола.</param>
        public void Build(TableParameters parameters)
        {
            _parameters = parameters;
            _connector = new KompasConnector();
            _connector.GetNewPart();

            CreateTopTable();
            CreateTableLegs();
        }

        /// <summary>
        /// Метод для построения столешницы.
        /// </summary>
        private void CreateTopTable()
        {
            // Создаем эскиз.
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOY);
            var doc2D = (ksDocument2D)sketchDef.BeginEdit();

            // Создание прямоугольника.
            var rectangleParam = (ksRectangleParam)_connector.KsObject.GetParamStruct
                ((short)StructType2DEnum.ko_RectangleParam);
            // Присваиваем параметры прямоугольнику.
            rectangleParam.x = 0;
            rectangleParam.y = 0;
            rectangleParam.ang = 0;
            rectangleParam.height = _parameters.TableTop.Width;
            rectangleParam.width = _parameters.TableTop.Length;
            rectangleParam.style = 1;
            doc2D.ksRectangle(rectangleParam);

            // Конец редактирования эскиза.
            sketchDef.EndEdit();
            
            // Выдавить.
            PressOutSketch(sketchDef, _parameters.TableTop.Height);
        }

        /// <summary>
        /// Метод для построения ножек стола.
        /// </summary>
        private void CreateTableLegs()
        {
            // Создаем эскиз.
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOY);
            var doc2D = (ksDocument2D)sketchDef.BeginEdit();

            // Координаты цетров ножек.
            var x = new double[4];
            var y = new double[4];

                       x[0] = 0;
                       y[0] = 0;

                       x[1] = 0;
                       y[1] = _parameters.TableTop.Width - _parameters.TabLegs.Width;

                       x[2] = _parameters.TableTop.Length - _parameters.TabLegs.Length;
                       y[2] = _parameters.TableTop.Width - _parameters.TabLegs.Width;

                       x[3] = _parameters.TableTop.Length - _parameters.TabLegs.Length;
                       y[3] = 0;



            // Создание квадратов основания ножек.
            for (var i = 0; i < x.Length; i++)
            {
                var rectangleParam = (ksRectangleParam)_connector.KsObject.GetParamStruct
                ((short)StructType2DEnum.ko_RectangleParam);
                rectangleParam.x = x[i];
                rectangleParam.y = y[i];
                rectangleParam.ang = 0;
                rectangleParam.height = _parameters.TabLegs.Width;
                rectangleParam.width = _parameters.TabLegs.Length;
                rectangleParam.style = 1;
                doc2D.ksRectangle(rectangleParam);
            }

            // Конец редактирования эскиза.
            sketchDef.EndEdit();

            // Выдавить.
            PressOutSketch(sketchDef, _parameters.TabLegs.Height, side: false);
        }


        /// <summary>
        /// Действие выдавливания по эскизу.
        /// </summary>
        /// <param name="sketchDef">Эскиз.</param>f
        /// <param name="height">Высота выдавливание.</param>
        /// <param name="type">Тип выдавливания.</param>
        /// <param name="side">Направление выдаливания.</param>
        private void PressOutSketch(ksSketchDefinition sketchDef, double height, 
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_bossExtrusion, bool side = true)
        {
            // Выдавливание по типу
            var extrusionEntity = (ksEntity)_connector.Part.NewEntity((short)type);

            // интерфейс свойств базовой операции выдавливания.
            if (type == ksObj3dTypeEnum.o3d_bossExtrusion)
            {
                var extrusionDef = (ksBossExtrusionDefinition)extrusionEntity.GetDefinition();
                // Параметры выдавливания.
                extrusionDef.SetSideParam(side, (short)End_Type.etBlind, height);
                extrusionDef.directionType = side ? 
                    (short)Direction_Type.dtNormal : (short)Direction_Type.dtReverse;

                // эскиз операции выдавливания.
                extrusionDef.SetSketch(sketchDef);
            }
            else if (type == ksObj3dTypeEnum.o3d_cutExtrusion)
            { 
                var extrusionDef = (ksCutExtrusionDefinition)extrusionEntity.GetDefinition();
                // параметры выдаливания.
                extrusionDef.SetSideParam(side, (short)End_Type.etBlind, height);
                // Тип направления.
                extrusionDef.directionType = side ? 
                    (short)Direction_Type.dtNormal : (short)Direction_Type.dtReverse;

                // эскиз операции вырезания по выдавливанию.
                extrusionDef.SetSketch(sketchDef);
            }

            // создать операцию.
            extrusionEntity.Create();
        }

        /// <summary>
        /// Создание эскиза.
        /// </summary>
        /// <param name="planeType">В какой плоскости будет эскиз.</param>
        /// <returns>ksSketchDefinition.</returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType)
        {
            // Выбор плоскости.
            var plane = (ksEntity)_connector.Part.GetDefaultEntity((short)planeType);
            // Создание эскиза.
            var sketch = (ksEntity)_connector.Part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDef = sketch.GetDefinition();
            // Устаналвливаем эскизу рабочую плоскость.
            sketchDef.SetPlane(plane);
            sketch.Create();

            return sketchDef;
        }
    }
}
