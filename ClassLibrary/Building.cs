using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class Building : IDbEntity
    {
        private long? id;
        private String name;
        private int? level;

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [Range(0, int.MaxValue)]
        public virtual int? Level
        {
            get { return level; }
            set { level = value; }
        }

        //Représente le nombre de case nécessaire au bâtiment pour exister
        public int CellNb()
        {
            int res = 0;
            if(level > 0 & level != null)
            {
                res = (int) level;
            }
            return res;
        }

        //retourne la liste des ressources totale ayant permit la construction du bâtiment.
        //Attention un bâtiment peut ne pas avoir coûté d’énergie et ou d’oxygène et ou d’acier et ou d’uranium.
        public List<Resource> TotalCost()
        {
            return new List<Resource>();
        }

        //retourne la liste des ressources permettant la construction du prochain niveau du bâtiment.
        //Attention un bâtiment peut ne pas avoir de coût en énergie et ou oxygène et ou acier et ou uranium.
        public List<Resource> NextCost()
        {
            return new List<Resource>();
        }
    }
}