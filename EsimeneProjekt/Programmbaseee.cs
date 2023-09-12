using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulesane_2_Nommiste
{
    internal class Programmbaseee
    {
        //Random rnd = new Random();
        //Group group = new Group(3);
        //public void AddGroup()
        //{
            
        //    for (int n = 0; n < rnd.Next(2, 5); n++)
        //    {
        //        Console.WriteLine("Sisseta inimese nimi: ");
        //        string nimi = Console.ReadLine();
        //        Console.WriteLine(group.AddMember(nimi));
        //        //Memember m1 = new Memember(nimi, DateTime.Now);
        //    };

        //    Console.WriteLine();
        //    Console.WriteLine(string.Join(", ", group.Members));  // John, Mary, Jane
        //    Console.WriteLine("Grupisse on {0} inimest.", group.GetMembersCount());  // 3
        //    Console.WriteLine();
        //}

        //public void CheckGroup()
        //{
        //    Console.WriteLine("Check name: ");
        //    string nimi = Console.ReadLine();
        //    Console.WriteLine(group.HasMember(nimi));
        //    Console.WriteLine();
        //}
        
        public class Memember
        {
            private readonly string _nimi;
            private readonly DateTime _time;

            public Memember(string content, DateTime time)
            {
                _nimi = content;
                _time = time;
            }
            public DateTime Time { get => _time; }
            public string Content { get => _nimi; }

        }
        public void ShowInfo(Memember x)
        {

            Console.WriteLine("Nimi: " + x.Content);
            Console.WriteLine("Time: " + x.Time);
            Console.WriteLine();
        }
    }
}
