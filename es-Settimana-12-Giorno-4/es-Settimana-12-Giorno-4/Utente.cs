using System;
using System.Collections.Generic;

namespace es_Settimana_12_Giorno_4
{
    public static class Utente
    {
        private static string username { get; set; }
        private static string password { get; set; }
        private static string confirmPassword { get; set; }
        private static bool isLogged = false;

        // list date time crea array di date
        private static DateTime loginTime { get; set; }
        private static List<DateTime> accessi = new List<DateTime>();


        public static void Login()
        {
            if (isLogged)
            {
                Console.WriteLine("Utente gia' loggato!");
                return;
            }
            else
            {
                Console.WriteLine("Inserisci username");
                string username = Console.ReadLine();
                Console.WriteLine("Inserisci password");
                string password = Console.ReadLine();
                Console.WriteLine("Inserisci conferma password");
                string confirmPassword = Console.ReadLine();
                if (username != null && password == confirmPassword)
                {
                    Console.WriteLine("Login effettuato con successo!");
                    loginTime = DateTime.Now;
                    //login time prende la data e ora corrente
                    accessi.Add(loginTime);
                    //aggiunge la data e ora corrente alla lista accessi
                    isLogged = true;
                }
                else
                {
                    Console.WriteLine("Login fallito, riprovare.");
                }
            }
        }

        public static void Logout()
        {
            if (isLogged)
            {
                Console.WriteLine("Vuoi effettuare il logout? (y/n)");
                string risposta = Console.ReadLine();
                if (risposta == "y")
                {
                    Console.WriteLine("Logout effettuato con successo!");
                    username = null;
                    password = null;
                    isLogged = false;
                }
                else
                {
                    Console.WriteLine("Logout annullato!");
                }
            }
            else
            {
                Console.WriteLine("Utente non loggato!");
            }
        }

        public static void VerificaDataOraLogin()
        {
            if (isLogged)
            {
                Console.WriteLine($"Data e ora di login per {username}: {loginTime}");
            }
            else
            {
                Console.WriteLine("Utente non loggato!");
            }
        }

        public static void ListaAccessi()
        {
            if (isLogged)
            {
                Console.WriteLine($"Lista degli accessi:");
                foreach (DateTime accesso in accessi) // per ciascun elemento (accesso in questo caso)
                                                      // presente nell'array di date, mostra in console
                {
                    Console.WriteLine(accesso);
                }
            }
            else
            {
                Console.WriteLine("Utente non loggato!");
            }
        }


    }
}
