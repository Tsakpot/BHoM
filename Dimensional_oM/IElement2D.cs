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

using BH.oM.Base;
using System.ComponentModel;

namespace BH.oM.Dimensional
{
    [Description("Enables geometrical operations to be performed on an edge curve based two-dimensional spatial element, whilst preserving all other object properties as unchanged. /n" +
                 "The interface expects the outline to be constructed of IElement1D elements and allows for internal IElement2D elements." +
                 "Objects implementing this interface will be required to implement some base methods for getting and setting data in a way that maintains the object's other properties." +
                  "Documentation detailing required extension methods can be found here: https://github.com/BHoM/documentation/wiki/IElement-required-extension-methods")]
    public interface IElement2D : IElement
    {
    }
}
