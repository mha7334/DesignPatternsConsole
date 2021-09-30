using System.Collections.Generic;

namespace DesignPatternsConsole
{
    public class VscTurbineAmbientTurbulence
    {
        public double DirectionalTurbulenceAverage { get; set; }
        public double DirectionalTurbulenceStdDev { get; set; }
        public int DirectionNumber { get; set; }
        public double WindSpeed { get; set; }
        public string VscTurbineId { get; set; }
        public string VscProjectId { get; set; }
    }

    public class VscTurbineAmbientTurbulenceList
    {
        public List<VscTurbineAmbientTurbulence> VscTurbineAmbientTurbulences { get; set; }
    }
}