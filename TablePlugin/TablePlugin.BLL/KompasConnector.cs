﻿using System;
using System.Runtime.InteropServices;
using System.Threading;
using Kompas6API5;
using Kompas6Constants3D;

namespace TablePlugin.BLL
{
    /// <summary>
    /// Класс для подключения к КОМПАС3D
    /// </summary>
    public class KompasConnector
    {
        /// <summary>
        /// Интерфейс API Компаc3D.
        /// </summary>
        public KompasObject KsObject { get; }

        /// <summary>
        /// Интерфейс компонента Компас3D.
        /// </summary>
        public ksPart Part { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KompasConnector"/> class.
        /// </summary>
        public KompasConnector()
        {
            var progId = "KOMPAS.Application.5";
            try
            {
                KsObject = (KompasObject)Marshal.GetActiveObject(progId);
            }
            catch (COMException)
            {
                KsObject = (KompasObject)Activator.
                    CreateInstance(Type.GetTypeFromProgID(progId));
                Thread.Sleep(50);
            }

            KsObject.Visible = true;
            KsObject.ActivateControllerAPI();
        }

        /// <summary>
        /// Метод для создания нового компонента в Компас3D.
        /// </summary>
        public void GetNewPart()
        {
            var ksDoc = KsObject.Document3D();
            ksDoc.Create(false, true);
            Part = ksDoc.GetPart((short)Part_Type.pTop_Part);
        }
    }
}
