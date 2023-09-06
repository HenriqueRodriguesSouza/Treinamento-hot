using System.ComponentModel;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Programa
{
    public static int Valor;
    public static bool Palindromo(int NumeroPalindromo)
    {
        string NumeroString = NumeroPalindromo.ToString();
        char[] charArray = NumeroString.ToCharArray();
        Array.Reverse(charArray);
        string reverseArray = new string(charArray);

        if (NumeroString == reverseArray)
        {
            System.Console.WriteLine("verdade para " + NumeroPalindromo);
            Valor = Int32.Parse(reverseArray);
            return Primo(Valor);

        }
        else
        {
            NumeroPalindromo++;
            return Palindromo(NumeroPalindromo);
        }

    }

    public static bool Primo(int Numero)
    {
        if (Numero <= 1)
        {
            System.Console.WriteLine("nao e primo");
            Valor++;
            return Palindromo(Valor); // 0 and 1 are not prime numbers
        }
        if (Numero <= 3)
        {
            System.Console.WriteLine("e primo");
            return true; // 2 and 3 are prime numbers
        }
        if (Numero % 2 == 0 || Numero % 3 == 0)
        {
            System.Console.WriteLine("nao e primo");
            Valor++;
            return Palindromo(Valor); // Numbers divisible by 2 or 3 are not prime
        }

        // Check for prime by testing divisors up to the square root of the number
        for (int i = 5; i * i <= Numero; i += 6)
        {
            if (Numero % i == 0 || Numero % (i + 2) == 0)
            {
                System.Console.WriteLine("nao e primo");
                Valor++;
                return Palindromo(Valor); // Number is divisible by i or i+2, not prime
            }
        }
        System.Console.WriteLine("e primo");
        return true; // Number is prime
    }

    static void Main(string[] args)
    {
        Palindromo(1000);
    }

}