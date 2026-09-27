/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2026, the respective contributors. All rights reserved.
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

namespace BH.Engine.Adapters.File
{
    public static partial class Compute
    {
        // TEMPORARY. Two deliberately-failing methods for a one-off CI experiment (register
        // item 74, Gap A). A BHoM T[] parameter fails to deserialise because Create.Type has
        // no array branch. The head branch removes ProbeB, so the branch's failures are a
        // strict subset of the baseline's and the comparator would report an Improvement.
        // Delete with the branch.

        [Description("TEMPORARY test probe. Do not use. See test/guard-run-b-base.")]
        public static int GuardRunBProbeA(BH.oM.Adapters.File.FSFile[] files)
        {
            return files == null ? 0 : files.Length;
        }
    }
}
