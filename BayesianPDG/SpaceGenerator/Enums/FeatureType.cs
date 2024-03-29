﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesianPDG.SpaceGenerator
{
    /// <summary>
    /// The names of our parameters/features/RVs
    /// Each one is a unique node in the DAG 
    /// </summary>
    public enum FeatureType
    {
        NumRooms,
        CriticalPathLength,
        Depth,
        CriticalPathDistance,
        NumNeighbours
    }
}
