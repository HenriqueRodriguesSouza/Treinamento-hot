using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Programa
{
    public static int Palindromo(int Numero)
    {
        string NumeroString = Numero.ToString();
        char[] charArray = NumeroString.ToCharArray();
        Array.Reverse(charArray);
        string reverseArray = new string(charArray);

        if (nuero == reverseArray)
        {
            System.Console.WriteLine(" verdade");
        }
        else
        {
            System.Console.WriteLine(" falso");
        }

        return Numero;
    }
    static void Main(string[] args)
    {
        Palindromo(1000);
    }

}