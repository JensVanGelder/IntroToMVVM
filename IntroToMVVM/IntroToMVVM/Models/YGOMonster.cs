using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToMVVM.Models
{
    class YGOMonster
    {
        public int ID { get; set; }
        public string CardName { get; set; }
        public int Level { get; set; }
        public string LevelStars
        {
            get { return LevelToStars(); }
        }
        private string attribute;
        public string Attribute
        {
            get
            {
                switch (attribute)
                {
                    case ("Dark"):
                        return "⚫";
                    case ("Light"):
                        return "⚪";
                    case ("Earth"):
                        return "⚫";
                    case ("Water"):
                        return "🔵";
                    case ("Fire"):
                        return "🔴";
                    case ("Wind"):
                        return "⚫";
                    default:
                        break;
                }
                return attribute; 
            }
            set { attribute = value; }
        }

        public int Attack { get; set; }
        public int Defense { get; set; }
        public bool HasEffect { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public YGOMonster(string name, int level, string attribute, int attack, int defense, string type, bool hasEffect, string text, string image)
        {
            CardName = name;
            Level = level;
            Attribute = attribute;
            Attack = attack;
            Defense = defense;
            HasEffect = hasEffect;
            Type = type;
            Text = text;
            Image = image;
        }

        private string LevelToStars()
        {
            string result = "";
            for (int i = 0; i < Level; i++)
            {
                result += "⭐";
            }
            return result;
        }
    }
}
