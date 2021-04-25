﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Kompas3DConnector;
using Kompas6API5;
using Kompas6Constants3D;
using ModelParameters;




namespace ModelBuilder
{
    public class TableBuilder
    {
        /// <summary>
        ///Метод построения журнального стола
        /// </summary>
        public void BuildTable(TableParameters table)
        {
            KompasConnector.Instance.InitializationKompas();

        }

        private void CreateRectangle(double height, double width,double xc,double yc)
        {

        }

        /// <summary>
        /// Метод для завершения компаса
        /// </summary>
        public void CloseKompas()
        {
            KompasConnector.Instance.UnloadKompas();
        }

        /// <summary>
        /// Метод для создания эскиза
        /// </summary>
        /// <param name="heightPlane">Высота плоскости</param>
        /// <returns>Эскиз</returns>
        private ksSketchDefinition CreateSketch(double heightPlane)
        {
            ksEntity currentPlane = (ksEntity)KompasConnector
                .Instance.KompasPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            ksEntity newPlane = (ksEntity)KompasConnector
                .Instance.KompasPart.NewEntity((short)Obj3dType.o3d_planeOffset);
            // Интерфейс настроек смещенной плоскости
            ksPlaneOffsetDefinition newPlaneDefinition =
                (ksPlaneOffsetDefinition)newPlane.GetDefinition();

            // начальная позиция плоскости: от предыдущей
            newPlaneDefinition.SetPlane(currentPlane);
            // направление смещения: прямое
            newPlaneDefinition.direction = true;
            // расстояние смещения
            newPlaneDefinition.offset = heightPlane;
            // создать плоскость
            newPlane.Create();
            // установить последнюю созданную плоскость текущей
            currentPlane = newPlane;

            ksEntity Sketch = (ksEntity)KompasConnector
                .Instance.KompasPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition SketchDef = Sketch.GetDefinition();
            SketchDef.SetPlane(currentPlane);
            Sketch.Create();
            return SketchDef;
        }

        /// <summary>
        /// Метод для вырезания выдавливанием 
        /// </summary>
        /// <param name="depth">Глубина выреза</param>
        /// <param name="sketchDef">Эскиз</param>
        ///  <param name="forward">Направление выдавливания</param>
        private void CutExtrusion(double depth, bool forward, ksSketchDefinition sketchDef)
        {
            var iBaseExtrusionEntity1 = (ksEntity)KompasConnector
                .Instance.KompasPart.NewEntity((short)ksObj3dTypeEnum.o3d_cutExtrusion);
            //интерфейс свойств базовой операции выдавливания
            var iBaseExtrusionDef1 = (ksCutExtrusionDefinition)iBaseExtrusionEntity1.GetDefinition();
            //толщина выдавливания
            iBaseExtrusionDef1.SetSideParam(forward, 0, depth);
            // эскиз операции выдавливания
            iBaseExtrusionDef1.SetSketch(sketchDef);
            // создать операцию
            iBaseExtrusionEntity1.Create();
        }

        /// <summary>
        /// Метод для выдавливания
        /// </summary>
        /// <param name="height">Высота выдавливания</param>
        /// <param name="sketchDef">Эскиз</param>
        /// <param name="forward">Направление выдавливания</param>
        /// <param name="thin">тонкая стенка</param>
        private void BossExtrusion(double height, ksSketchDefinition sketchDef, bool forward, bool thin)
        {
            var iBaseExtrusionEntity = (ksEntity)KompasConnector.Instance.
                KompasPart.NewEntity((short)ksObj3dTypeEnum.o3d_bossExtrusion);
            // интерфейс свойств базовой операции выдавливания
            var iBaseExtrusionDef = (ksBossExtrusionDefinition)iBaseExtrusionEntity.GetDefinition();
            //толщина выдавливания
            if (thin)
            {
                iBaseExtrusionDef.SetThinParam(true, 0, 1, 1);
            }
            iBaseExtrusionDef.SetSideParam(forward, 0, height);
            // эскиз операции выдавливания
            iBaseExtrusionDef.SetSketch(sketchDef);
            // создать операцию
            iBaseExtrusionEntity.Create();
        }
    }
}
