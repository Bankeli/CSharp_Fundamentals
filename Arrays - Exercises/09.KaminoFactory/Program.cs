namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dna = int.Parse(Console.ReadLine()); 
            int[] dnaLenght = new int[dna];
        
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                dnaLenght = command.Split("!").Select(int.Parse).ToArray();
            }
        }
    }
}
