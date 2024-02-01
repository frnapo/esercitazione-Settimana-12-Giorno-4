using System;

namespace es_Settimana_12_Giorno_4
{
    internal class Program
    {

        static bool esci = false;
        static void Main(string[] args)
        {
            while (!esci)
            {
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Logout");
                Console.WriteLine("3. Verifica ora e data di login");
                Console.WriteLine("4. Lista degli accessi");
                Console.WriteLine("5. Esci");
                Console.WriteLine("=======================================");
                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        Utente.Login();
                        break;
                    case "2":
                        Utente.Logout();
                        break;
                    case "3":
                        Utente.VerificaDataOraLogin();
                        break;
                    case "4":
                        Utente.ListaAccessi();
                        break;
                    case "5":
                        esci = true;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida!");
                        break;
                }
            }

        }
    }
}



