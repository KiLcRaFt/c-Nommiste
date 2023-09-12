namespace Ulesane_2_Nommiste
{
   public class Program
    {
        public static void Main()
        {   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kui palju inimest: ");
            Console.ResetColor();
            string groupmembers = Console.ReadLine();
            int grupmem = Convert.ToInt32(groupmembers);

            Group group = new Group(grupmem);
            int n = 0;
            while(n < grupmem)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Sisseta inimese nimi: ");
                Console.ResetColor();
                string nimi = Console.ReadLine();
                if (group.CheckMember(nimi))
                {
                    group.AddMember(nimi);
                    n++;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error");
                    Console.ResetColor();   
                }

            }
            //for (int n = 0; n < grupmem )
            //{
            //    Console.WriteLine("Sisseta inimese nimi: ");
            //    string nimi = Console.ReadLine();
            //    Console.WriteLine(group.AddMember(nimi));
            //};
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int y = 0; y < grupmem; y++)
            {
                Console.WriteLine("Name: " + group.Members[y] + " | Age: " + group.Age[y]);
            }
            Console.WriteLine();
            Console.WriteLine("Grupis on " + group.GetMembersCount() + " inimest\n");
            Console.WriteLine("Kõige vanem inimene on: " + group.OldestMember());
            Console.ReadLine();
        }
    }
}