using System;

namespace Testing
{
        public class Program
        {
            public static async Task Main(string[] args)
            {
                Console.WriteLine("UnitConverter - Testy\n");

                // podanie liczbę do przekonwertowania
                Console.WriteLine("Podaj liczbę do przekonwertowania");
                double number = Convert.ToDouble(Console.ReadLine());

                // podanie jednostki z której konwertujemy liczbę
                Console.WriteLine("W jakiej jednostce podales wartosc?");
                Console.WriteLine("1. mm");
                Console.WriteLine("2. cm");
                Console.WriteLine("3. dm");
                Console.WriteLine("4. m");
                Console.WriteLine("5. km");
                int choice = Convert.ToInt32(Console.ReadLine());
                // utworzenie tablicy jednostek do wypisywania ichh w wyniku
                string[] unitName = {"mm", "cm", "dm", "m", "km"};

                double[] result;
                
                // mechanizm konwertowania
                switch(choice)
                {
                    case 1: // dla mm
                        // utworzenie tablice wyników
                        result = new double[] {(number), (number/10), 
                         (number/100), (number/1000), (number/10000000)};
                        
                        // wypisanie wyników
                        for(int i = 0; i<5 ; i++)
                        {
                            Console.WriteLine($"{number} mm = {result[i]} {unitName[i]}");
                        }
                        break;
                    case 2: // dla cm
                        // utworzenie tablice wyników
                        result = new double[] {(number*10), (number), 
                         (number/10), (number/100), (number/1000000)};
                        
                        // wypisanie wyników
                        for(int i = 0; i<5 ; i++)
                        {
                            Console.WriteLine($"{number} cm = {result[i]} {unitName[i]}");
                        }
                        break;
                    case 3:
                        // utworzenie tablice wyników
                        result = new double[] {(number*100), (number*10), 
                         (number), (number/10), (number/10000)};
                        
                        // wypisanie wyników
                        for(int i = 0; i<5 ; i++)
                        {
                            Console.WriteLine($"{number} dm = {result[i]} {unitName[i]}");
                        }
                        break;
                    case 4: // dla metrów

                        // utworzenie tablice wyników
                        result = new double[]{(number * 1000), (number * 100), 
                         (number * 10), number, (number / 1000)};
                        
                        // wypisanie wyników
                        for(int i = 0; i<5 ; i++)
                        {
                            Console.WriteLine($"{number} m = {result[i]} {unitName[i]}");
                        }
                        break;
                    case 5:
                        // utworzenie tablice wyników
                        result = new double[] {(number*1000000), (number*100000), 
                         (number*10000), (number*1000), (number)};
                        
                        // wypisanie wyników
                        for(int i = 0; i<5 ; i++)
                        {
                            Console.WriteLine($"{number} km = {result[i]} {unitName[i]}");
                        }
                        break;
                }

            }
        }
}