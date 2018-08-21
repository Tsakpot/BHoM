﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Base;
using BH.oM.Environment.Elements;

namespace BH.oM.Environment.Properties
{
    public class BuildingElementProperties : BHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public BuildingElementType BuildingElementType { get; set; } = BuildingElementType.Undefined;
        public List<ConstructionLayer> ConstructionLayers { get; set; } = new List<ConstructionLayer>();
        public double Thickness { get; set; } = 0.0;
        public double gValue { get; set; } = 0.0;
        public double gValueShading { get; set; } = 0.0;
        public double LtValue { get; set; } = 0.0;
        public double ThermalConductivity { get; set; } = 0.0;
        public double UValue { get; set; } = 0.0;

        /***************************************************/
    }
}