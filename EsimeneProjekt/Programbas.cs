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
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public bool AddMember(string Member)
        {
            if (Member.Contains(Member)) return false;
            if (Members.Count >= _maxAmount) return false;
            Members.Add(Member);
            return true;
        }

        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(string Member)
        {
            return Members.Contains(Member);
        }

    }
}
