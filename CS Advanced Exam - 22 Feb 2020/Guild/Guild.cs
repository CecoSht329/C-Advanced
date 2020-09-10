using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get => this.roster.Count(); }
        public void AddPlayer(Player player)
        {
            if (this.roster.Count < Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            if (this.roster.Any(p => p.Name == name))
            {
                Player removedPlayer = this.roster.Where(p => p.Name == name).FirstOrDefault();
                this.roster.Remove(removedPlayer);
                return true;
            }
            return false;
        }

        public void PromotePlayer(string name)
        {
            if (this.roster.Any(p => p.Name == name && p.Rank != "Member"))
            {
                Player playerToPromote = this.roster
                    .Where(p => p.Name == name && p.Rank != "Member")
                    .FirstOrDefault();
                playerToPromote.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            if (this.roster.Any(p => p.Name == name && p.Name != "Trial"))
            {
                Player playerToDemote = this.roster
                    .Where(p => p.Name == name && p.Name != "Trial")
                    .FirstOrDefault();
                playerToDemote.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            List<Player> removed = new List<Player>();
            foreach (Player player in this.roster
                .Where(p => p.Class == @class))
            {
                removed.Add(player);
            }
            for (int i = 0; i < removed.Count(); i++)
            {
                this.roster.Remove(this.roster.Where(p => p.Class == @class).FirstOrDefault());
            }
            return removed.ToArray();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            for (int i = 0; i < this.roster.Count - 1; i++)
            {
                sb.AppendLine($"{this.roster[i]}");
            }
            sb.Append($"{this.roster[this.roster.Count - 1]}");
            return sb.ToString();
        }
    }
}
