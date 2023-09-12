namespace Isikukood
{
    public class Program
    {
        public static void Main()
        {
            IdCode id = new IdCode("37605030299");
            if (id.IsValid())
            {
                Console.WriteLine("BirthDate: " + id.GetBirthDate());
                Console.WriteLine("Age: " + id.GetAge());
                Console.WriteLine("Hospital: " + id.GetHospital());
                Console.WriteLine();
            }
            else { Console.WriteLine("Error"); }
        }
    }
}