namespace Duckbear
{ 
    public class Program
{
    static void Main(string[] args)
    {
        //ask user for variables and assign them
        Console.WriteLine("Enter # of chocolate eggs:");
        int eggs = int.Parse(Console.ReadLine());


        //Calculate how many eggs each should get
        int eggsForSisters = eggs / 4;
        int eggsForDuckbear = eggs % 4;

        //write results to console
        Console.WriteLine("Chocolate Eggs for each sister");
        Console.WriteLine(eggsForSisters);
        Console.WriteLine("Chocolate Eggs for duckbear");
        Console.WriteLine(eggsForDuckbear);

    }
}
}