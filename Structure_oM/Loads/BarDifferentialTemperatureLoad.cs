/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using BH.oM.Structure.Elements;
using System.ComponentModel;
using BH.oM.Quantities.Attributes;
using BH.oM.Base;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using BH.oM.Geometry;

namespace BH.oM.Structure.Loads
{
    [Description("Differential temperature load for Bars.")]
    public class BarDifferentialTemperatureLoad : BHoMObject, IElementLoad<Bar>
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Temperature]
        [Description("Differential temperature profile of the Bar expressed as a Dictionary of the parametric position from the top of the profile and the temperature at each location.")]
        public virtual Dictionary<double,double> TemperatureProfile { get; set; }

        [Description("The direction of the temperature variation, relative to the local axis of the profile. For most analysis packages this is limit to local y or local z.")]
        public virtual Vector LocalDirection { get; set; }

        [Description("The Loadcase in which the load is applied.")]
        public virtual Loadcase Loadcase { get; set; }

        [Description("The group of Bars that the load should be applied to. For most analysis packages the objects added here need to be pulled from the analysis package before being assigned to the load.")]
        public virtual BHoMGroup<Bar> Objects { get; set; } = new BHoMGroup<Bar>();

        [Description("Defines whether the load is applied in local or global coordinates.")]
        public virtual LoadAxis Axis { get; set; } = LoadAxis.Local;

        [Description("If true the load is projected to the element. This means that the load will be reduced when its direction is at an angle to the element.")]
        public virtual bool Projected { get; set; } = false;

        /***************************************************/
    }
}

