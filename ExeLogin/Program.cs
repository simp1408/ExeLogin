using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User.MenuNavigazione();

        }
        public static class User {

            public static string _username;
            public static string _password;
            public static string _confermaPassword;
            public static bool isLog;
            public static DateTime DataAccesso;
            public static List<DateTime> ListaAccessi=new List<DateTime>();

            public static void MenuNavigazione()
            {
                Console.WriteLine("=====Menu Navigazione======");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Logout");
                Console.WriteLine("3. Elenco degli Accessi Utenti");
                Console.WriteLine("===========================");

                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        Console.WriteLine("hai scelto 1");
                        User.Login();
                        break;
                    case "2":
                        Console.WriteLine("hai scelto 2");
                        User.Logout();
                        break;
                    case "3":
                        Console.WriteLine("hai scelto 3");
                        User.Accessi(); 
                        break;
                    default:
                        Console.WriteLine("scelta non valida");
                        MenuNavigazione();  
                        break;

                }




            }

            public static void Login()
            {
                Console.WriteLine("username");
                _username = Console.ReadLine();
                Console.WriteLine("password");
                _password = Console.ReadLine();
                Console.WriteLine("conferma password");
                _confermaPassword = Console.ReadLine();
                DataAccesso = DateTime.Now;
                ListaAccessi.Add(DataAccesso);
                Console.WriteLine($"{_username}loggato alle ore:{DataAccesso}");
                



                if((User._password == User._confermaPassword) && (User._username !=null))
                {
                    isLog= true;
                    Console.WriteLine($"BENVENUTO {_username}");
                   MenuNavigazione();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("errore nel login");
                   MenuNavigazione();
                }
            }
            public static void Logout()
            {
                isLog= false;
                Console.WriteLine("ARRIVEDERCI");
                 
                   MenuNavigazione();
                Console.ReadLine();

            }

            public static void Accessi()
            {
                Console.WriteLine("======Accessi======");
                foreach(DateTime item in ListaAccessi)
                {
                    Console.WriteLine($"{_username}" + item);;

                }
                Console.WriteLine("=====================");
                MenuNavigazione();
                Console.ReadLine(); 

            }
        }
    }
}
