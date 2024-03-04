using entity;

namespace app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nr. produse:");
            uint nrProduse = uint.Parse(Console.ReadLine() ?? string.Empty);
            // array de produse
            var produse = new List<Produs>();
            // citim produsele
            for (var idx = 0; idx < nrProduse; idx++)
            {
                // instantierea unui Produs
                var prod = new Produs();
                Console.WriteLine("Introdu un produs");
                Console.Write("Numele:");
                prod.Nume = Console.ReadLine();
                Console.Write("Codul intern:");
                prod.CodIntern = Console.ReadLine();
                Console.Write("Producator:");
                prod.Producator = Console.ReadLine();
                produse.Add(prod);
            }
            // afisam produsele
            Console.WriteLine("Produsele sunt:");
            for (var cnt = 0; cnt < nrProduse; cnt++)
            {
                Produs prod = produse[cnt];
                Console.WriteLine("Produs: " + prod.Nume + "[" +
                prod.CodIntern + "] " + prod.Producator);
            }
        }
    }
}