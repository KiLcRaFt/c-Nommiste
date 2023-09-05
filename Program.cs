using static Ulesane_2_Nommiste.Programmbaseee;

namespace Ulesane_2_Nommiste
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("1. Add group member \n2. Check group member \n3. Add member in BookClub \n4. Check member in BookClub");
            //string ans = Console.ReadLine();

            Random rnd = new Random();
            Group group = new Group(3);

            Console.WriteLine("Kui palju inimest: ");
            string groupmembers = Console.ReadLine();  
            int grupmem = Convert.ToInt32(groupmembers);

            for (int n = 0; n < grupmem; n++)
            {
                Console.WriteLine("Sisseta inimese nimi: ");
                string nimi = Console.ReadLine();
                Console.WriteLine(group.AddMember(nimi));
                //Memember m1 = new Memember(nimi, DateTime.Now);
            };

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", group.Members));  // John, Mary, Jane
            Console.WriteLine("Grupisse on {0} inimest.", group.GetMembersCount());  // 3
            Console.WriteLine();

            Group bookClub = new Group(4);
            
            Console.WriteLine("Kui palju inimest: ");
            string clubmembers = Console.ReadLine();
            int clubmem = Convert.ToInt32(clubmembers);
            

            for (int n = 0; n < clubmem; n++)
            {
                Console.WriteLine("Sisseta inimese nimi: ");
                string nimi = Console.ReadLine();
                Console.WriteLine(bookClub.AddMember(nimi));
                //Memember m1 = new Memember(nimi, DateTime.Now);
            };

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", bookClub.Members));  // Albert, Samantha, Robert, Roberta
            Console.WriteLine("Raamatu kluubis on {0} inimest.", bookClub.GetMembersCount());  // 4
            Console.WriteLine();
            Console.WriteLine(bookClub.HasMember("Albert"));  // True
            Console.WriteLine(bookClub.HasMember("John"));  // False
        }
    }
}