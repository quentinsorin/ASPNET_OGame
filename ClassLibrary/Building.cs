using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class Building : IDbEntity
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        private string Name { get; set; }

        [Range(0, Double.PositiveInfinity)]
        private int Level { get; set; }

        //Représente le nombre de case nécessaire au bâtiment pour exister
        public int CellNb()
        {
            int res = 0;
            if(res < 0)
            {
                res = 0;
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