using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count { get => this.data.Count; }

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            this.data.Remove(this.data.Where(h => h.Name == name).FirstOrDefault());
        }

        public Hero GetHeroWithHighestStrength()
        {
            return this.data.OrderByDescending(h => h.Item.Strength).FirstOrDefault();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return this.data.OrderByDescending(h => h.Item.Ability).FirstOrDefault();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return this.data.OrderByDescending(h => h.Item.Intelligence).FirstOrDefault();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.data.Count - 1; i++)
            {
                sb.AppendLine($"{this.data[i]}");
            }
            sb.Append($"{this.data[this.data.Count - 1]}");
            return sb.ToString();
        }
    }
}
