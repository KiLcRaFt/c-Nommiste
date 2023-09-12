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
        public List<string> Age { get; } = new List<string>();
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public bool AddMember(string member)
        {
            if (Members.Contains(member)) return false;
            if (Members.Count >= _maxAmount) return false;
            Members.Add(member);
            AddAge();
            return true;
        }

        public bool AddAge()
        {
            Console.WriteLine("Sisseta inimese vana: ");
            string age = Console.ReadLine();
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

    }
}
