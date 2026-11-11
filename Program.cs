namespace TeamHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как се казваш? ");
            string? name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("Моля, въведете име.");
                return;
            }
            Console.WriteLine($"Добър ден, {name?.Trim()}!");

        }
    }
}
