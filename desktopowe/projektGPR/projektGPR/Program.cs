using System;

namespace projektGPR
{
    class Program
    {
        static void Main()
        {
            Functions.InitiateProgram();
            while (true)
            {
                Console.WriteLine("Algorytmy Klasyczne Aplikacja Zaliczeniowa\n\n\n");

                Console.WriteLine("1.Przeszukiwanie binarne - wersja iteracyjna\n"); //dziel i zwyciężaj
                Console.WriteLine("2.Obliczanie silni liczby naturalnej\n"); //np. !4 = 1*2*3*4, !7 = 1*2*3*4*5*6*7
                Console.WriteLine("3.Sortowanie: bąbelkowe\n");
                Console.WriteLine("4.Sprawdzanie czy wyraz jest Palindromem\n"); //taki sam od przodu jak i od tyłu
                Console.WriteLine("5.Szyfrowanie - szyfr Cezara\n");
                Console.WriteLine("6.Wyznaczanie wartości wyrażenia zapisanego w odwrotnej notacji polskiej ONP\n"); //+ - * / liczb bez nawiasów np. 4 2 3 - *
                Console.WriteLine("7.Jednoczesne znajdowanie minimalnego i maksymalnego elementu\n");
                Console.WriteLine("8.Mnożenie dwóch macierzy 2-wymiarowej\n"); //dwie tablice 2-wymiarowe, a[0,0]*b[0,0]  a[1,0]*b[0,1]  a[2,0]*b[0,2]
                Console.WriteLine("9.Transpozycja macierzy 3x3\n"); //zamiana wiersze na kolumny i na odwrót
                Console.WriteLine("10.Chwila relaksu - zagraj\n");
                Console.WriteLine("11.Wyjdź z programu\n");

                Console.Write("\nWybierz numer: ");
                switch (Console.ReadLine())
                {
                    case "1": Functions.BinarySearch(); break;
                    case "2": Functions.NaturalNumberFactorial(); break;
                    case "3": Functions.BubbleSort(); break;
                    case "4": Functions.IsPalindrome(); break;
                    case "5": Functions.CaesarCypher(); break;
                    case "6": Functions.NotationONP(); break;
                    case "7": Functions.FindMinimumAndMaximum(); break;
                    case "8": Functions.MatrixMultiplication(); break;
                    case "9": Functions.MatrixReposition3x3(); break;
                    case "10": Functions.MomentToRelax(); break;
                    case "11": return;
                    default: Console.Clear(); break;
                }
            }
        }
    }
}