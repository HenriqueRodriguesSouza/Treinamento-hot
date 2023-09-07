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
            Valor++;
            return Palindromo(Valor);
        }
        if (Numero <= 3)
        {
            return Palindromo(Valor); 
        }
        if (Numero % 2 == 0 || Numero % 3 == 0)
        {
            Valor++;
            return Palindromo(Valor);
        }

        for (int i = 5; i * i <= Numero; i += 6)
        {
            if (Numero % i == 0 || Numero % (i + 2) == 0)
            {
                Valor++;
                return Palindromo(Valor);
            }
        }
        System.Console.WriteLine("O valor " + Valor +" é primo e palindromo");
        return true; 
    }

    static void Main(string[] args)
    {
        System.Console.Write("Digite um numero que mostrarei qual numero apos ele é palindromo e também primo: ");
        int digitado = Convert.ToInt32(Console.ReadLine());
        Palindromo(digitado);
    }

}