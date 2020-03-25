using System.Collections.Generic;

namespace ClassLibrary
{
    class Building : IDbEntity
    {
        private string Name { get; set; }
        private int Level { get; set; }

        public int CellNb { get; set; }
        public List<Resource> TotalCost()
        {
            return new List<Resource>();
        }

        public List<Resource> NextCost()
        {
            return new List<Resource>();
        }
    }
}