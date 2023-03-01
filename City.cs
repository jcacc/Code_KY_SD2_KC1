using System.Collections.Generic;

namespace Software2KnowledgeCheck1
{
    public class City
    {
        public int ZipCode { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }
        public List<Building> Buildings { get; } = new List<Building>();
    }

    public class BuildingConstructor
    {
        private readonly MaterialsRepo _materialRepo;
        private readonly ZoningAndPermitRepo _permitRepo;

        public BuildingConstructor(MaterialsRepo materialRepo, ZoningAndPermitRepo permitRepo)
        {
            _materialRepo = materialRepo;
            _permitRepo = permitRepo;
        }

        public bool ConstructBuilding<T>(List<string> materials) where T : Building
        {
            var permit = _permitRepo.GetPermit();
            var zoning = _permitRepo.ZoningApproves();

            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
