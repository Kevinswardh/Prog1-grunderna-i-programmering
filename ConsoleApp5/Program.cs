// See https://aka.ms/new-console-template for more information
using System;


namespace buycar
{
    public class Program
    {

        static void Main(string[] args)
        {


            string S = "";



            S += "\\";


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("               /l--------------------l" + S);
            Console.WriteLine("              / l                    l " + S);
            Console.Write("             /  l");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Bilfirman     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("l  " + S);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("            /   l                    l   " + S);
            Console.WriteLine("           /____l--------------------l____" + S);


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           Hej och välkommen till Bilfirman! ");
            Console.WriteLine("           ________________________________  ");
            Console.WriteLine("           l  Vi på bilfirman köper in en  l ");
            Console.WriteLine("           l   del bilar från kunder som   l ");
            Console.WriteLine("           l     är intresserade av att    l ");
            Console.WriteLine("           l             sälja             l ");
            Console.WriteLine("           ---------------------------------- ");
            Console.WriteLine("           :::::::::::::::::::::::::::::::::: ");
            Console.WriteLine("           __________________________________ ");
            Console.WriteLine("           l  Vi kommer gå igenom allting   l ");
            Console.WriteLine("           l eftersom men just nu undrar jagl ");
            Console.WriteLine("           l      vad ditt namn är?         l ");
            string handlarensnamn = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                    Hallå  " + handlarensnamn);                        //Itroduktion + Val av namn
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           l    Vad trevligt att du har     l ");
            Console.WriteLine("           l  besökt oss här på Bilfirman   l ");
            Console.WriteLine("           ----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("   _____________________________________________________");
            Console.WriteLine("  l          Jag kommer ställa ett antal frågor         l ");
            Console.WriteLine("  l   angående bilen som jag önskar att kunnat svara på l");
            Console.WriteLine("  -------------------------------------------------------");
            Console.WriteLine("            Svara med en [1} för att fortsätta");
            Console.ReadLine();
            väljbil();
            static void väljbil()
            {
                Console.WriteLine("  __________________________________________________________________________________________");
                Console.WriteLine("  l                          För tillfället köper vi bara in                                l ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("     [Volvo C40 Recharge] [BMW X5] [Tesla Model 3] [Mustang 70 EcoBoost® Premium Fastback]      ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  l          ^               ^            ^                          ^                      l");
                Console.WriteLine("  ------------------------------------------------------------------------------------------");
                Console.WriteLine("                             _________________________________");
                Console.WriteLine("                             l      Vilket namn på bilen?     l ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                                  Hint: Räcker med Bilmärke");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                             ----------------------------------");
                string bilnamn = Console.ReadLine();
                string enkelbilnamn = bilnamn.Split(new char[] { ' ' })[0];   // håll koll på eventuella buggs med split. te.x om väljaren skriver in volvo c40 reserge fungerar progammet fortfarande. 

                if (enkelbilnamn == "volvo")     // Liten bokstav (volvo)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           Okej en stycke: " + enkelbilnamn);                            // Val av bilen
                    Console.WriteLine("");
                }
                else if (enkelbilnamn == "Volvo") // stor bokstav (volvo)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           Okej en stycke: " + enkelbilnamn);                            // Val av bilen
                    Console.WriteLine("");
                }
                else if (enkelbilnamn == "bmw") // liten bokstav (bmw)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           Okej en stycke: " + enkelbilnamn);                            // Val av bilen
                    Console.WriteLine("");
                }
                else if (enkelbilnamn == "Bmw") // stor bokstav (bmw)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           Okej en stycke: " + enkelbilnamn);                            // Val av bilen
                    Console.WriteLine("");
                }
                else if (enkelbilnamn == "tesla") // liten bokstav (tesla)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           Okej en stycke: " + enkelbilnamn);                            // Val av bilen
                    Console.WriteLine("");
                }
                else if (enkelbilnamn == "Tesla") // stor bokstav (tesla)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           Okej en stycke: " + enkelbilnamn);                            // Val av bilen
                    Console.WriteLine("");
                }
                else if (enkelbilnamn == "mustang") // liten bokstav (mustang)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           Okej en stycke: " + enkelbilnamn);                            // Val av bilen
                    Console.WriteLine("");
                }
                else if (enkelbilnamn == "Mustang") // stor bokstav (mustang)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           Okej en stycke: " + enkelbilnamn);                            // Val av bilen
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vi köper tyvärr inte in den typen av bil eller så har du skrivit in fel");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                  Var god och försök igen");
                    väljbil();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                             _________________________________");
                Console.WriteLine("                             l    Vilken årsmodell har bilen?  l ");
                Console.WriteLine("                             ----------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                                [2021] [2020] [2019] [2018]        ");   //lägg till lösning för felskrivning
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                int årsmodell = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           Okej årsmodell: " + årsmodell);                               // Val av årsmodell
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                             _________________________________");
                Console.WriteLine("                             l    Vilket miltal har bilen?    l ");
                Console.WriteLine("                             ----------------------------------");
                Console.WriteLine("");
                double miltal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("            Okej miltalet är: " + miltal);                              // Val av miltal på bilen
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("");

                nymethod();

                if (enkelbilnamn == "volvo" || enkelbilnamn == "Volvo")                                                              //(((((  BMW valet  *  2  ))))))
                {
                    int volvopris = 160000; // 150.000
                    decimal procentåtta = 0.8m;
                    decimal procentsju = 0.7m;
                    decimal procentsex = 0.6m;                                          //------------------------------------------------------------------------------------------------------------------
                    decimal procentfem = 0.5m;                                          // Detta fungerar sålänge svaret blir jämnt annars printar den ut .99999999 troligtvis pga double och inte decimal l
                    decimal procentfyra = 0.4m;                                         // Fungerar överallt förutom på volvo miltal mellan 1000-5000 och beroende på årtal som ändras pga int variablerna
                    int årsmodelltjugoett = 40000;  //startsumma                      // Update - Decimal ska fungera i annat program så ändrar.
                    int årsmodelltjugotjugo = 30000;  //startsumma                    //------------------------------------------------------------------------------------------------------------------
                    int årsmodelltjugnitton = 20000;  //startsumma
                    int årsmodelltjugoarton = 10000;  //startsumma     fick lägga till en tvåa 14302 vid double
                    if (årsmodell == 2021) // 2021                                                          VOLVO 2021
                    {

                        if (miltal < 1000)
                        {


                            decimal kombination = (volvopris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (volvopris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (volvopris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (volvopris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (volvopris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside VOLVO 2021 end VOLVO 2021

                    else if (årsmodell == 2020) // 2020                                                           VOLVO 2020
                    {

                        if (miltal < 1000)
                        {


                            decimal kombination = (volvopris + årsmodelltjugotjugo) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (volvopris + årsmodelltjugotjugo) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (volvopris + årsmodelltjugotjugo) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (volvopris + årsmodelltjugotjugo) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 19999)
                        {

                            decimal kombination = (volvopris + årsmodelltjugotjugo) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside VOLVO 2020  End of VOLVO 2020
                    else if (årsmodell == 2019) // 2019                                                           VOLVO 2019
                    {

                        if (miltal < 1000)
                        {


                            decimal kombination = (volvopris + årsmodelltjugnitton) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (volvopris + årsmodelltjugnitton) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (volvopris + årsmodelltjugnitton) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (volvopris + årsmodelltjugnitton) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 19999)
                        {

                            decimal kombination = (volvopris + årsmodelltjugnitton) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside VOLVO 2019  End of VOLVO 2019

                    else if (årsmodell == 2018) // 2018                                                           VOLVO 2018
                    {

                        if (miltal < 1000)
                        {


                            decimal kombination = (volvopris + årsmodelltjugoarton) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (volvopris + årsmodelltjugoarton) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (volvopris + årsmodelltjugoarton) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (volvopris + årsmodelltjugoarton) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        else if (miltal > 19999)
                        {

                            decimal kombination = (volvopris + årsmodelltjugoarton) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside volvo 2018 End of 2018
                }  //inside if statment VOLVO

                if (enkelbilnamn == "bmw")                                                              //(((((  BMW valet  *  2  ))))))
                {
                    int bmwpris = 120000; // 120.000
                    decimal procentåtta = 0.8m;
                    decimal procentsju = 0.7m;
                    decimal procentsex = 0.6m;
                    decimal procentfem = 0.5m;
                    decimal procentfyra = 0.4m;
                    if (årsmodell == 2021) // 2021                                                          BMW 2021
                    {
                        int årsmodelltjugoett = 40000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside BMW 2021 end BMW 2021

                    if (årsmodell == 2020) // 2020                                                           BMW 2020
                    {
                        int årsmodelltjugoett = 30000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside bmw 2020  End of bmw 2020
                    if (årsmodell == 2019) // 2019                                                           BMW 2019
                    {
                        int årsmodelltjugoett = 20000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside bmw 2019 End of bmw 2019
                    if (årsmodell == 2018) // 2018                                                           BMW 2018
                    {
                        int årsmodelltjugoett = 10000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (bmwpris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside volvo 2018 End of 2018
                }  //inside if statment BMW
                if (enkelbilnamn == "tesla")                                                              //(((((  Tesla valet  *  3  ))))))
                {
                    int teslapris = 230000; // 230.000
                    decimal procentåtta = 0.8m;
                    decimal procentsju = 0.7m;
                    decimal procentsex = 0.6m;
                    decimal procentfem = 0.5m;
                    decimal procentfyra = 0.4m;
                    if (årsmodell == 2021) // 2021                                                          tesla 2021
                    {
                        int årsmodelltjugoett = 40000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (teslapris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (teslapris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside tesla 2021 end tesla 2021

                    if (årsmodell == 2020) // 2020                                                           tesla 2020
                    {
                        int årsmodelltjugoett = 30000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (teslapris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (teslapris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside tesla 2020  End of tesla 2020
                    if (årsmodell == 2019) // 2019                                                           tesla 2019
                    {
                        int årsmodelltjugoett = 20000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (teslapris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (teslapris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside tesla 2019 End of tesla 2019
                    if (årsmodell == 2018) // 2018                                                           tesla 2018
                    {
                        int årsmodelltjugoett = 10000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (teslapris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (teslapris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (teslapris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside tesla 2018 End of tesla 2018
                }  //inside if statmen Tesla
                if (enkelbilnamn == "ford mustang")                                                              //(((((  Mustang valet  *  4  ))))))
                {
                    int mustangpris = 300000; // 300.000
                    decimal procentåtta = 0.8m;
                    decimal procentsju = 0.7m;
                    decimal procentsex = 0.6m;
                    decimal procentfem = 0.5m;
                    decimal procentfyra = 0.4m;
                    if (årsmodell == 2021) // 2021                                                          tesla 2021
                    {
                        int årsmodelltjugoett = 40000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside Mustang 2021 end Mustang 2021

                    if (årsmodell == 2020) // 2020                                                           Mustang 2020
                    {
                        int årsmodelltjugoett = 30000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                    } //inside Mustang 2020  End of Mustang 2020
                    if (årsmodell == 2019) // 2019                                                           Mustang 2019
                    {
                        int årsmodelltjugoett = 20000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 19999)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }
                    } //inside Mustang 2019 End of Mustang 2019
                    if (årsmodell == 2018) // 2018                                                           Mustang 2018
                    {
                        int årsmodelltjugoett = 10000;  //startsumma
                        if (miltal < 1000)
                        {


                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentåtta;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 999 && miltal < 5000)
                        {


                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentsju;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 4999 && miltal < 10000)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentsex;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }
                        if (miltal > 9999 && miltal < 20000)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentfem;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");
                        }

                        if (miltal > 19999)
                        {

                            decimal kombination = (mustangpris + årsmodelltjugoett) * procentfyra;
                            Console.WriteLine("       ________________________________________________");
                            Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                            Console.WriteLine("          " + enkelbilnamn + " som har årsmodell " + årsmodell);
                            Console.WriteLine("          med miltalet: " + miltal);
                            Console.WriteLine("          blir den ungefärliga summan");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("          Summa: " + kombination + " Kr");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("       ------------------------------------------------");

                        }

                    } //inside Mustang 2018 End of Mustang 2018

                }  //inside if statmen Mustang

                /* Här ska vi försöka ha bilval nummer 2 */

                Console.WriteLine("                            ___________________________________");
                Console.WriteLine("                            l      Skulle du vara intresserad  l ");
                Console.WriteLine("                            l      av att sälja en andra bil?  l ");
                Console.WriteLine("                            -----------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("               1 Är inte klar än !");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("             ______________________     ____________________    ________________   ");
                Console.WriteLine("             l Lägg till Bil: [1]  l    l Välj ny bil: [2]  l   l Avsluta: [3]  l  ");
                Console.WriteLine("             -----------------------    ---------------------   ----------------- ");

                int Svar = Convert.ToInt32(Console.ReadLine());
                if (Svar == 1)
                {
                    väljbiltvå();
                }
                else if (Svar == 2)
                {
                    väljbil();
                }
                else if (Svar == 3)
                {
                    Console.WriteLine("Okej. Hoppas vi kunde hälpa dig, vad god att stäng programmet genom att trycka valfri bokstav");
                }
                else
                {
                    Console.WriteLine("Okej. Hoppas vi kunde hälpa dig, vad god att stäng programmet genom att trycka valfri bokstav");
                }

            }
        
    }
        private static void nymethod()   //methodtest
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                     Kalkylatorn");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void väljbiltvå()
        {
            Console.WriteLine("  __________________________________________________________________________________________");
            Console.WriteLine("  l                          För tillfället köper vi bara in                                l ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("     [Volvo C40 Recharge] [BMW X5] [Tesla Model 3] [Mustang 70 EcoBoost® Premium Fastback]      ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  l          ^               ^            ^                          ^                      l");
            Console.WriteLine("  ------------------------------------------------------------------------------------------");
            Console.WriteLine("                             _________________________________");
            Console.WriteLine("                             l      Vilket namn på bilen?     l ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                  Hint: Räcker med Bilmärke");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                             ----------------------------------");
            string bilnamntvå = Console.ReadLine();
            string enkelbilnamntvå = bilnamntvå.Split(new char[] { ' ' })[0];   // håll koll på eventuella buggs med split. te.x om väljaren skriver in volvo c40 reserge fungerar progammet fortfarande. 

            if (enkelbilnamntvå == "volvo")     // Liten bokstav (volvo)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           Okej en stycke: " + enkelbilnamntvå);                            // Val av bilen
                Console.WriteLine("");
            }
            else if (enkelbilnamntvå == "Volvo") // stor bokstav (volvo)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           Okej en stycke: " + enkelbilnamntvå);                            // Val av bilen
                Console.WriteLine("");
            }
            else if (enkelbilnamntvå == "bmw") // liten bokstav (bmw)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           Okej en stycke: " + enkelbilnamntvå);                            // Val av bilen
                Console.WriteLine("");
            }
            else if (enkelbilnamntvå == "Bmw") // stor bokstav (bmw)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           Okej en stycke: " + enkelbilnamntvå);                            // Val av bilen
                Console.WriteLine("");
            }
            else if (enkelbilnamntvå == "tesla") // liten bokstav (tesla)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           Okej en stycke: " + enkelbilnamntvå);                            // Val av bilen
                Console.WriteLine("");
            }
            else if (enkelbilnamntvå == "Tesla") // stor bokstav (tesla)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           Okej en stycke: " + enkelbilnamntvå);                            // Val av bilen
                Console.WriteLine("");
            }
            else if (enkelbilnamntvå == "mustang") // liten bokstav (mustang)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           Okej en stycke: " + enkelbilnamntvå);                            // Val av bilen
                Console.WriteLine("");
            }
            else if (enkelbilnamntvå == "Mustang") // stor bokstav (mustang)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("           Okej en stycke: " + enkelbilnamntvå);                            // Val av bilen
                Console.WriteLine("");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vi köper tyvärr inte in den typen av bil eller så har du skrivit in fel");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                  Var god och försök igen");
                väljbiltvå();
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                             _________________________________");
            Console.WriteLine("                             l    Vilken årsmodell har bilen?  l ");
            Console.WriteLine("                             ----------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                [2021] [2020] [2019] [2018]        ");   //lägg till lösning för felskrivning
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            int årsmodelltvå = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("           Okej årsmodell: " + årsmodelltvå);                               // Val av årsmodell
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                             _________________________________");
            Console.WriteLine("                             l    Vilket miltal har bilen?    l ");
            Console.WriteLine("                             ----------------------------------");
            Console.WriteLine("");
            decimal miltaltvå = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            Okej miltalet är: " + miltaltvå);                              // Val av miltal på bilen
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");

            nymethod();

            if (enkelbilnamntvå == "volvo")                                                              //(((((  Volvo valet  *  1  ))))))
            {
                int volvopris = 150000; // 150.000
                decimal procentåtta = 0.8m;
                decimal procentsju = 0.7m;
                decimal procentsex = 0.6m;
                decimal procentfem = 0.5m;
                decimal procentfyra = 0.4m;
                if (årsmodelltvå == 2021) // 2021                                                          Volvo 2021
                {
                    int årsmodelltjugoett = 40000;  //startsumma
                    if (miltaltvå < 1000)   //****
                    {


                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000) //***
                    {


                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)  //***
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)  //***
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside volvo 2021

                else if (årsmodelltvå == 2020) // 2020                                                           Volvo 2020
                {
                    int årsmodelltjugoett = 30000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside volvo 2020  End of 2020
                else if (årsmodelltvå == 2019) // 2019                                                           Volvo 2019
                {
                    int årsmodelltjugoett = 20000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside volvo 2019 End of 2019
                else if (årsmodelltvå == 2018) // 2018                                                           Volvo 2018
                {
                    int årsmodelltjugoett = 10000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (volvopris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside volvo 2018 End of 2018
            }  //inside if statment volvo
            if (enkelbilnamntvå == "bmw")                                                              //(((((  BMW valet  *  2  ))))))
            {
                int bmwpris = 120000; // 120.000
                decimal procentåtta = 0.8m;
                decimal procentsju = 0.7m;
                decimal procentsex = 0.6m;
                decimal procentfem = 0.5m;
                decimal procentfyra = 0.4m;
                if (årsmodelltvå == 2021) // 2021                                                          BMW 2021
                {
                    int årsmodelltjugoett = 40000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside BMW 2021 end BMW 2021

                if (årsmodelltvå == 2020) // 2020                                                           BMW 2020
                {
                    int årsmodelltjugoett = 30000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside bmw 2020  End of bmw 2020
                if (årsmodelltvå == 2019) // 2019                                                           BMW 2019
                {
                    int årsmodelltjugoett = 20000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside bmw 2019 End of bmw 2019
                if (årsmodelltvå == 2018) // 2018                                                           BMW 2018
                {
                    int årsmodelltjugoett = 10000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (bmwpris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside volvo 2018 End of 2018
            }  //inside if statment BMW
            if (enkelbilnamntvå == "tesla")                                                              //(((((  Tesla valet  *  3  ))))))
            {
                int teslapris = 230000; // 230.000
                decimal procentåtta = 0.8m;
                decimal procentsju = 0.7m;
                decimal procentsex = 0.6m;
                decimal procentfem = 0.5m;
                decimal procentfyra = 0.4m;
                if (årsmodelltvå == 2021) // 2021                                                          tesla 2021
                {
                    int årsmodelltjugoett = 40000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside tesla 2021 end tesla 2021

                if (årsmodelltvå == 2020) // 2020                                                           tesla 2020
                {
                    int årsmodelltjugoett = 30000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside tesla 2020  End of tesla 2020
                if (årsmodelltvå == 2019) // 2019                                                           tesla 2019
                {
                    int årsmodelltjugoett = 20000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside tesla 2019 End of tesla 2019
                if (årsmodelltvå == 2018) // 2018                                                           tesla 2018
                {
                    int årsmodelltjugoett = 10000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (teslapris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside tesla 2018 End of tesla 2018
            }  //inside if statmen Tesla
            if (enkelbilnamntvå == "mustang")                                                              //(((((  Mustang valet  *  4  ))))))
            {
                int mustangpris = 300000; // 300.000
                decimal procentåtta = 0.8m;
                decimal procentsju = 0.7m;
                decimal procentsex = 0.6m;
                decimal procentfem = 0.5m;
                decimal procentfyra = 0.4m;
                if (årsmodelltvå == 2021) // 2021                                                          tesla 2021
                {
                    int årsmodelltjugoett = 40000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside Mustang 2021 end Mustang 2021

                if (årsmodelltvå == 2020) // 2020                                                           Mustang 2020
                {
                    int årsmodelltjugoett = 30000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                } //inside Mustang 2020  End of Mustang 2020
                if (årsmodelltvå == 2019) // 2019                                                           Mustang 2019
                {
                    int årsmodelltjugoett = 20000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 19999)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");

                    }
                } //inside Mustang 2019 End of Mustang 2019
                if (årsmodelltvå == 2018) // 2018                                                           Mustang 2018
                {
                    int årsmodelltjugoett = 10000;  //startsumma
                    if (miltaltvå < 1000)
                    {


                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentåtta;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 999 && miltaltvå < 5000)
                    {


                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentsju;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 4999 && miltaltvå < 10000)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentsex;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }
                    if (miltaltvå > 9999 && miltaltvå < 20000)
                    {

                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentfem;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                    }

                    if (miltaltvå > 19999)
                    {
                        
                        
                        decimal kombinationtvå = (mustangpris + årsmodelltjugoett) * procentfyra;
                        Console.WriteLine("       ________________________________________________");
                        Console.WriteLine("          Våra tidiga uträkningar till bilen ");
                        Console.WriteLine("          " + enkelbilnamntvå + " som har årsmodell " + årsmodelltvå);
                        Console.WriteLine("          med miltalet: " + miltaltvå);
                        Console.WriteLine("          blir den ungefärliga summan");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("          Summa: " + kombinationtvå + " Kr");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("       ------------------------------------------------");
                        
                    }

                } //inside Mustang 2018 End of Mustang 2018
            }  //inside if statmen Mustang car  
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Och totala summan för båda bilarna är:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Error:404");
            
            Console.ForegroundColor = ConsoleColor.White;
        }
       
    }
    
}




        





