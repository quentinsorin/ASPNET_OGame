using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public abstract class Building : IDbEntity
    {
        private long? id;
        private String name;
        private int? level;

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
        [NotMapped]
        [Range(0, int.MaxValue)]
        public virtual int? CellNb
        {
            get { return level; }
        }

        //retourne la liste des ressources totale ayant permit la construction du bâtiment.
        //Attention un bâtiment peut ne pas avoir coûté d’énergie et ou d’oxygène et ou d’acier et ou d’uranium.
        [NotMapped]
        public virtual List<Resource> TotalCost
        {
            get { return new List<Resource>(); }
        }

        //retourne la liste des ressources permettant la construction du prochain niveau du bâtiment.
        //Attention un bâtiment peut ne pas avoir de coût en énergie et ou oxygène et ou acier et ou uranium.
        [NotMapped]
        public virtual List<Resource> NextCost
        {
            get { return new List<Resource>(); }
        }

        public virtual long? Id { get => this.id; set => this.id = value; }
    }
}