using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole
{
    public class VscTurbineLoad
    {
        public double RelativeLoad { get; set; }
        public double TurbineLoad { get; set; }
        public double DesignLoad { get; set; }
        public double WohlerCoefficient { get; set; }
        public string LoadComponentName { get; set; }
        public int LoadComponentEnum { get; set; }
        public string VscTurbineId { get; set; }
        public string VscProjectId { get; set; }
    }

    public class VscTurbineLoadList
    {
        public List<VscTurbineLoad> VscTurbineLoads { get; set; }
    }
}
