namespace Isikukood
{
    public class Program
    {
        public static void Main()
        {
            Random r = new Random();

            string[] isikukoodid = new string[]
            {
                "37605030299",
                "47802190088",
                "44701043702",
                "49809224976",
                "38610302271",
                "36707285722",
                "43107013710",
                "46711126070",
                "48402044918",
                "46503144917",
                "36301135760",
                "45206173716"
            };
            int i = 0;
            for (int y = 0; y < isikukoodid.Count(); y++)
            {
                IdCode id = new IdCode(isikukoodid[i]);
                if (id.IsValid())
                {
                    id.GenderColor();
                    Console.WriteLine("Gender: " + id.GetGender());
                    Console.WriteLine("Age: " + id.GetAge());
                    Console.WriteLine("BirthDate: " + id.GetBirthDate());
                    Console.WriteLine("Hospital: " + id.GetHospital());
                    Console.WriteLine();
                    Console.ResetColor();
                    i++;
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error");
                    Console.ResetColor();
                }
            }
        }
    }
}