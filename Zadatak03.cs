using System;
					
public class Program
{
	public static void Main()
	{
	Console.WriteLine("Unesi vrijednost x:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Unesi vrijednost y:");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Unesi vrijednost z:");
        int z = Convert.ToInt32(Console.ReadLine());
		if (x > 0 && y > 0 && z > 0)
        {
            if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
            {
                Console.WriteLine("Vrijednost {0}, {1}, i {2} rade kao strane pravokutnika.", x, y, z);
            }
            else
            {
                 Console.WriteLine("Vrijednost {0}, {1}, i {2} ne rade kao strane pravokutnika.", x, y, z);
        }
		}
        else
        {
            Console.WriteLine("Nevrijedna vrijednost. Vrijednost mora biti veće od 0.");
	 }
   }
}