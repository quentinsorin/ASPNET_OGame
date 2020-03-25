using System.Collections.Generic;

namespace ClassLibrary
{
    public class Building : IDbEntity
    {
        private string Name { get; set; }
        private int Level { get; set; }

        public int CellNb()
        {
            return 0;
        }
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