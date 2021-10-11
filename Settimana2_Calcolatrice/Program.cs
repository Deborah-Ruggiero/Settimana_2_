using System;

namespace Settimana2_Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {




            using System;

namespace AcademyDWeek2
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World! Questa è una Calcolatrice!");
                Console.WriteLine("Come ti chiami?");
                string nomeUtente;
                nomeUtente = Console.ReadLine();
                Console.WriteLine($"Ciao {nomeUtente}");
                //Console.Write("Inserisci il primo numero intero:");
                bool continua = false;
                do
                {
                    int primoNumero;
                    //primoNumero=int.Parse(Console.ReadLine());

                    //bool prova = true; //entro nel ciclo, non entra con prova=false
                    //while (prova) //while(prova==true)
                    //{
                    //    Console.WriteLine("entro nel ciclo");

                    //}

                    //bool prova = true; //non estra ma entra con prova=false
                    //while (!prova) //while(!prova==true)
                    //{
                    //    Console.WriteLine("entro nel ciclo");
                    //}

                    //bool esitoConversione = int.TryParse(Console.ReadLine(), out primoNumero);

                    //while (esitoConversione == false)
                    //{
                    //    Console.WriteLine("Hai inserito un valore errato. Inserisci un numero intero:");
                    //    esitoConversione = int.TryParse(Console.ReadLine(), out primoNumero);
                    //}

                    do
                    {
                        Console.WriteLine("Inserisci il primo numero intero:");

                    } while (!int.TryParse(Console.ReadLine(), out primoNumero));
                    Console.WriteLine($"Il primo numero che hai inserito è: {primoNumero}");

                    int secondoNumero;
                    do
                    {
                        Console.WriteLine("Inserisci il secondo numero intero:");

                    } while (!int.TryParse(Console.ReadLine(), out secondoNumero));
                    Console.WriteLine($"Il secondo numero che hai inserito è: {secondoNumero}");

                    //int a = 1;
                    //int b = 2;
                    //StampaValori(a, b);
                    //ModificaValori(a, b);
                    //Console.WriteLine($"I due valori sono: a={a} e b={b}");
                    //ModificaValoriDelleVariabiliIniziali(ref a, ref b);
                    //Console.WriteLine($"I due valori sono: a={a} e b={b}");

                    //int somma= SommaEMoltiplica(a, b, out int prodotto);
                    //Console.WriteLine($"La somma è {somma} e il prodottoè {prodotto}");

                    //int c= Somma(a, b);
                    //Console.WriteLine($"La variabile c è uguale a {c}");


                    //int somma2= SommaEDifferenza(12, 3, out string esitoDifferenza);
                    //Console.WriteLine("la differenza è un valore " + esitoDifferenza + $" la somma invece è {somma2}");

                    Console.WriteLine("\n--------------------Menu----------------------\n");
                    Console.WriteLine("Scegli A per fare la somma dei 2 numeri inseriti");
                    Console.WriteLine("Scegli B per fare la differenza dei 2 numeri inseriti");
                    Console.WriteLine("Scegli C per fare il prodotto dei 2 numeri inseriti");
                    Console.WriteLine("Scegli D per fare il quoziente dei 2 numeri inseriti");

                    char sceltaUtente;
                    //char sceltaUtente = char.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("\nFai la tua scelta");
                        sceltaUtente = Console.ReadKey().KeyChar;
                        //} while (sceltaUtente=='A' || sceltaUtente=='B' || sceltaUtente == 'C' || sceltaUtente == 'D'); //case sensitive
                    } while (!(sceltaUtente.ToString().ToUpper() == "A" || sceltaUtente.ToString().ToUpper() == "B" || sceltaUtente.ToString().ToUpper() == "C" || sceltaUtente.ToString().ToUpper() == "D")); //case sensitive

                    Console.WriteLine($"la tua scelta è {sceltaUtente}");
                    switch (sceltaUtente.ToString().ToUpper())
                    {
                        case "A":
                            int somma;
                            somma = Somma(primoNumero, secondoNumero);
                            Console.WriteLine($"La somma è: {somma}");
                            break;
                        case "B":
                            int differenza;
                            differenza = Sottrai(primoNumero, secondoNumero);
                            Console.WriteLine($"La differenza è: {primoNumero - secondoNumero}");
                            break;

                        case "C":
                            int prodotto;
                            prodotto = Moltiplica(primoNumero, secondoNumero);
                            Console.WriteLine($"Il prodotto è : {prodotto}");
                            break;

                        case "D":
                            if (secondoNumero == 0)
                            {
                                Console.WriteLine("Impossibile");
                            }
                            else
                            {
                                double quoziente;
                                quoziente = Dividi((double)primoNumero, (double)secondoNumero);
                                Console.WriteLine($"Il quoziente è {quoziente}");
                            }
                            break;
                    }

                    Console.WriteLine("Vuoi continuare? Inserisi si per continuare, qualsiasi altra cosa per uscire");
                    string risposta = Console.ReadLine();

                    if (risposta.ToLower() == "si")
                    {
                        continua = true;
                    }
                    else
                    {
                        continua = false;
                    }

                } while (continua);
            }

            private static int Somma(int x, int y)
            {
                return x + y;
            }
            private static int Sottrai(int x, int y)
            {
                return x - y;
            }
            private static int Moltiplica(int x, int y)
            {
                return x * y;
            }

            private static double Dividi(double x, double y)
            {
                return x / y;
            }
        }
    }
}
    }
}
