using System.Collections.Generic;

namespace DesignPatternsConsole
{
    public class VscTurbineDistributionOfAmbientI15
    {
        public double I15Average { get; set; }
        public double I15StdDev { get; set; }
        public int DirectionNumber { get; set; }
        public string VscTurbineId { get; set; }
        public string VscProjectId { get; set; }
    }

    public class VscTurbineDistributionOfAmbientI15List
    {
        public List<VscTurbineDistributionOfAmbientI15> Data { get; set; }
    }

}