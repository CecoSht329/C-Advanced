using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //read {contest}:{password for contest} until “end of contests” is given
            //save data in dictionary<contest,password> 
            //read “{contest}=>{password}=>{username}=>{points}” until “end of submissions” is given
            //check if contest valid, should be in firstDictionary
            //check if password valid, should be in firstDictionary
            //add user to dictionary<user,dictionary<contest,points>> if prevoius 2 are true 
            var contestPasswords = new Dictionary<string, string>();
            var userContestPoints = new Dictionary<string, Dictionary<string, int>>();


            var contestAndPassword = "";
            while ((contestAndPassword = Console.ReadLine()) != "end of contests")
            {
                var tokens = contestAndPassword.Split(":", StringSplitOptions.RemoveEmptyEntries);
                var contest = tokens[0];
                var password = tokens[1];
                if (!contestPasswords.ContainsKey(contest))
                {
                    contestPasswords[contest] = string.Empty;
                }
                contestPasswords[contest] = password;
            }

            var input = "";
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                var contestPasswordUsernamePoints = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                var contest = contestPasswordUsernamePoints[0];
                var password = contestPasswordUsernamePoints[1];
                var user = contestPasswordUsernamePoints[2];
                var points = int.Parse(contestPasswordUsernamePoints[3]);

                if (contestPasswords.ContainsKey(contest) && contestPasswords.ContainsValue(password))
                {
                    if (!userContestPoints.ContainsKey(user))
                    {
                        userContestPoints[user] = new Dictionary<string, int>();
                    }
                    if (!userContestPoints[user].ContainsKey(contest))
                    {
                        userContestPoints[user][contest] = 0;
                    }
                    if (points > userContestPoints[user][contest])
                    {
                        userContestPoints[user][contest] = points;
                    }
                }
            }
            var userTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in userContestPoints)
            {
                int totalPoints = 0;
                foreach (var pair in userContestPoints[kvp.Key])
                {
                    totalPoints += pair.Value;
                }
                if (!userTotalPoints.ContainsKey(kvp.Key))
                {
                    userTotalPoints[kvp.Key] = 0;
                }
                userTotalPoints[kvp.Key] = totalPoints;
            }

            foreach (var kvp in userTotalPoints.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                break;
            }

            Console.WriteLine("Ranking: ");
            foreach (var kvp in userContestPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (var pair in userContestPoints[kvp.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
