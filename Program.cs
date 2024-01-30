namespace Esercizio2
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compila scheda:");
            Console.WriteLine("Nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Cognome: ");
            string Cognome = Console.ReadLine();
            int Eta = 0;
            bool input = false;
            while (!input)
            {
                Console.WriteLine("Inserisci Etá: ");
                try
                {
                    Eta = Int32.Parse(Console.ReadLine());
                    input = true;
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }

            Persona persona1 = new Persona(Nome, Cognome, Eta);

            Console.WriteLine($"Nome: {persona1.GetNome()}");
            Console.WriteLine($"Cognome: {persona1.GetCognome()}");
            Console.WriteLine($"Età: {persona1.GetEta()}");
            Console.WriteLine($"Dettagli: {persona1.GetDettagli()}");
        }
    }

    class Persona
 
    {
        private int eta;
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta
        {
            get { return eta; }
            set
            {
               if (value <= 17)
              {
                  Console.WriteLine("Sei Minorenne");
              }
               else
               {
                   Console.WriteLine("Sei Maggiorenne");
                }
                eta = value;
           }
        }

        public Persona(string _Nome, string _Cognome, int _Eta)
        {
            Nome = _Nome;
            Cognome = _Cognome;
            Eta = _Eta;
        }
        public string GetNome()
        {
            return Nome;
        }
        public string GetCognome()
        {
            return Cognome;
        }
        public int GetEta()
        {
            return Eta;
        }
        public string GetDettagli()
        {
            return $"Nome:{Nome}, Cognome: {Cognome}, Età: {Eta}";
        }
    }

}