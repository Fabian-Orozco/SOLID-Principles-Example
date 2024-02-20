// Estudiante: Fabián Orozco Chaves
// Tomado de: https://medium.com/@hdmdhr/learn-solid-principles-by-building-a-simple-app-2111184df426

namespace VendingMachineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nVending Machine from JSON products:");
            var menuLoader = new JsonMenuLoader();
            var vendingMachine = new VendingMachine(menuLoader);
            vendingMachine.Start();

            Console.WriteLine("\n\nVending Machine from CSV products:");
            var menuLoader2 = new CsvMenuLoader();
            var vendingMachine2 = new VendingMachine(menuLoader2);
            vendingMachine2.Start();
            Console.WriteLine("\n");

            Console.WriteLine("\n\nHighEfficiencyVendingMachine from JSON products:");
            var menuLoader3 = new JsonMenuLoader();
            var vendingMachine3 = new HighEfficiencyVendingMachine(menuLoader3);
            vendingMachine3.Start();
            Console.WriteLine("\n");

        }
    }
}
