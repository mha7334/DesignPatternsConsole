using System.Collections.Generic;

namespace DesignPatternsConsole
{
    public class VscTurbineAmbientTurbulenceLargePark
    {
        public bool IsLargeParkContributionAddedInSector0 { get; set; }
        public bool IsLargeParkContributionAddedInSector1 { get; set; }
        public bool IsLargeParkContributionAddedInSector2 { get; set; }
        public bool IsLargeParkContributionAddedInSector3 { get; set; }
        public string VscProjectId { get; set; }
        public string VscTurbineId { get; set; }
    }

    public class VscTurbineAmbientTurbulenceLargeParkList
    {
        public List<VscTurbineAmbientTurbulenceLargePark> VscTurbineAmbientTurbulenceLargeParks { get; set; }
    }
}