

using System.Data;

public class Program
{
   

    public static void Main(string[] args)
    {
        double firstNumber;
        double secondNumber;
        double result;

        Console.WriteLine("Podaj pierwszą liczbę:");
        var getFirstNumber = Console.ReadLine();
        double.TryParse(getFirstNumber, out firstNumber);

        Console.WriteLine("Podaj drugą liczbę:");
        var getSecondNumber = Console.ReadLine();
        double.TryParse(getSecondNumber, out secondNumber);

        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");

        var operation = Console.ReadKey();
        switch (operation.KeyChar)
        {
            case '1':
                SumTwoNumbers(firstNumber, secondNumber);
                break;
            case '2':
                SubstractTwoNumbers(firstNumber, secondNumber);
                break;
            case '3':
                MultiplicationTwoNumbers(firstNumber, secondNumber);
                break;
            case '4':
                DivisionTwoNumbers(firstNumber, secondNumber);
                break;
            default:
                Console.WriteLine("Pdałeś niepoprawny numer operacji...");
                break;
        }
    }

    private static void SumTwoNumbers(double firstNumber, double secondNumber)
    {   
        double result = firstNumber + secondNumber;
        Console.WriteLine($"\nTwój wynik to: {result}"); 
    }

    private static void SubstractTwoNumbers(double firstNumber, double secondNumber)
    {
        double result = firstNumber - secondNumber;
        Console.WriteLine($"\nTwój wynik to: {result}");

    }

    private static void MultiplicationTwoNumbers(double firstNumber, double secondNumber)
    {
        double result = firstNumber * secondNumber;
        Console.WriteLine($"\nTwój wynik to: {result}");
    }

    private static void DivisionTwoNumbers(double firstNumber, double secondNumber)
    {
        double result = firstNumber * secondNumber;
        Console.WriteLine($"\nTwój wynik to: {result}");
    }

}

