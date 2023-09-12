using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulesane_2_Nommiste
{
    public class Group
    {
        public List<string> Members { get; } = new List<string>();
        public List<int> Age { get; } = new List<int>();
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public bool CheckMember(string member)
        {
            if (Members.Contains(member) || Members.Count >= _maxAmount)
            {
                return false;
            }
            return true;
        }

        public bool AddMember(string member)
        {
            Members.Add(member);
            AddAge();
            return true;
        }

        public bool AddAge()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Sisseta inimese vana: ");
            Console.ResetColor();
            string ans = Console.ReadLine();
            int age = Convert.ToInt32(ans);
            if (Age.Count >= _maxAmount) return false;
            Age.Add(age);
            return true;
        }

        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(string member)
        {
            return Members.Contains(member);
        }

        public string OldestMember()
        {
            int ind = Age.IndexOf(Age.Max());
            return Members[ind];
        }
    }
}
