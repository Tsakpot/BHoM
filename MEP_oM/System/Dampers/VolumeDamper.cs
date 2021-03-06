﻿/*
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

using System.ComponentModel;
using BH.oM.Base;
using BH.oM.MEP.System.SectionProperties;
using BH.oM.Dimensional;
using BH.oM.Geometry;

namespace BH.oM.MEP.System.Dampers
{
    [Description("A type of damper used to control the flow of air in a mechanical system.")]
    public class VolumeDamper : BHoMObject, IElement0D, IElementM
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("The point in space for the location of the VolumeDamper.")]
        public virtual Point Location { get; set; } = new Point();

        [Description("The DuctSectionProperties for the duct connected to the inlet face of the VolumeDamper.")]
        public virtual DuctSectionProperty InletDuctProperties { get; set; } = null;

        [Description("The DuctSectionProperties for the duct connected to the outlet face of the VolumeDamper.")]
        public virtual DuctSectionProperty OutletDuctProperties { get; set; } = null;

        [Description("The difference in total pressure between two points of a fluid carrying network.")]
        public virtual double PressureDrop { get; set; } = 0;

        /***************************************************/
    }
}
