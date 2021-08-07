

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace FixDockingNodes
{
    public class ModuleDockingNodeFixed : ModuleDockingNode
    {
        protected override void ApplyCoordsUpdate()
        {
            if (HighLogic.LoadedSceneIsFlight && canRotate && !nodeIsLocked && otherNode != null && vessel != null && part.vessel != null)
            {
                RecurseCoordUpdate(part.vessel.rootPart, part.vessel.rootPart);
            }
        }
    }
}