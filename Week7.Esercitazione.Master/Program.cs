using System;

namespace Week7.Esercitazione.Master
{
    public class Program
    {
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryProdottiEF());
        static void Main(string[] args)
        {
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();
                continua = AnalizzaScelta(scelta);
            }
        }

        private static int SchermoMenu()
        {
            Console.WriteLine("Benventi nel menù!");
            Console.WriteLine("1. Visualizza Prodotti");
         
            Console.WriteLine("\n0. Exit");
            Console.WriteLine("********************************************");


            int scelta;
            Console.Write("Inserisci scelta: ");
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 19)
            {
                Console.Write("\nScelta errata. Inserisci scelta corretta: ");
            }
            return scelta;

        }
        private static bool AnalizzaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    VisualizzaProdotti();
                    break;
               
                case 0:
                    return false;
            }
            return true;
        }

        private static void VisualizzaProdotti()
        {
            var prodotti = bl.GetAllProdotti();
            if (prodotti.Count == 0)
            {
                Console.WriteLine("Lista vuota. Non ci sono prodotti!");
            }
            else
            {
                Console.WriteLine("I Prodotti disponibili sono:");
                foreach (var item in prodotti)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
