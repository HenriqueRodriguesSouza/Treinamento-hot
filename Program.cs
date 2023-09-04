using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Programa
{
    public static bool Palindromo(int NumeroPalindromo)
    {
        string NumeroString = NumeroPalindromo.ToString();
        char[] charArray = NumeroString.ToCharArray();
        Array.Reverse(charArray);
        string reverseArray = new string(charArray);

        if (NumeroString == reverseArray)
        {
            System.Console.WriteLine("verdade para " + NumeroPalindromo);
            return true;
        }
        else
        {
            NumeroPalindromo++;
            return Palindromo(NumeroPalindromo);
        }

    }

    public static int Primo(int NumeroPrimo)
    {

        return NumeroPrimo;
    }

    static void Main(string[] args)
    {
        Palindromo(5556);
    }

}