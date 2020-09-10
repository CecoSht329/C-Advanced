using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        private Player()
        {
            Rank = "Trial";
            Description = "n/a";
        }
        public Player(string name, string @class) : this()
        {
            Name = name;
            Class = @class;
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            string result = $"Player { Name}: {Class}" +
                $"{Environment.NewLine}Rank: {Rank}" +
                $"{Environment.NewLine}Description: {Description}";
            return result;
        }
    }
}
