using System.Collections.Generic;

namespace ClassLibrary
{
    class Building : IDbEntity
    {
        private string name;
        private int level;

        public int CellNb { get; set; }
        public List<Resource> TotalCost{ get; set; }

        public List<Resource> NextCost { get; set; }
    }
}