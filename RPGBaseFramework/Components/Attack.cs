using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Components
{
    internal class Attack
    {
        protected int optionNumber;
        protected string description;
        protected int strength;
        protected int hitChanceWeight;
        protected Boolean isDefense;

        public Attack(int optionNumber, string description, int strength, int hitChanceWeight, Boolean? isDefense = false)
        {
            this.optionNumber = optionNumber;
            this.description = description;
            this.strength = strength;   
            this.hitChanceWeight = hitChanceWeight;
            this.isDefense = (Boolean)isDefense;
        }

        public string attackFormatted()
        {
            decimal hitChance = (1 / (decimal)this.hitChanceWeight) * 100;

            return $"{this.optionNumber} -> {this.description}. Força: {this.strength} | Chance de acertar: {hitChance.ToString("0.##")}%"; 
        }

        public int getOptionNumber()
        {
            return optionNumber;
        }
        public string getDescription()
        {
            return description;
        }
        public int getStrength()
        {
            return strength;
        }
        public int getHitChanceWeight()
        {
            return hitChanceWeight;
        }

        public Boolean isADefense()
        {
            return isDefense;
        }

    }
}
