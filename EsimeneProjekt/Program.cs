namespace Ulesane_2_Nommiste
{
   public class Program
    {
        public static void Main()
        {   
            Console.WriteLine("Kui palju inimest: ");
            string groupmembers = Console.ReadLine();
            int grupmem = Convert.ToInt32(groupmembers);

            Group group = new Group(grupmem);
            int n = 0;
            while(n < grupmem)
            {
                Console.WriteLine("Sisseta inimese nimi: ");
                string nimi = Console.ReadLine();
                if (group.AddMember(nimi))
                {
                    Console.WriteLine(group.AddMember(nimi));
                    n++;
                }
                else {
                    Console.WriteLine("Error");
                }

            }
            //for (int n = 0; n < grupmem )
            //{
            //    Console.WriteLine("Sisseta inimese nimi: ");
            //    string nimi = Console.ReadLine();
            //    Console.WriteLine(group.AddMember(nimi));
            //};
            Console.WriteLine();
            for (int y = 0; y < group.GetMembersCount(); y++)
            {
                Console.WriteLine(string.Join("Name: ", group.Members[n]) + " " + string.Join("Type: ", group.Age[n]));
            };
            Console.WriteLine();
            Console.WriteLine("Grupisse on " + group.GetMembersCount() + " inimest\n");
        }
    }
}